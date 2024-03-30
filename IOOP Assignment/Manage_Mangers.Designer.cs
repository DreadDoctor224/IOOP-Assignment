namespace IOOP_Assignment
{
    partial class Manage_Mangers
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
            this.managerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.txtmID = new System.Windows.Forms.TextBox();
            this.txtmuID = new System.Windows.Forms.TextBox();
            this.txtmName = new System.Windows.Forms.TextBox();
            this.txtmEmail = new System.Windows.Forms.TextBox();
            this.txtmph = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mange Mangers";
            // 
            // managerID
            // 
            this.managerID.AutoSize = true;
            this.managerID.Location = new System.Drawing.Point(212, 108);
            this.managerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerID.Name = "managerID";
            this.managerID.Size = new System.Drawing.Size(80, 20);
            this.managerID.TabIndex = 1;
            this.managerID.Text = "MangerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "userID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Teal;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnADD.Location = new System.Drawing.Point(216, 491);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(112, 35);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.Teal;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEDIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEDIT.Location = new System.Drawing.Point(372, 489);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(112, 35);
            this.btnEDIT.TabIndex = 7;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.Teal;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDELETE.Location = new System.Drawing.Point(536, 489);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(112, 35);
            this.btnDELETE.TabIndex = 8;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.BackColor = System.Drawing.Color.Teal;
            this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCLOSE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLOSE.Location = new System.Drawing.Point(372, 588);
            this.btnCLOSE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(112, 35);
            this.btnCLOSE.TabIndex = 9;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.UseVisualStyleBackColor = false;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // txtmID
            // 
            this.txtmID.Location = new System.Drawing.Point(372, 108);
            this.txtmID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmID.Name = "txtmID";
            this.txtmID.Size = new System.Drawing.Size(169, 26);
            this.txtmID.TabIndex = 10;
            // 
            // txtmuID
            // 
            this.txtmuID.Location = new System.Drawing.Point(372, 162);
            this.txtmuID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmuID.Name = "txtmuID";
            this.txtmuID.Size = new System.Drawing.Size(169, 26);
            this.txtmuID.TabIndex = 11;
            // 
            // txtmName
            // 
            this.txtmName.Location = new System.Drawing.Point(372, 212);
            this.txtmName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmName.Name = "txtmName";
            this.txtmName.Size = new System.Drawing.Size(169, 26);
            this.txtmName.TabIndex = 12;
            // 
            // txtmEmail
            // 
            this.txtmEmail.Location = new System.Drawing.Point(372, 269);
            this.txtmEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmEmail.Name = "txtmEmail";
            this.txtmEmail.Size = new System.Drawing.Size(169, 26);
            this.txtmEmail.TabIndex = 13;
            // 
            // txtmph
            // 
            this.txtmph.Location = new System.Drawing.Point(372, 325);
            this.txtmph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmph.Name = "txtmph";
            this.txtmph.Size = new System.Drawing.Size(169, 26);
            this.txtmph.TabIndex = 14;
            // 
            // Manage_Mangers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtmph);
            this.Controls.Add(this.txtmEmail);
            this.Controls.Add(this.txtmName);
            this.Controls.Add(this.txtmuID);
            this.Controls.Add(this.txtmID);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.managerID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Manage_Mangers";
            this.Text = "Manage_Mangers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label managerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.TextBox txtmID;
        private System.Windows.Forms.TextBox txtmuID;
        private System.Windows.Forms.TextBox txtmName;
        private System.Windows.Forms.TextBox txtmEmail;
        private System.Windows.Forms.TextBox txtmph;
    }
}