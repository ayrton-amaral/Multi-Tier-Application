using FinalProjectSecondPart.Business;
using FinalProjectSecondPart.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSecondPart.GUI
{
    // Student Name: Ayrton Senna Seraphim do Amaral
    // Student ID: 2234145

    public partial class CourseAssignmentForm : Form
    {
        public CourseAssignmentForm()
        {
            InitializeComponent();
            displayTeachers();
            displayCourses();
            displayRegistrations();
        }

        private void displayRegistrations()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var selectRegistration = from registrations in context.Registrations select registrations;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Registration ID");
                    dt.Columns.Add("Course Number");
                    dt.Columns.Add("Teacher ID");

                    foreach (var registration in selectRegistration)
                    {
                        dt.Rows.Add(registration.RegistrationID, registration.CourseNumber, registration.TeacherID);
                    }

                    dataGridViewCourseAssignment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void displayCourses()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var selectCourse = from courses in context.Courses select courses;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Course Number");
                    dt.Columns.Add("Course Title");
                    dt.Columns.Add("Duration");

                    foreach (var course in selectCourse)
                    {
                        dt.Rows.Add(course.CourseNumber, course.CourseTitle, course.Duration);
                    }

                    dataGridViewCourses.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void displayTeachers()
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var selectTeacher = from teachers in context.Teachers select teachers;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Teacher ID");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");
                    dt.Columns.Add("Email");

                    foreach (var teacher in selectTeacher)
                    {
                        dt.Rows.Add(teacher.TeacherID, teacher.FirstName, teacher.LastName, teacher.Email);
                    }

                    dataGridViewTeachers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    int registrationID = Int32.Parse(txtBoxRegistrationID.Text);
                    string courseNumber = txtBoxCourseNumber.Text;
                    int teacherID = Int32.Parse(txtBoxTeacherID.Text);

                    int numberOfRegistrations = context.Registrations.Count(registration => registration.TeacherID == teacherID);
                    bool isAlreadyAssigned = context.Registrations.Any(registration => registration.TeacherID == teacherID && registration.CourseNumber == courseNumber);
                    bool isAlreadyUsedRegistrationID = context.Registrations.Any(registration => registration.RegistrationID == registrationID);
                    bool isCourseNumberExists = context.Courses.Any(course => course.CourseNumber == courseNumber);
                    bool isTeacherIDExists = context.Teachers.Any(teacher => teacher.TeacherID == teacherID);

                    if (!isAlreadyUsedRegistrationID)
                    {
                        if (!isAlreadyAssigned)
                        {
                            if (numberOfRegistrations < 4)
                            {
                                if (isCourseNumberExists)
                                {
                                    if(isTeacherIDExists)
                                    {
                                        var registrationToAdd = new Registration();

                                        registrationToAdd.RegistrationID = Int32.Parse(txtBoxRegistrationID.Text);
                                        registrationToAdd.CourseNumber = txtBoxCourseNumber.Text;
                                        registrationToAdd.TeacherID = teacherID;

                                        context.Registrations.Add(registrationToAdd);

                                        context.SaveChanges();

                                        MessageBox.Show("The Course was Assigned to the Teacher Successfully.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        displayRegistrations();
                                    }
                                    else
                                    {
                                        MessageBox.Show("The Teacher ID entered was not found.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The Course Number entered was not found.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("A Teacher can teach only 4 courses per Term.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Course is already Assigned to this Teacher.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Registration ID is already registered.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("To Assign a Course to a Teacher you must Enter the Registration ID, Course Number and Teacher ID.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var searchCoursesByTeacher = from registrations in context.Registrations
                                                 join courses in context.Courses
                                                 on registrations.CourseNumber equals courses.CourseNumber
                                                 where registrations.TeacherID.ToString() == txtBoxSearchTeacherID.Text
                                                 select registrations;                    

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Teacher ID");
                    dt.Columns.Add("Course Number");

                    foreach (var teacher in searchCoursesByTeacher)
                    {
                        dt.Rows.Add(teacher.TeacherID, teacher.CourseNumber);
                    }

                    dataGridViewCoursesByTeacher.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            // Modify:
            // I'm using the 'Registration ID' to edit/update my Registrations
            if(txtBoxRegistrationID.Text == "")
            {
                MessageBox.Show("To Modify a Registration you must Enter the Registration ID, Course Number and Teacher ID.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (var context = new TeacherCourseDBEntities())
                    {
                        int registrationID = Int32.Parse(txtBoxRegistrationID.Text);

                        var modifyRegistration = context.Registrations.SingleOrDefault(registration => registration.RegistrationID == registrationID);

                        if (modifyRegistration != null)
                        {
                            modifyRegistration.CourseNumber = txtBoxCourseNumber.Text;
                            modifyRegistration.TeacherID = Int32.Parse(txtBoxTeacherID.Text);

                            context.SaveChanges();

                            MessageBox.Show("The Registration was Modified Successfully.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayRegistrations();
                        }
                        else
                        {
                            MessageBox.Show("The Registration ID entered was not found.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }    
                catch (Exception)
                {
                    MessageBox.Show("To Modify a Registration you must Enter the Registration ID, Course Number and Teacher ID.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtBoxRegistrationID.Text == "")
            {
                MessageBox.Show("To Remove a Registration you must Enter the Registration ID.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (var context = new TeacherCourseDBEntities())
                    {
                        int registrationID = Int32.Parse(txtBoxRegistrationID.Text);

                        var removeRegistration = context.Registrations.SingleOrDefault(registration => registration.RegistrationID == registrationID);

                        if (removeRegistration != null)
                        {
                            context.Registrations.Remove(removeRegistration);

                            context.SaveChanges();

                            MessageBox.Show("The Registration was Removed Successfully.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayRegistrations();
                        }
                        else
                        {
                            MessageBox.Show("The Registration ID entered was not found.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("To Remove a Registration you must Enter the Registration ID.", "George Brown Technology Institution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout from\nTeacher-Course Management System?", "George Brown Technology Institution", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
        
    }
}
