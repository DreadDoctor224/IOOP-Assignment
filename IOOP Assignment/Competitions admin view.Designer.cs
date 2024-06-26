﻿namespace IOOP_Assignment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.data_grid_competitions = new System.Windows.Forms.DataGridView();
            this.competitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.Btn_dtl03 = new System.Windows.Forms.Button();
            this.Btn_ext06 = new System.Windows.Forms.Button();
            this.Btn_hmpage008 = new System.Windows.Forms.Button();
            
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_competitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).BeginInit();
            
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
            // data_grid_competitions
            // 
            this.data_grid_competitions.AutoGenerateColumns = false;
            this.data_grid_competitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_competitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.competitionIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.data_grid_competitions.DataSource = this.competitionsBindingSource;
            this.data_grid_competitions.Location = new System.Drawing.Point(19, 89);
            this.data_grid_competitions.Name = "data_grid_competitions";
            this.data_grid_competitions.RowHeadersWidth = 62;
            this.data_grid_competitions.RowTemplate.Height = 28;
            this.data_grid_competitions.Size = new System.Drawing.Size(1261, 534);
            this.data_grid_competitions.TabIndex = 1;
            // 
            // competitionsBindingSource
            // 
            this.competitionsBindingSource.DataMember = "competitions";
            
            // 
            // ioopDBDataSet4
            // 
           
            // 
            // Btn_dtl03
            // 
            this.Btn_dtl03.BackColor = System.Drawing.Color.Teal;
            this.Btn_dtl03.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dtl03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_dtl03.Location = new System.Drawing.Point(551, 698);
            this.Btn_dtl03.Name = "Btn_dtl03";
            this.Btn_dtl03.Size = new System.Drawing.Size(154, 61);
            this.Btn_dtl03.TabIndex = 2;
            this.Btn_dtl03.Text = "Details";
            this.Btn_dtl03.UseVisualStyleBackColor = false;
            this.Btn_dtl03.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_ext06
            // 
            this.Btn_ext06.BackColor = System.Drawing.Color.Teal;
            this.Btn_ext06.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ext06.ForeColor = System.Drawing.Color.White;
            this.Btn_ext06.Location = new System.Drawing.Point(1121, 698);
            this.Btn_ext06.Name = "Btn_ext06";
            this.Btn_ext06.Size = new System.Drawing.Size(159, 61);
            this.Btn_ext06.TabIndex = 3;
            this.Btn_ext06.Text = "Exit";
            this.Btn_ext06.UseVisualStyleBackColor = false;
            this.Btn_ext06.Click += new System.EventHandler(this.Btn_ext06_Click);
            // 
            // Btn_hmpage008
            // 
            this.Btn_hmpage008.BackColor = System.Drawing.Color.Teal;
            this.Btn_hmpage008.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hmpage008.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_hmpage008.Location = new System.Drawing.Point(12, 703);
            this.Btn_hmpage008.Name = "Btn_hmpage008";
            this.Btn_hmpage008.Size = new System.Drawing.Size(148, 61);
            this.Btn_hmpage008.TabIndex = 4;
            this.Btn_hmpage008.Text = "Home Page";
            this.Btn_hmpage008.UseVisualStyleBackColor = false;
            // 
            // competitionsTableAdapter
            // 
            
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Member ID ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Member_Name ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Win";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lost";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // competitionIDDataGridViewTextBoxColumn
            // 
            this.competitionIDDataGridViewTextBoxColumn.DataPropertyName = "competitionID";
            this.competitionIDDataGridViewTextBoxColumn.HeaderText = "CompetitionID";
            this.competitionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.competitionIDDataGridViewTextBoxColumn.Name = "competitionIDDataGridViewTextBoxColumn";
            this.competitionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "managerID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "ManagerID";
            this.managerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // Competitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1301, 771);
            this.Controls.Add(this.Btn_hmpage008);
            this.Controls.Add(this.Btn_ext06);
            this.Controls.Add(this.Btn_dtl03);
            this.Controls.Add(this.data_grid_competitions);
            this.Controls.Add(this.label1);
            this.Name = "Competitions";
            this.Text = "Competitions";
            this.Load += new System.EventHandler(this.Competitions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_competitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_grid_competitions;
        private System.Windows.Forms.Button Btn_dtl03;
        private System.Windows.Forms.Button Btn_ext06;
        private System.Windows.Forms.Button Btn_hmpage008;
        private System.Windows.Forms.BindingSource competitionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}