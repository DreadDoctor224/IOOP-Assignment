namespace IOOP_Assignment
{
    partial class updateProfile
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
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.txtPassWordUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "password";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(363, 109);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(148, 26);
            this.txtNameUpdate.TabIndex = 5;
            this.txtNameUpdate.TextChanged += new System.EventHandler(this.txtNameUpdate_TextChanged);
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Location = new System.Drawing.Point(363, 168);
            this.txtEmailUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(148, 26);
            this.txtEmailUpdate.TabIndex = 6;
            // 
            // txtPhoneNumberUpdate
            // 
            this.txtPhoneNumberUpdate.Location = new System.Drawing.Point(363, 226);
            this.txtPhoneNumberUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumberUpdate.Name = "txtPhoneNumberUpdate";
            this.txtPhoneNumberUpdate.Size = new System.Drawing.Size(148, 26);
            this.txtPhoneNumberUpdate.TabIndex = 7;
            // 
            // txtPassWordUpdate
            // 
            this.txtPassWordUpdate.Location = new System.Drawing.Point(363, 285);
            this.txtPassWordUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassWordUpdate.Name = "txtPassWordUpdate";
            this.txtPassWordUpdate.Size = new System.Drawing.Size(148, 26);
            this.txtPassWordUpdate.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(327, 369);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassWordUpdate);
            this.Controls.Add(this.txtPhoneNumberUpdate);
            this.Controls.Add(this.txtEmailUpdate);
            this.Controls.Add(this.txtNameUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "updateProfile";
            this.Text = "updateProfile";
            this.Load += new System.EventHandler(this.updateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.TextBox txtPhoneNumberUpdate;
        private System.Windows.Forms.TextBox txtPassWordUpdate;
        private System.Windows.Forms.Button btnUpdate;
    }
}