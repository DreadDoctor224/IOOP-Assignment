﻿namespace IOOP_Assignment
{
    partial class signUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameSignUp = new System.Windows.Forms.TextBox();
            this.txtPhNumberSignUp = new System.Windows.Forms.TextBox();
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.txtEmailSignUp = new System.Windows.Forms.TextBox();
            this.txtPassWordSignUp = new System.Windows.Forms.TextBox();
            this.txtRoleSignUp = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignUp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role";
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.Location = new System.Drawing.Point(268, 87);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtNameSignUp.TabIndex = 7;
            // 
            // txtPhNumberSignUp
            // 
            this.txtPhNumberSignUp.Location = new System.Drawing.Point(268, 123);
            this.txtPhNumberSignUp.Name = "txtPhNumberSignUp";
            this.txtPhNumberSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtPhNumberSignUp.TabIndex = 8;
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(268, 157);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameSignUp.TabIndex = 9;
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Location = new System.Drawing.Point(268, 188);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtEmailSignUp.TabIndex = 10;
            // 
            // txtPassWordSignUp
            // 
            this.txtPassWordSignUp.Location = new System.Drawing.Point(268, 228);
            this.txtPassWordSignUp.Name = "txtPassWordSignUp";
            this.txtPassWordSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtPassWordSignUp.TabIndex = 11;
            // 
            // txtRoleSignUp
            // 
            this.txtRoleSignUp.Location = new System.Drawing.Point(268, 261);
            this.txtRoleSignUp.Name = "txtRoleSignUp";
            this.txtRoleSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtRoleSignUp.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(268, 319);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtRoleSignUp);
            this.Controls.Add(this.txtPassWordSignUp);
            this.Controls.Add(this.txtEmailSignUp);
            this.Controls.Add(this.txtUserNameSignUp);
            this.Controls.Add(this.txtPhNumberSignUp);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameSignUp;
        private System.Windows.Forms.TextBox txtPhNumberSignUp;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.TextBox txtEmailSignUp;
        private System.Windows.Forms.TextBox txtPassWordSignUp;
        private System.Windows.Forms.TextBox txtRoleSignUp;
        private System.Windows.Forms.Button btnSignUp;
    }
}