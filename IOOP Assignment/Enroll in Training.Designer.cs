namespace IOOP_Assignment
{
    partial class Member_enroll_in_training
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
            this.combo_box_training_type = new System.Windows.Forms.ComboBox();
            this.combo_box_level = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_training_fee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_box_training_type
            // 
            this.combo_box_training_type.FormattingEnabled = true;
            this.combo_box_training_type.Location = new System.Drawing.Point(333, 197);
            this.combo_box_training_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_box_training_type.Name = "combo_box_training_type";
            this.combo_box_training_type.Size = new System.Drawing.Size(180, 28);
            this.combo_box_training_type.TabIndex = 0;
            // 
            // combo_box_level
            // 
            this.combo_box_level.FormattingEnabled = true;
            this.combo_box_level.Location = new System.Drawing.Point(687, 197);
            this.combo_box_level.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_box_level.Name = "combo_box_level";
            this.combo_box_level.Size = new System.Drawing.Size(180, 28);
            this.combo_box_level.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Training Type";
            // 
            // label_training_fee
            // 
            this.label_training_fee.AutoSize = true;
            this.label_training_fee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_training_fee.Location = new System.Drawing.Point(333, 342);
            this.label_training_fee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_training_fee.Name = "label_training_fee";
            this.label_training_fee.Size = new System.Drawing.Size(2, 22);
            this.label_training_fee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Training Fee";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(452, 469);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(112, 35);
            this.btn_pay.TabIndex = 6;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(644, 469);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Member_enroll_in_training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_training_fee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_level);
            this.Controls.Add(this.combo_box_training_type);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Member_enroll_in_training";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_box_training_type;
        private System.Windows.Forms.ComboBox combo_box_level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_training_fee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_exit;
    }
}