namespace IOOP_Assignment
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
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.txtRoleSignUp = new System.Windows.Forms.TextBox();
            this.txtPassWordSignUp = new System.Windows.Forms.TextBox();
            this.txtEmailSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up Form";
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(271, 76);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameSignUp.TabIndex = 1;
            // 
            // txtRoleSignUp
            // 
            this.txtRoleSignUp.Location = new System.Drawing.Point(271, 125);
            this.txtRoleSignUp.Name = "txtRoleSignUp";
            this.txtRoleSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtRoleSignUp.TabIndex = 2;
            // 
            // txtPassWordSignUp
            // 
            this.txtPassWordSignUp.Location = new System.Drawing.Point(271, 178);
            this.txtPassWordSignUp.Name = "txtPassWordSignUp";
            this.txtPassWordSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtPassWordSignUp.TabIndex = 3;
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Location = new System.Drawing.Point(271, 229);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtEmailSignUp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passwrod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(238, 288);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailSignUp);
            this.Controls.Add(this.txtPassWordSignUp);
            this.Controls.Add(this.txtRoleSignUp);
            this.Controls.Add(this.txtUserNameSignUp);
            this.Controls.Add(this.label1);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.TextBox txtRoleSignUp;
        private System.Windows.Forms.TextBox txtPassWordSignUp;
        private System.Windows.Forms.TextBox txtEmailSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignUp;
    }
}