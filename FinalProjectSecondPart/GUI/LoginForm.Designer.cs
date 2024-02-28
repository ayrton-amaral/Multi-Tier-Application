namespace FinalProjectSecondPart.GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.txtBoxUserIDLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPasswordReveal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(165, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExitApplication.Location = new System.Drawing.Point(445, 337);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(87, 31);
            this.btnExitApplication.TabIndex = 4;
            this.btnExitApplication.Text = "E&xit";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // txtBoxUserIDLogin
            // 
            this.txtBoxUserIDLogin.Location = new System.Drawing.Point(241, 174);
            this.txtBoxUserIDLogin.Name = "txtBoxUserIDLogin";
            this.txtBoxUserIDLogin.Size = new System.Drawing.Size(158, 20);
            this.txtBoxUserIDLogin.TabIndex = 5;
            // 
            // txtBoxPasswordLogin
            // 
            this.txtBoxPasswordLogin.Location = new System.Drawing.Point(241, 217);
            this.txtBoxPasswordLogin.Name = "txtBoxPasswordLogin";
            this.txtBoxPasswordLogin.PasswordChar = '*';
            this.txtBoxPasswordLogin.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPasswordLogin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "George Brown Technology Institution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teacher-Course Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Welcome, program coordinator!\r\nEnter your credentials to access the system.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPasswordReveal
            // 
            this.btnPasswordReveal.Image = global::FinalProjectSecondPart.Properties.Resources.eyePswd;
            this.btnPasswordReveal.Location = new System.Drawing.Point(368, 211);
            this.btnPasswordReveal.Name = "btnPasswordReveal";
            this.btnPasswordReveal.Size = new System.Drawing.Size(31, 31);
            this.btnPasswordReveal.TabIndex = 11;
            this.btnPasswordReveal.UseVisualStyleBackColor = true;
            this.btnPasswordReveal.Click += new System.EventHandler(this.btnPasswordReveal_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 380);
            this.Controls.Add(this.btnPasswordReveal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPasswordLogin);
            this.Controls.Add(this.txtBoxUserIDLogin);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.TextBox txtBoxUserIDLogin;
        private System.Windows.Forms.TextBox txtBoxPasswordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPasswordReveal;
    }
}