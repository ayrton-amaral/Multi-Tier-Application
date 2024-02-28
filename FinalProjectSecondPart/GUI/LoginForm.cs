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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TeacherCourseDBEntities())
                {
                    var selectQuery = from user in context.Users
                                          where user.UserID.ToString() == txtBoxUserIDLogin.Text 
                                          && user.Password == txtBoxPasswordLogin.Text
                                          && user.JobTitle == "Program Coordinator"
                                          select user;

                    if (selectQuery.Any())
                    {
                        CourseAssignmentForm courseAssignmentForm = new CourseAssignmentForm();

                        courseAssignmentForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User ID or Password. Try again!", "George Brown Technology Institution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        txtBoxUserIDLogin.Text = "";
                        txtBoxPasswordLogin.Text = "";

                        txtBoxUserIDLogin.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the\nTeacher-Course Management System?", "George Brown Technology Institution", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnPasswordReveal_Click(object sender, EventArgs e)
        {
            txtBoxPasswordLogin.PasswordChar = (txtBoxPasswordLogin.PasswordChar == '\0') ? '*' : '\0';
        }
    }
}
