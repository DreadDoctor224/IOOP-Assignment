﻿namespace IOOP_Assignment
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
            this.components = new System.ComponentModel.Container();
            this.data_grid_suggestions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ioopDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_suggest = new System.Windows.Forms.Label();
            this.Btn_hmpage05 = new System.Windows.Forms.Button();
            this.Btn_detailsug = new System.Windows.Forms.Button();
            this.Btn_exi8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_suggestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet1BindingSource)).BeginInit();
            
            this.SuspendLayout();
            // 
            // data_grid_suggestions
            // 
            this.data_grid_suggestions.AutoGenerateColumns = false;
            this.data_grid_suggestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_suggestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_grid_suggestions.DataSource = this.ioopDBDataSet1BindingSource;
            this.data_grid_suggestions.Location = new System.Drawing.Point(19, 83);
            this.data_grid_suggestions.Name = "data_grid_suggestions";
            this.data_grid_suggestions.RowHeadersWidth = 62;
            this.data_grid_suggestions.RowTemplate.Height = 28;
            this.data_grid_suggestions.Size = new System.Drawing.Size(966, 549);
            this.data_grid_suggestions.TabIndex = 0;
            this.data_grid_suggestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView6_CellContentClick);
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
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // ioopDBDataSet1BindingSource
            // 
           
            this.ioopDBDataSet1BindingSource.Position = 0;
            // 
            // ioopDBDataSet1
            // 
            
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
            // Btn_hmpage05
            // 
            this.Btn_hmpage05.BackColor = System.Drawing.Color.Teal;
            this.Btn_hmpage05.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_hmpage05.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hmpage05.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_hmpage05.Location = new System.Drawing.Point(19, 689);
            this.Btn_hmpage05.Name = "Btn_hmpage05";
            this.Btn_hmpage05.Size = new System.Drawing.Size(139, 58);
            this.Btn_hmpage05.TabIndex = 2;
            this.Btn_hmpage05.Text = "Home Page";
            this.Btn_hmpage05.UseVisualStyleBackColor = false;
            // 
            // Btn_detailsug
            // 
            this.Btn_detailsug.BackColor = System.Drawing.Color.Teal;
            this.Btn_detailsug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_detailsug.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_detailsug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_detailsug.Location = new System.Drawing.Point(454, 689);
            this.Btn_detailsug.Name = "Btn_detailsug";
            this.Btn_detailsug.Size = new System.Drawing.Size(112, 61);
            this.Btn_detailsug.TabIndex = 3;
            this.Btn_detailsug.Text = "Details";
            this.Btn_detailsug.UseVisualStyleBackColor = false;
            // 
            // Btn_exi8
            // 
            this.Btn_exi8.BackColor = System.Drawing.Color.Teal;
            this.Btn_exi8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_exi8.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exi8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_exi8.Location = new System.Drawing.Point(882, 689);
            this.Btn_exi8.Name = "Btn_exi8";
            this.Btn_exi8.Size = new System.Drawing.Size(103, 58);
            this.Btn_exi8.TabIndex = 4;
            this.Btn_exi8.Text = "Exit";
            this.Btn_exi8.UseVisualStyleBackColor = false;
            this.Btn_exi8.Click += new System.EventHandler(this.Btn_exi8_Click);
            // 
            // Suggestion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 771);
            this.Controls.Add(this.Btn_exi8);
            this.Controls.Add(this.Btn_detailsug);
            this.Controls.Add(this.Btn_hmpage05);
            this.Controls.Add(this.lbl_suggest);
            this.Controls.Add(this.data_grid_suggestions);
            this.Name = "Suggestion_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suggestion_Form";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_suggestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet1BindingSource)).EndInit();
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_suggestions;
        private System.Windows.Forms.Label lbl_suggest;
        private System.Windows.Forms.Button Btn_hmpage05;
        private System.Windows.Forms.Button Btn_detailsug;
        private System.Windows.Forms.Button Btn_exi8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.BindingSource ioopDBDataSet1BindingSource;
        
    }
}