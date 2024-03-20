namespace IOOP_Assignment
{
    partial class Competitions
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
            this.datagridview6 = new System.Windows.Forms.DataGridView();
            this.btn_dtl003 = new System.Windows.Forms.Button();
            this.btn_ext006 = new System.Windows.Forms.Button();
            this.btn_hmpage008 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competitions Form";
            // 
            // datagridview6
            // 
            this.datagridview6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.datagridview6.Location = new System.Drawing.Point(19, 89);
            this.datagridview6.Name = "datagridview6";
            this.datagridview6.RowHeadersWidth = 62;
            this.datagridview6.RowTemplate.Height = 28;
            this.datagridview6.Size = new System.Drawing.Size(750, 534);
            this.datagridview6.TabIndex = 1;
            // 
            // btn_dtl003
            // 
            this.btn_dtl003.BackColor = System.Drawing.Color.Teal;
            this.btn_dtl003.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtl003.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dtl003.Location = new System.Drawing.Point(362, 703);
            this.btn_dtl003.Name = "btn_dtl003";
            this.btn_dtl003.Size = new System.Drawing.Size(154, 61);
            this.btn_dtl003.TabIndex = 2;
            this.btn_dtl003.Text = "Details";
            this.btn_dtl003.UseVisualStyleBackColor = false;
            this.btn_dtl003.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ext006
            // 
            this.btn_ext006.BackColor = System.Drawing.Color.Teal;
            this.btn_ext006.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext006.ForeColor = System.Drawing.Color.White;
            this.btn_ext006.Location = new System.Drawing.Point(695, 703);
            this.btn_ext006.Name = "btn_ext006";
            this.btn_ext006.Size = new System.Drawing.Size(159, 61);
            this.btn_ext006.TabIndex = 3;
            this.btn_ext006.Text = "Exit";
            this.btn_ext006.UseVisualStyleBackColor = false;
            // 
            // btn_hmpage008
            // 
            this.btn_hmpage008.BackColor = System.Drawing.Color.Teal;
            this.btn_hmpage008.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hmpage008.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hmpage008.Location = new System.Drawing.Point(12, 703);
            this.btn_hmpage008.Name = "btn_hmpage008";
            this.btn_hmpage008.Size = new System.Drawing.Size(148, 61);
            this.btn_hmpage008.TabIndex = 4;
            this.btn_hmpage008.Text = "Home Page";
            this.btn_hmpage008.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Competitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(883, 771);
            this.Controls.Add(this.btn_hmpage008);
            this.Controls.Add(this.btn_ext006);
            this.Controls.Add(this.btn_dtl003);
            this.Controls.Add(this.datagridview6);
            this.Controls.Add(this.label1);
            this.Name = "Competitions";
            this.Text = "Competitions";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview6;
        private System.Windows.Forms.Button btn_dtl003;
        private System.Windows.Forms.Button btn_ext006;
        private System.Windows.Forms.Button btn_hmpage008;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}