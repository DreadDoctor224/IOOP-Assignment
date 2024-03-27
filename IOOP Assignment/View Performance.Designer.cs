namespace IOOP_Assignment
{
    partial class Performance_Form
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
            this.data_grid_performance = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberCompetitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ioopDBDataSet2 = new IOOP_Assignment.ioopDBDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.memberCompetitionsTableAdapter = new IOOP_Assignment.ioopDBDataSet2TableAdapters.memberCompetitionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_performance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberCompetitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Performance";
            // 
            // data_grid_performance
            // 
            this.data_grid_performance.AutoGenerateColumns = false;
            this.data_grid_performance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_performance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.competitionIDDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.data_grid_performance.DataSource = this.memberCompetitionsBindingSource;
            this.data_grid_performance.Location = new System.Drawing.Point(42, 98);
            this.data_grid_performance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_grid_performance.Name = "data_grid_performance";
            this.data_grid_performance.RowHeadersWidth = 62;
            this.data_grid_performance.Size = new System.Drawing.Size(1112, 511);
            this.data_grid_performance.TabIndex = 1;
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
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.Width = 150;
            // 
            // memberCompetitionsBindingSource
            // 
            this.memberCompetitionsBindingSource.DataMember = "memberCompetitions";
            this.memberCompetitionsBindingSource.DataSource = this.ioopDBDataSet2;
            // 
            // ioopDBDataSet2
            // 
            this.ioopDBDataSet2.DataSetName = "ioopDBDataSet2";
            this.ioopDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 638);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memberCompetitionsTableAdapter
            // 
            this.memberCompetitionsTableAdapter.ClearBeforeFill = true;
            // 
            // Performance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_grid_performance);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Performance_Form";
            this.Text = "Performance Form";
            this.Load += new System.EventHandler(this.Performance_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_performance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberCompetitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ioopDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_grid_performance;
        private System.Windows.Forms.Button button1;
        private ioopDBDataSet2 ioopDBDataSet2;
        private System.Windows.Forms.BindingSource memberCompetitionsBindingSource;
        private ioopDBDataSet2TableAdapters.memberCompetitionsTableAdapter memberCompetitionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}