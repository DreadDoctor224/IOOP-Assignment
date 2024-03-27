namespace IOOP_Assignment
{
    partial class manager_view_recommendations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ioopDBDataSet = new IOOP_Assignment.ioopDBDataSet();
            this.recommendationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recommendationsTableAdapter = new IOOP_Assignment.ioopDBDataSetTableAdapters.RecommendationsTableAdapter();
            this.recommendationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recommendationIDDataGridViewTextBoxColumn,
            this.coachIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.competitionIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recommendationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(168, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(669, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ioopDBDataSet
            // 
            this.ioopDBDataSet.DataSetName = "ioopDBDataSet";
            this.ioopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recommendationsBindingSource
            // 
            this.recommendationsBindingSource.DataMember = "Recommendations";
            this.recommendationsBindingSource.DataSource = this.ioopDBDataSet;
            // 
            // recommendationsTableAdapter
            // 
            this.recommendationsTableAdapter.ClearBeforeFill = true;
            // 
            // recommendationIDDataGridViewTextBoxColumn
            // 
            this.recommendationIDDataGridViewTextBoxColumn.DataPropertyName = "recommendationID";
            this.recommendationIDDataGridViewTextBoxColumn.HeaderText = "recommendationID";
            this.recommendationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recommendationIDDataGridViewTextBoxColumn.Name = "recommendationIDDataGridViewTextBoxColumn";
            this.recommendationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recommendationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // coachIDDataGridViewTextBoxColumn
            // 
            this.coachIDDataGridViewTextBoxColumn.DataPropertyName = "coachID";
            this.coachIDDataGridViewTextBoxColumn.HeaderText = "coachID";
            this.coachIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coachIDDataGridViewTextBoxColumn.Name = "coachIDDataGridViewTextBoxColumn";
            this.coachIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "memberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // competitionIDDataGridViewTextBoxColumn
            // 
            this.competitionIDDataGridViewTextBoxColumn.DataPropertyName = "competitionID";
            this.competitionIDDataGridViewTextBoxColumn.HeaderText = "competitionID";
            this.competitionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.competitionIDDataGridViewTextBoxColumn.Name = "competitionIDDataGridViewTextBoxColumn";
            this.competitionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(447, 604);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // manager_view_recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1050, 738);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manager_view_recommendations";
            this.Text = "manager_view_recommendations";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ioopDBDataSet ioopDBDataSet;
        private System.Windows.Forms.BindingSource recommendationsBindingSource;
        private ioopDBDataSetTableAdapters.RecommendationsTableAdapter recommendationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_exit;
    }
}