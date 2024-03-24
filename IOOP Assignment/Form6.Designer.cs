namespace IOOP_Assignment
{
    partial class Form6
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
            this.combo_box_members = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_remarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_up_down_members = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_members)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_box_members
            // 
            this.combo_box_members.FormattingEnabled = true;
            this.combo_box_members.Location = new System.Drawing.Point(498, 166);
            this.combo_box_members.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_box_members.Name = "combo_box_members";
            this.combo_box_members.Size = new System.Drawing.Size(180, 28);
            this.combo_box_members.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member:";
            // 
            // textBox_remarks
            // 
            this.textBox_remarks.Location = new System.Drawing.Point(498, 540);
            this.textBox_remarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_remarks.Name = "textBox_remarks";
            this.textBox_remarks.Size = new System.Drawing.Size(180, 26);
            this.textBox_remarks.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remarks:";
            // 
            // numeric_up_down_members
            // 
            this.numeric_up_down_members.Location = new System.Drawing.Point(500, 258);
            this.numeric_up_down_members.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_up_down_members.Name = "numeric_up_down_members";
            this.numeric_up_down_members.Size = new System.Drawing.Size(180, 26);
            this.numeric_up_down_members.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.numeric_up_down_members);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_remarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_members);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_box_members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_remarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_up_down_members;
    }
}