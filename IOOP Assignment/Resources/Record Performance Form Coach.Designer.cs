namespace IOOP_Assignment.Resources
{
    partial class Record_Performance_Form_Coach
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
            this.Box_combo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_save2 = new System.Windows.Forms.Button();
            this.Btn_exit5 = new System.Windows.Forms.Button();
            this.DataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_combo1
            // 
            this.Box_combo1.FormattingEnabled = true;
            this.Box_combo1.Location = new System.Drawing.Point(32, 161);
            this.Box_combo1.Name = "Box_combo1";
            this.Box_combo1.Size = new System.Drawing.Size(214, 28);
            this.Box_combo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record Performance Form ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select the individual you are recording performance. ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_save2
            // 
            this.Btn_save2.BackColor = System.Drawing.Color.Teal;
            this.Btn_save2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_save2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save2.ForeColor = System.Drawing.Color.White;
            this.Btn_save2.Location = new System.Drawing.Point(32, 628);
            this.Btn_save2.Name = "Btn_save2";
            this.Btn_save2.Size = new System.Drawing.Size(106, 61);
            this.Btn_save2.TabIndex = 3;
            this.Btn_save2.Text = "Save";
            this.Btn_save2.UseVisualStyleBackColor = false;
            // 
            // Btn_exit5
            // 
            this.Btn_exit5.BackColor = System.Drawing.Color.Teal;
            this.Btn_exit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_exit5.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit5.ForeColor = System.Drawing.Color.White;
            this.Btn_exit5.Location = new System.Drawing.Point(728, 616);
            this.Btn_exit5.Name = "Btn_exit5";
            this.Btn_exit5.Size = new System.Drawing.Size(106, 61);
            this.Btn_exit5.TabIndex = 4;
            this.Btn_exit5.Text = "Exit";
            this.Btn_exit5.UseVisualStyleBackColor = false;
            // 
            // DataGridView4
            // 
            this.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView4.Location = new System.Drawing.Point(32, 223);
            this.DataGridView4.Name = "DataGridView4";
            this.DataGridView4.RowHeadersWidth = 62;
            this.DataGridView4.RowTemplate.Height = 28;
            this.DataGridView4.Size = new System.Drawing.Size(421, 350);
            this.DataGridView4.TabIndex = 5;
            // 
            // Record_Performance_Form_Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(846, 701);
            this.Controls.Add(this.DataGridView4);
            this.Controls.Add(this.Btn_exit5);
            this.Controls.Add(this.Btn_save2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box_combo1);
            this.Name = "Record_Performance_Form_Coach";
            this.Text = "Record_Performance_Form_Coach";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Box_combo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_save2;
        private System.Windows.Forms.Button Btn_exit5;
        private System.Windows.Forms.DataGridView DataGridView4;
    }
}