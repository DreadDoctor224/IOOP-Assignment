namespace IOOP_Assignment
{
    partial class Update_Profile
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
            this.Txtbox_name2 = new System.Windows.Forms.TextBox();
            this.Btn_updatepfadmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtbox_pw2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtbox_email2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtbox_ph2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Your Profile ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Txtbox_name2
            // 
            this.Txtbox_name2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txtbox_name2.Location = new System.Drawing.Point(148, 190);
            this.Txtbox_name2.Multiline = true;
            this.Txtbox_name2.Name = "Txtbox_name2";
            this.Txtbox_name2.Size = new System.Drawing.Size(231, 52);
            this.Txtbox_name2.TabIndex = 6;
            this.Txtbox_name2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Btn_updatepfadmin
            // 
            this.Btn_updatepfadmin.BackColor = System.Drawing.Color.Teal;
            this.Btn_updatepfadmin.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_updatepfadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_updatepfadmin.Location = new System.Drawing.Point(251, 614);
            this.Btn_updatepfadmin.Name = "Btn_updatepfadmin";
            this.Btn_updatepfadmin.Size = new System.Drawing.Size(461, 86);
            this.Btn_updatepfadmin.TabIndex = 11;
            this.Btn_updatepfadmin.Text = "Update Profile";
            this.Btn_updatepfadmin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Txtbox_pw2
            // 
            this.Txtbox_pw2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txtbox_pw2.Location = new System.Drawing.Point(550, 190);
            this.Txtbox_pw2.Multiline = true;
            this.Txtbox_pw2.Name = "Txtbox_pw2";
            this.Txtbox_pw2.Size = new System.Drawing.Size(231, 52);
            this.Txtbox_pw2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email ";
            // 
            // Txtbox_email2
            // 
            this.Txtbox_email2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txtbox_email2.Location = new System.Drawing.Point(148, 305);
            this.Txtbox_email2.Multiline = true;
            this.Txtbox_email2.Name = "Txtbox_email2";
            this.Txtbox_email2.Size = new System.Drawing.Size(231, 52);
            this.Txtbox_email2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Phone Number";
            // 
            // Txtbox_ph2
            // 
            this.Txtbox_ph2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txtbox_ph2.Location = new System.Drawing.Point(550, 305);
            this.Txtbox_ph2.Multiline = true;
            this.Txtbox_ph2.Name = "Txtbox_ph2";
            this.Txtbox_ph2.Size = new System.Drawing.Size(231, 52);
            this.Txtbox_ph2.TabIndex = 17;
            // 
            // Update_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(978, 771);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbox_ph2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtbox_email2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtbox_pw2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_updatepfadmin);
            this.Controls.Add(this.Txtbox_name2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Profile";
            this.Text = "Update_Profile_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbox_name2;
        private System.Windows.Forms.Button Btn_updatepfadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtbox_pw2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtbox_email2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtbox_ph2;
    }
}