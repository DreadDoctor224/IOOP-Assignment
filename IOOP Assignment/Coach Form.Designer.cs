namespace IOOP_Assignment
{
    partial class Admin_Add_Coach
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
            this.components = new System.ComponentModel.Container();
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ioopDBDataSet6 = new IOOP_Assignment.ioopDBDataSet6();
            this.btn_add_coach = new System.Windows.Forms.Button();
            this.btn_edit_coach = new System.Windows.Forms.Button();
            this.btn_del_coach = new System.Windows.Forms.Button();
            this.btn_exit004 = new System.Windows.Forms.Button();
            this.btn_coatbl = new System.Windows.Forms.Label();
            this.coachesTableAdapter = new IOOP_Assignment.ioopDBDataSet6TableAdapters.coachesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // coachesBindingSource
            // 
            this.coachesBindingSource.DataMember = "coaches";
            this.coachesBindingSource.DataSource = this.ioopDBDataSet6;
            // 
            // ioopDBDataSet6
            // 
            this.ioopDBDataSet6.DataSetName = "ioopDBDataSet6";
            this.ioopDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add_coach
            // 
            this.btn_add_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_add_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_coach.Location = new System.Drawing.Point(352, 542);
            this.btn_add_coach.Name = "btn_add_coach";
            this.btn_add_coach.Size = new System.Drawing.Size(143, 57);
            this.btn_add_coach.TabIndex = 1;
            this.btn_add_coach.Text = "Add Coach";
            this.btn_add_coach.UseVisualStyleBackColor = false;
            // 
            // btn_edit_coach
            // 
            this.btn_edit_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_edit_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_coach.Location = new System.Drawing.Point(579, 537);
            this.btn_edit_coach.Name = "btn_edit_coach";
            this.btn_edit_coach.Size = new System.Drawing.Size(143, 62);
            this.btn_edit_coach.TabIndex = 2;
            this.btn_edit_coach.Text = "Edit Coach";
            this.btn_edit_coach.UseVisualStyleBackColor = false;
            // 
            // btn_del_coach
            // 
            this.btn_del_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_del_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del_coach.Location = new System.Drawing.Point(816, 532);
            this.btn_del_coach.Name = "btn_del_coach";
            this.btn_del_coach.Size = new System.Drawing.Size(143, 76);
            this.btn_del_coach.TabIndex = 3;
            this.btn_del_coach.Text = "Delete Coach";
            this.btn_del_coach.UseVisualStyleBackColor = false;
            // 
            // btn_exit004
            // 
            this.btn_exit004.BackColor = System.Drawing.Color.Teal;
            this.btn_exit004.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit004.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit004.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit004.Location = new System.Drawing.Point(579, 654);
            this.btn_exit004.Name = "btn_exit004";
            this.btn_exit004.Size = new System.Drawing.Size(143, 73);
            this.btn_exit004.TabIndex = 4;
            this.btn_exit004.Text = "Exit";
            this.btn_exit004.UseVisualStyleBackColor = false;
            this.btn_exit004.Click += new System.EventHandler(this.btn_exit004_Click);
            // 
            // btn_coatbl
            // 
            this.btn_coatbl.AutoSize = true;
            this.btn_coatbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coatbl.Location = new System.Drawing.Point(510, 82);
            this.btn_coatbl.Name = "btn_coatbl";
            this.btn_coatbl.Size = new System.Drawing.Size(212, 37);
            this.btn_coatbl.TabIndex = 5;
            this.btn_coatbl.Text = "Coach Table";
            // 
            // coachesTableAdapter
            // 
            this.coachesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coach ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // txtCoachID
            // 
            this.txtCoachID.Location = new System.Drawing.Point(517, 194);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(232, 26);
            this.txtCoachID.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(517, 252);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 26);
            this.txtName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(517, 314);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(517, 382);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(232, 26);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(517, 436);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(232, 26);
            this.txtRole.TabIndex = 15;
            // 
            // Admin_Add_Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCoachID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_coatbl);
            this.Controls.Add(this.btn_exit004);
            this.Controls.Add(this.btn_del_coach);
            this.Controls.Add(this.btn_edit_coach);
            this.Controls.Add(this.btn_add_coach);
            this.Name = "Admin_Add_Coach";
            this.Text = "Coach_Form";
            this.Load += new System.EventHandler(this.Coach_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add_coach;
        private System.Windows.Forms.Button btn_edit_coach;
        private System.Windows.Forms.Button btn_del_coach;
        private System.Windows.Forms.Button btn_exit004;
        private System.Windows.Forms.Label btn_coatbl;
        private ioopDBDataSet6 ioopDBDataSet6;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private ioopDBDataSet6TableAdapters.coachesTableAdapter coachesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoachID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtRole;
    }
}