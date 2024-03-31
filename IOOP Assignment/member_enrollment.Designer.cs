namespace IOOP_Assignment
{
    partial class member_enrollment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnUnenroll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMem = new System.Windows.Forms.TextBox();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.txtTrainingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.txtUnpaid = new System.Windows.Forms.CheckBox();
            this.txtsubmitFeedBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(21, 310);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Location = new System.Drawing.Point(112, 310);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(75, 23);
            this.btnUnenroll.TabIndex = 3;
            this.btnUnenroll.Text = "Unenroll";
            this.btnUnenroll.UseVisualStyleBackColor = true;
            this.btnUnenroll.Click += new System.EventHandler(this.btnUnenroll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FeedBack
            // 
            this.FeedBack.AutoSize = true;
            this.FeedBack.Location = new System.Drawing.Point(501, 252);
            this.FeedBack.Name = "FeedBack";
            this.FeedBack.Size = new System.Drawing.Size(55, 13);
            this.FeedBack.TabIndex = 5;
            this.FeedBack.Text = "Feedback";
            this.FeedBack.Click += new System.EventHandler(this.FeedBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trainings available";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMem
            // 
            this.txtMem.Location = new System.Drawing.Point(123, 21);
            this.txtMem.Name = "txtMem";
            this.txtMem.Size = new System.Drawing.Size(100, 20);
            this.txtMem.TabIndex = 7;
            this.txtMem.TextChanged += new System.EventHandler(this.txtMem_TextChanged);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Location = new System.Drawing.Point(504, 285);
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.Size = new System.Drawing.Size(187, 20);
            this.txtFeedBack.TabIndex = 8;
            this.txtFeedBack.TextChanged += new System.EventHandler(this.txtFeedBack_TextChanged);
            // 
            // txtTrainingID
            // 
            this.txtTrainingID.Location = new System.Drawing.Point(123, 70);
            this.txtTrainingID.Name = "txtTrainingID";
            this.txtTrainingID.Size = new System.Drawing.Size(100, 20);
            this.txtTrainingID.TabIndex = 9;
            this.txtTrainingID.TextChanged += new System.EventHandler(this.txtTrainingID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Training ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(21, 353);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPaid.TabIndex = 11;
            this.checkBoxPaid.Text = "Paid";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            this.checkBoxPaid.CheckedChanged += new System.EventHandler(this.checkBoxPaid_CheckedChanged);
            // 
            // txtUnpaid
            // 
            this.txtUnpaid.AutoSize = true;
            this.txtUnpaid.Location = new System.Drawing.Point(21, 377);
            this.txtUnpaid.Name = "txtUnpaid";
            this.txtUnpaid.Size = new System.Drawing.Size(60, 17);
            this.txtUnpaid.TabIndex = 12;
            this.txtUnpaid.Text = "Unpaid";
            this.txtUnpaid.UseVisualStyleBackColor = true;
            this.txtUnpaid.CheckedChanged += new System.EventHandler(this.txtUnpaid_CheckedChanged);
            // 
            // txtsubmitFeedBack
            // 
            this.txtsubmitFeedBack.Location = new System.Drawing.Point(504, 330);
            this.txtsubmitFeedBack.Name = "txtsubmitFeedBack";
            this.txtsubmitFeedBack.Size = new System.Drawing.Size(75, 23);
            this.txtsubmitFeedBack.TabIndex = 13;
            this.txtsubmitFeedBack.Text = "Submit";
            this.txtsubmitFeedBack.UseVisualStyleBackColor = true;
            this.txtsubmitFeedBack.Click += new System.EventHandler(this.txtsubmitFeedBack_Click);
            // 
            // member_enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsubmitFeedBack);
            this.Controls.Add(this.txtUnpaid);
            this.Controls.Add(this.checkBoxPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrainingID);
            this.Controls.Add(this.txtFeedBack);
            this.Controls.Add(this.txtMem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FeedBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnenroll);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.comboBox1);
            this.Name = "member_enrollment";
            this.Text = "member_enrollment";
            this.Load += new System.EventHandler(this.member_enrollment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FeedBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMem;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.TextBox txtTrainingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.CheckBox txtUnpaid;
        private System.Windows.Forms.Button txtsubmitFeedBack;
    }
}