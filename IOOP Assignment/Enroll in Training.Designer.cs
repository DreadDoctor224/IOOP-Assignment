namespace IOOP_Assignment
{
    partial class Form11
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
            this.combo_box_training_type.Location = new System.Drawing.Point(222, 128);
            this.combo_box_training_type.Name = "combo_box_training_type";
            this.combo_box_training_type.Size = new System.Drawing.Size(121, 21);
            this.combo_box_training_type.TabIndex = 0;
            // 
            // combo_box_level
            // 
            this.combo_box_level.FormattingEnabled = true;
            this.combo_box_level.Location = new System.Drawing.Point(458, 128);
            this.combo_box_level.Name = "combo_box_level";
            this.combo_box_level.Size = new System.Drawing.Size(121, 21);
            this.combo_box_level.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Training Type";
            // 
            // label_training_fee
            // 
            this.label_training_fee.AutoSize = true;
            this.label_training_fee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_training_fee.Location = new System.Drawing.Point(222, 222);
            this.label_training_fee.Name = "label_training_fee";
            this.label_training_fee.Size = new System.Drawing.Size(2, 15);
            this.label_training_fee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Training Fee";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(301, 305);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_pay.TabIndex = 6;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(429, 305);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_training_fee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_level);
            this.Controls.Add(this.combo_box_training_type);
            this.Name = "Form11";
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