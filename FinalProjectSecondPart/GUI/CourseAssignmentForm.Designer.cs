namespace FinalProjectSecondPart.GUI
{
    partial class CourseAssignmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAssignmentForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCoursesByTeacher = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelSearchTeacherAndCourses = new System.Windows.Forms.Label();
            this.txtBoxSearchTeacherID = new System.Windows.Forms.TextBox();
            this.lblSearchTeacherID = new System.Windows.Forms.Label();
            this.groupBoxTeachers = new System.Windows.Forms.GroupBox();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAvailableCourses = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewCourseAssignment = new System.Windows.Forms.DataGridView();
            this.groupBoxAssignCourse = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.txtBoxTeacherID = new System.Windows.Forms.TextBox();
            this.txtBoxRegistrationID = new System.Windows.Forms.TextBox();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblRegistrationID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBoxAllCourses = new System.Windows.Forms.GroupBox();
            this.groupBoxRegistrations = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesByTeacher)).BeginInit();
            this.groupBoxTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseAssignment)).BeginInit();
            this.groupBoxAssignCourse.SuspendLayout();
            this.groupBoxAllCourses.SuspendLayout();
            this.groupBoxRegistrations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(670, 566);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBoxTeachers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teachers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCoursesByTeacher);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.labelSearchTeacherAndCourses);
            this.groupBox2.Controls.Add(this.txtBoxSearchTeacherID);
            this.groupBox2.Controls.Add(this.lblSearchTeacherID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher\'s Courses";
            // 
            // dataGridViewCoursesByTeacher
            // 
            this.dataGridViewCoursesByTeacher.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewCoursesByTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCoursesByTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoursesByTeacher.Location = new System.Drawing.Point(26, 120);
            this.dataGridViewCoursesByTeacher.Name = "dataGridViewCoursesByTeacher";
            this.dataGridViewCoursesByTeacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCoursesByTeacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCoursesByTeacher.Size = new System.Drawing.Size(530, 145);
            this.dataGridViewCoursesByTeacher.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(364, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelSearchTeacherAndCourses
            // 
            this.labelSearchTeacherAndCourses.AutoSize = true;
            this.labelSearchTeacherAndCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTeacherAndCourses.Location = new System.Drawing.Point(127, 35);
            this.labelSearchTeacherAndCourses.Name = "labelSearchTeacherAndCourses";
            this.labelSearchTeacherAndCourses.Size = new System.Drawing.Size(350, 17);
            this.labelSearchTeacherAndCourses.TabIndex = 2;
            this.labelSearchTeacherAndCourses.Text = "See all the Courses a Teacher is teaching in this Term";
            // 
            // txtBoxSearchTeacherID
            // 
            this.txtBoxSearchTeacherID.Location = new System.Drawing.Point(234, 71);
            this.txtBoxSearchTeacherID.Name = "txtBoxSearchTeacherID";
            this.txtBoxSearchTeacherID.Size = new System.Drawing.Size(124, 23);
            this.txtBoxSearchTeacherID.TabIndex = 1;
            // 
            // lblSearchTeacherID
            // 
            this.lblSearchTeacherID.AutoSize = true;
            this.lblSearchTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTeacherID.Location = new System.Drawing.Point(146, 74);
            this.lblSearchTeacherID.Name = "lblSearchTeacherID";
            this.lblSearchTeacherID.Size = new System.Drawing.Size(82, 17);
            this.lblSearchTeacherID.TabIndex = 0;
            this.lblSearchTeacherID.Text = "Teacher ID:";
            // 
            // groupBoxTeachers
            // 
            this.groupBoxTeachers.Controls.Add(this.dataGridViewTeachers);
            this.groupBoxTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTeachers.Location = new System.Drawing.Point(40, 17);
            this.groupBoxTeachers.Name = "groupBoxTeachers";
            this.groupBoxTeachers.Size = new System.Drawing.Size(585, 201);
            this.groupBoxTeachers.TabIndex = 0;
            this.groupBoxTeachers.TabStop = false;
            this.groupBoxTeachers.Text = "List of Teachers";
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(26, 34);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewTeachers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(530, 140);
            this.dataGridViewTeachers.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxAllCourses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAvailableCourses
            // 
            this.lblAvailableCourses.AutoSize = true;
            this.lblAvailableCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourses.Location = new System.Drawing.Point(220, 44);
            this.lblAvailableCourses.Name = "lblAvailableCourses";
            this.lblAvailableCourses.Size = new System.Drawing.Size(197, 17);
            this.lblAvailableCourses.TabIndex = 7;
            this.lblAvailableCourses.Text = "Available Courses in the Term";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(55, 99);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCourses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCourses.Size = new System.Drawing.Size(514, 345);
            this.dataGridViewCourses.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxRegistrations);
            this.tabPage3.Controls.Add(this.groupBoxAssignCourse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(662, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Course Assignment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCourseAssignment
            // 
            this.dataGridViewCourseAssignment.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewCourseAssignment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCourseAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseAssignment.Location = new System.Drawing.Point(23, 31);
            this.dataGridViewCourseAssignment.Name = "dataGridViewCourseAssignment";
            this.dataGridViewCourseAssignment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewCourseAssignment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCourseAssignment.Size = new System.Drawing.Size(514, 212);
            this.dataGridViewCourseAssignment.TabIndex = 10;
            // 
            // groupBoxAssignCourse
            // 
            this.groupBoxAssignCourse.Controls.Add(this.btnRemove);
            this.groupBoxAssignCourse.Controls.Add(this.btnModify);
            this.groupBoxAssignCourse.Controls.Add(this.btnAssign);
            this.groupBoxAssignCourse.Controls.Add(this.txtBoxCourseNumber);
            this.groupBoxAssignCourse.Controls.Add(this.txtBoxTeacherID);
            this.groupBoxAssignCourse.Controls.Add(this.txtBoxRegistrationID);
            this.groupBoxAssignCourse.Controls.Add(this.lblCourseNumber);
            this.groupBoxAssignCourse.Controls.Add(this.lblTeacherID);
            this.groupBoxAssignCourse.Controls.Add(this.lblRegistrationID);
            this.groupBoxAssignCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAssignCourse.Location = new System.Drawing.Point(49, 18);
            this.groupBoxAssignCourse.Name = "groupBoxAssignCourse";
            this.groupBoxAssignCourse.Size = new System.Drawing.Size(559, 208);
            this.groupBoxAssignCourse.TabIndex = 0;
            this.groupBoxAssignCourse.TabStop = false;
            this.groupBoxAssignCourse.Text = "Assign Course";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(391, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(391, 86);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(86, 29);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(391, 34);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(86, 29);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "&Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtBoxCourseNumber
            // 
            this.txtBoxCourseNumber.Location = new System.Drawing.Point(198, 92);
            this.txtBoxCourseNumber.Name = "txtBoxCourseNumber";
            this.txtBoxCourseNumber.Size = new System.Drawing.Size(144, 23);
            this.txtBoxCourseNumber.TabIndex = 4;
            // 
            // txtBoxTeacherID
            // 
            this.txtBoxTeacherID.Location = new System.Drawing.Point(198, 137);
            this.txtBoxTeacherID.Name = "txtBoxTeacherID";
            this.txtBoxTeacherID.Size = new System.Drawing.Size(144, 23);
            this.txtBoxTeacherID.TabIndex = 6;
            // 
            // txtBoxRegistrationID
            // 
            this.txtBoxRegistrationID.Location = new System.Drawing.Point(198, 43);
            this.txtBoxRegistrationID.Name = "txtBoxRegistrationID";
            this.txtBoxRegistrationID.Size = new System.Drawing.Size(144, 23);
            this.txtBoxRegistrationID.TabIndex = 2;
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Location = new System.Drawing.Point(81, 95);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(111, 17);
            this.lblCourseNumber.TabIndex = 3;
            this.lblCourseNumber.Text = "Course Number:";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Location = new System.Drawing.Point(110, 140);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(82, 17);
            this.lblTeacherID.TabIndex = 5;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // lblRegistrationID
            // 
            this.lblRegistrationID.AutoSize = true;
            this.lblRegistrationID.Location = new System.Drawing.Point(87, 46);
            this.lblRegistrationID.Name = "lblRegistrationID";
            this.lblRegistrationID.Size = new System.Drawing.Size(105, 17);
            this.lblRegistrationID.TabIndex = 1;
            this.lblRegistrationID.Text = "Registration ID:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogout.Location = new System.Drawing.Point(581, 586);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 31);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBoxAllCourses
            // 
            this.groupBoxAllCourses.Controls.Add(this.dataGridViewCourses);
            this.groupBoxAllCourses.Controls.Add(this.lblAvailableCourses);
            this.groupBoxAllCourses.Location = new System.Drawing.Point(18, 15);
            this.groupBoxAllCourses.Name = "groupBoxAllCourses";
            this.groupBoxAllCourses.Size = new System.Drawing.Size(617, 498);
            this.groupBoxAllCourses.TabIndex = 8;
            this.groupBoxAllCourses.TabStop = false;
            this.groupBoxAllCourses.Text = "List of Courses";
            // 
            // groupBoxRegistrations
            // 
            this.groupBoxRegistrations.Controls.Add(this.dataGridViewCourseAssignment);
            this.groupBoxRegistrations.Location = new System.Drawing.Point(49, 243);
            this.groupBoxRegistrations.Name = "groupBoxRegistrations";
            this.groupBoxRegistrations.Size = new System.Drawing.Size(559, 267);
            this.groupBoxRegistrations.TabIndex = 11;
            this.groupBoxRegistrations.TabStop = false;
            this.groupBoxRegistrations.Text = "Registrations";
            // 
            // CourseAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 623);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseAssignmentForm";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoursesByTeacher)).EndInit();
            this.groupBoxTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseAssignment)).EndInit();
            this.groupBoxAssignCourse.ResumeLayout(false);
            this.groupBoxAssignCourse.PerformLayout();
            this.groupBoxAllCourses.ResumeLayout(false);
            this.groupBoxAllCourses.PerformLayout();
            this.groupBoxRegistrations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxAssignCourse;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtBoxCourseNumber;
        private System.Windows.Forms.TextBox txtBoxTeacherID;
        private System.Windows.Forms.TextBox txtBoxRegistrationID;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblRegistrationID;
        private System.Windows.Forms.DataGridView dataGridViewCourseAssignment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTeachers;
        private System.Windows.Forms.Label lblAvailableCourses;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.DataGridView dataGridViewCoursesByTeacher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearchTeacherAndCourses;
        private System.Windows.Forms.TextBox txtBoxSearchTeacherID;
        private System.Windows.Forms.Label lblSearchTeacherID;
        private System.Windows.Forms.GroupBox groupBoxAllCourses;
        private System.Windows.Forms.GroupBox groupBoxRegistrations;
    }
}