namespace IOOP_Assignment
{
    partial class Suggestion_Form
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl_suggest = new System.Windows.Forms.Label();
            this.btn_hmpage = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(19, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(514, 407);
            this.dataGridView3.TabIndex = 0;
            // 
            // lbl_suggest
            // 
            this.lbl_suggest.AutoSize = true;
            this.lbl_suggest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suggest.Location = new System.Drawing.Point(12, 9);
            this.lbl_suggest.Name = "lbl_suggest";
            this.lbl_suggest.Size = new System.Drawing.Size(287, 37);
            this.lbl_suggest.TabIndex = 1;
            this.lbl_suggest.Text = "Suggestion Form ";
            // 
            // btn_hmpage
            // 
            this.btn_hmpage.BackColor = System.Drawing.Color.Teal;
            this.btn_hmpage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hmpage.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hmpage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hmpage.Location = new System.Drawing.Point(19, 585);
            this.btn_hmpage.Name = "btn_hmpage";
            this.btn_hmpage.Size = new System.Drawing.Size(139, 58);
            this.btn_hmpage.TabIndex = 2;
            this.btn_hmpage.Text = "Home Page";
            this.btn_hmpage.UseVisualStyleBackColor = false;
            // 
            // btn_detail
            // 
            this.btn_detail.BackColor = System.Drawing.Color.Teal;
            this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_detail.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_detail.Location = new System.Drawing.Point(300, 585);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(112, 58);
            this.btn_detail.TabIndex = 3;
            this.btn_detail.Text = "Details";
            this.btn_detail.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Teal;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(571, 592);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 51);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Members";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Suggestion";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Suggestion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(686, 674);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_hmpage);
            this.Controls.Add(this.lbl_suggest);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Suggestion_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suggestion_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbl_suggest;
        private System.Windows.Forms.Button btn_hmpage;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}