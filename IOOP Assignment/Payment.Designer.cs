namespace IOOP_Assignment
{
    partial class Form4
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
            this.data_gird_payment = new System.Windows.Forms.DataGridView();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutstandingFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_gird_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gird_payment
            // 
            this.data_gird_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gird_payment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member,
            this.Fine,
            this.Overdue,
            this.OutstandingFee,
            this.Paid});
            this.data_gird_payment.Location = new System.Drawing.Point(111, 93);
            this.data_gird_payment.Name = "data_gird_payment";
            this.data_gird_payment.RowHeadersWidth = 62;
            this.data_gird_payment.Size = new System.Drawing.Size(641, 310);
            this.data_gird_payment.TabIndex = 0;
            // 
            // Member
            // 
            this.Member.HeaderText = "Member";
            this.Member.MinimumWidth = 8;
            this.Member.Name = "Member";
            this.Member.Width = 150;
            // 
            // Fine
            // 
            this.Fine.HeaderText = "Fine";
            this.Fine.MinimumWidth = 8;
            this.Fine.Name = "Fine";
            this.Fine.Width = 150;
            // 
            // Overdue
            // 
            this.Overdue.HeaderText = "Overdue";
            this.Overdue.MinimumWidth = 8;
            this.Overdue.Name = "Overdue";
            this.Overdue.Width = 150;
            // 
            // OutstandingFee
            // 
            this.OutstandingFee.HeaderText = "Outstanding Fee";
            this.OutstandingFee.MinimumWidth = 8;
            this.OutstandingFee.Name = "OutstandingFee";
            this.OutstandingFee.Width = 150;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.MinimumWidth = 8;
            this.Paid.Name = "Paid";
            this.Paid.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(911, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_gird_payment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.data_gird_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_gird_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overdue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutstandingFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}