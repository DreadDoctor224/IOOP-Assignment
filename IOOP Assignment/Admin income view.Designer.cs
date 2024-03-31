namespace IOOP_Assignment
{
    partial class Admin_income_view
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
            this.Lbl_incomeadmin = new System.Windows.Forms.Label();
            this.DataGridViewadmincome = new System.Windows.Forms.DataGridView();
            this.Btn_homepage001 = new System.Windows.Forms.Button();
            this.Btn_exit96 = new System.Windows.Forms.Button();
            
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.coachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewadmincome)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_incomeadmin
            // 
            this.Lbl_incomeadmin.AutoSize = true;
            this.Lbl_incomeadmin.Font = new System.Drawing.Font("Franklin Gothic Book", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_incomeadmin.Location = new System.Drawing.Point(12, 30);
            this.Lbl_incomeadmin.Name = "Lbl_incomeadmin";
            this.Lbl_incomeadmin.Size = new System.Drawing.Size(316, 47);
            this.Lbl_incomeadmin.TabIndex = 0;
            this.Lbl_incomeadmin.Text = "Monthly Income ";
            // 
            // DataGridViewadmincome
            // 
            this.DataGridViewadmincome.AutoGenerateColumns = false;
            this.DataGridViewadmincome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewadmincome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coachIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn});
            this.DataGridViewadmincome.DataSource = this.coachesBindingSource;
            this.DataGridViewadmincome.Location = new System.Drawing.Point(124, 122);
            this.DataGridViewadmincome.Name = "DataGridViewadmincome";
            this.DataGridViewadmincome.RowHeadersWidth = 62;
            this.DataGridViewadmincome.RowTemplate.Height = 28;
            this.DataGridViewadmincome.Size = new System.Drawing.Size(520, 401);
            this.DataGridViewadmincome.TabIndex = 1;
            this.DataGridViewadmincome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewadmincome_CellContentClick);
            // 
            // Btn_homepage001
            // 
            this.Btn_homepage001.BackColor = System.Drawing.Color.Teal;
            this.Btn_homepage001.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_homepage001.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_homepage001.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_homepage001.Location = new System.Drawing.Point(20, 592);
            this.Btn_homepage001.Name = "Btn_homepage001";
            this.Btn_homepage001.Size = new System.Drawing.Size(159, 81);
            this.Btn_homepage001.TabIndex = 2;
            this.Btn_homepage001.Text = "Home Page";
            this.Btn_homepage001.UseVisualStyleBackColor = false;
            // 
            // Btn_exit96
            // 
            this.Btn_exit96.BackColor = System.Drawing.Color.Teal;
            this.Btn_exit96.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_exit96.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit96.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_exit96.Location = new System.Drawing.Point(560, 592);
            this.Btn_exit96.Name = "Btn_exit96";
            this.Btn_exit96.Size = new System.Drawing.Size(159, 81);
            this.Btn_exit96.TabIndex = 3;
            this.Btn_exit96.Text = "EXIT";
            this.Btn_exit96.UseVisualStyleBackColor = false;
            this.Btn_exit96.Click += new System.EventHandler(this.Btn_exit96_Click);
            // 
            // ioopDBDataSet5
            // 
            
            // 
            // coachesBindingSource
            // 
            this.coachesBindingSource.DataMember = "coaches";
            
            // 
            // coachesTableAdapter
            // 
            
            // 
            // coachIDDataGridViewTextBoxColumn
            // 
            this.coachIDDataGridViewTextBoxColumn.DataPropertyName = "coachID";
            this.coachIDDataGridViewTextBoxColumn.HeaderText = "coachID";
            this.coachIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coachIDDataGridViewTextBoxColumn.Name = "coachIDDataGridViewTextBoxColumn";
            this.coachIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Admin_income_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(774, 685);
            this.Controls.Add(this.Btn_exit96);
            this.Controls.Add(this.Btn_homepage001);
            this.Controls.Add(this.DataGridViewadmincome);
            this.Controls.Add(this.Lbl_incomeadmin);
            this.Name = "Admin_income_view";
            this.Text = "Admin_income_view";
            this.Load += new System.EventHandler(this.Admin_income_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewadmincome)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_incomeadmin;
        private System.Windows.Forms.DataGridView DataGridViewadmincome;
        private System.Windows.Forms.Button Btn_homepage001;
        private System.Windows.Forms.Button Btn_exit96;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
    }
}