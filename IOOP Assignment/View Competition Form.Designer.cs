namespace IOOP_Assignment
{
    partial class View_Competition_Form
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
            this.btn_exit004 = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_hmpage003 = new System.Windows.Forms.Button();
            this.lbl_suggest = new System.Windows.Forms.Label();
            this.data_grid_competitions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_competitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).BeginInit();
            
            this.SuspendLayout();
            // 
            // btn_exit004
            // 
            this.btn_exit004.BackColor = System.Drawing.Color.Teal;
            this.btn_exit004.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit004.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit004.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit004.Location = new System.Drawing.Point(1188, 703);
            this.btn_exit004.Name = "btn_exit004";
            this.btn_exit004.Size = new System.Drawing.Size(104, 51);
            this.btn_exit004.TabIndex = 9;
            this.btn_exit004.Text = "Exit";
            this.btn_exit004.UseVisualStyleBackColor = false;
            this.btn_exit004.Click += new System.EventHandler(this.btn_exit004_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.BackColor = System.Drawing.Color.Teal;
            this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_detail.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_detail.Location = new System.Drawing.Point(600, 695);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(112, 58);
            this.btn_detail.TabIndex = 8;
            this.btn_detail.Text = "Details";
            this.btn_detail.UseVisualStyleBackColor = false;
            // 
            // btn_hmpage003
            // 
            this.btn_hmpage003.BackColor = System.Drawing.Color.Teal;
            this.btn_hmpage003.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hmpage003.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hmpage003.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hmpage003.Location = new System.Drawing.Point(27, 695);
            this.btn_hmpage003.Name = "btn_hmpage003";
            this.btn_hmpage003.Size = new System.Drawing.Size(140, 58);
            this.btn_hmpage003.TabIndex = 7;
            this.btn_hmpage003.Text = "Home Page";
            this.btn_hmpage003.UseVisualStyleBackColor = false;
            // 
            // lbl_suggest
            // 
            this.lbl_suggest.AutoSize = true;
            this.lbl_suggest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suggest.Location = new System.Drawing.Point(20, 15);
            this.lbl_suggest.Name = "lbl_suggest";
            this.lbl_suggest.Size = new System.Drawing.Size(310, 37);
            this.lbl_suggest.TabIndex = 6;
            this.lbl_suggest.Text = "Competitions Form";
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
            this.Column5,
            this.Column6,
            this.competitionIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.data_grid_competitions.DataSource = this.competitionsBindingSource;
            this.data_grid_competitions.Location = new System.Drawing.Point(203, 86);
            this.data_grid_competitions.Name = "data_grid_competitions";
            this.data_grid_competitions.RowHeadersWidth = 62;
            this.data_grid_competitions.RowTemplate.Height = 28;
            this.data_grid_competitions.Size = new System.Drawing.Size(966, 549);
            this.data_grid_competitions.TabIndex = 5;
            this.data_grid_competitions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            // competitionIDDataGridViewTextBoxColumn
            // 
            this.competitionIDDataGridViewTextBoxColumn.DataPropertyName = "competitionID";
            this.competitionIDDataGridViewTextBoxColumn.HeaderText = "competitionID";
            this.competitionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.competitionIDDataGridViewTextBoxColumn.Name = "competitionIDDataGridViewTextBoxColumn";
            this.competitionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "managerID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "managerID";
            this.managerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // competitionsBindingSource
            // 
            this.competitionsBindingSource.DataMember = "competitions";
            
            // 
            // ioopDBDataSet3
            // 
            
            // 
            // competitionsTableAdapter
            // 
            
            // 
            // View_Competition_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.btn_exit004);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_hmpage003);
            this.Controls.Add(this.lbl_suggest);
            this.Controls.Add(this.data_grid_competitions);
            this.Name = "View_Competition_Form";
            this.Text = "View_Competition_Form";
            this.Load += new System.EventHandler(this.View_Competition_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_competitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit004;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_hmpage003;
        private System.Windows.Forms.Label lbl_suggest;
        private System.Windows.Forms.DataGridView data_grid_competitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.BindingSource competitionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}