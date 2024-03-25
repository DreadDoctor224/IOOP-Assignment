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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_members)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_box_members
            // 
            this.combo_box_members.FormattingEnabled = true;
            this.combo_box_members.Location = new System.Drawing.Point(332, 108);
            this.combo_box_members.Name = "combo_box_members";
            this.combo_box_members.Size = new System.Drawing.Size(121, 21);
            this.combo_box_members.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member:";
            // 
            // textBox_remarks
            // 
            this.textBox_remarks.Location = new System.Drawing.Point(332, 264);
            this.textBox_remarks.Name = "textBox_remarks";
            this.textBox_remarks.Size = new System.Drawing.Size(121, 20);
            this.textBox_remarks.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remarks:";
            // 
            // numeric_up_down_members
            // 
            this.numeric_up_down_members.Location = new System.Drawing.Point(333, 168);
            this.numeric_up_down_members.Name = "numeric_up_down_members";
            this.numeric_up_down_members.Size = new System.Drawing.Size(120, 20);
            this.numeric_up_down_members.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeric_up_down_members);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_remarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_members);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}