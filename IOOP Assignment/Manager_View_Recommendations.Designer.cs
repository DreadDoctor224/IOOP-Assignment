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
            this.recommendationsBindingSource = new System.Windows.Forms.BindingSource(this.components);;
            this.btn_exit = new System.Windows.Forms.Button();
            this.recommendationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recommendationIDDataGridViewTextBoxColumn,
            this.coachNameDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.competitionNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recommendationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(112, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(446, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recommendationsBindingSource
            // 
            this.recommendationsBindingSource.DataMember = "Recommendations";

            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(298, 393);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // recommendationIDDataGridViewTextBoxColumn
            // 
            this.recommendationIDDataGridViewTextBoxColumn.DataPropertyName = "recommendationID";
            this.recommendationIDDataGridViewTextBoxColumn.HeaderText = "recommendationID";
            this.recommendationIDDataGridViewTextBoxColumn.Name = "recommendationIDDataGridViewTextBoxColumn";
            this.recommendationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coachNameDataGridViewTextBoxColumn
            // 
            this.coachNameDataGridViewTextBoxColumn.DataPropertyName = "coachName";
            this.coachNameDataGridViewTextBoxColumn.HeaderText = "coachName";
            this.coachNameDataGridViewTextBoxColumn.Name = "coachNameDataGridViewTextBoxColumn";
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "memberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            // 
            // competitionNameDataGridViewTextBoxColumn
            // 
            this.competitionNameDataGridViewTextBoxColumn.DataPropertyName = "competitionName";
            this.competitionNameDataGridViewTextBoxColumn.HeaderText = "competitionName";
            this.competitionNameDataGridViewTextBoxColumn.Name = "competitionNameDataGridViewTextBoxColumn";
            // 
            // manager_view_recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "manager_view_recommendations";
            this.Text = "manager_view_recommendations";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recommendationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionNameDataGridViewTextBoxColumn;
    }
}