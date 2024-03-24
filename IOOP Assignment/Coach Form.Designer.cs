namespace IOOP_Assignment
{
    partial class Coach_Form
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
            this.data_grid_coach = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_coach = new System.Windows.Forms.Button();
            this.btn_edit_coach = new System.Windows.Forms.Button();
            this.btn_del_coach = new System.Windows.Forms.Button();
            this.btn_exit004 = new System.Windows.Forms.Button();
            this.btn_coatbl = new System.Windows.Forms.Label();
            this.btn_hmpage001 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_coach)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_coach
            // 
            this.data_grid_coach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_coach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.data_grid_coach.Location = new System.Drawing.Point(128, 89);
            this.data_grid_coach.Name = "data_grid_coach";
            this.data_grid_coach.RowHeadersWidth = 62;
            this.data_grid_coach.RowTemplate.Height = 28;
            this.data_grid_coach.Size = new System.Drawing.Size(992, 560);
            this.data_grid_coach.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 150;
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
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // btn_add_coach
            // 
            this.btn_add_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_add_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_coach.Location = new System.Drawing.Point(1156, 89);
            this.btn_add_coach.Name = "btn_add_coach";
            this.btn_add_coach.Size = new System.Drawing.Size(143, 57);
            this.btn_add_coach.TabIndex = 1;
            this.btn_add_coach.Text = "Add Coach";
            this.btn_add_coach.UseVisualStyleBackColor = false;
            // 
            // btn_edit_coach
            // 
            this.btn_edit_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_edit_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_coach.Location = new System.Drawing.Point(1156, 179);
            this.btn_edit_coach.Name = "btn_edit_coach";
            this.btn_edit_coach.Size = new System.Drawing.Size(143, 62);
            this.btn_edit_coach.TabIndex = 2;
            this.btn_edit_coach.Text = "Edit Coach";
            this.btn_edit_coach.UseVisualStyleBackColor = false;
            // 
            // btn_del_coach
            // 
            this.btn_del_coach.BackColor = System.Drawing.Color.Teal;
            this.btn_del_coach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_coach.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_coach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del_coach.Location = new System.Drawing.Point(1156, 274);
            this.btn_del_coach.Name = "btn_del_coach";
            this.btn_del_coach.Size = new System.Drawing.Size(143, 76);
            this.btn_del_coach.TabIndex = 3;
            this.btn_del_coach.Text = "Delete Coach";
            this.btn_del_coach.UseVisualStyleBackColor = false;
            // 
            // btn_exit004
            // 
            this.btn_exit004.BackColor = System.Drawing.Color.Teal;
            this.btn_exit004.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit004.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit004.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit004.Location = new System.Drawing.Point(1156, 686);
            this.btn_exit004.Name = "btn_exit004";
            this.btn_exit004.Size = new System.Drawing.Size(143, 73);
            this.btn_exit004.TabIndex = 4;
            this.btn_exit004.Text = "Exit";
            this.btn_exit004.UseVisualStyleBackColor = false;
            // 
            // btn_coatbl
            // 
            this.btn_coatbl.AutoSize = true;
            this.btn_coatbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coatbl.Location = new System.Drawing.Point(12, 9);
            this.btn_coatbl.Name = "btn_coatbl";
            this.btn_coatbl.Size = new System.Drawing.Size(212, 37);
            this.btn_coatbl.TabIndex = 5;
            this.btn_coatbl.Text = "Coach Table";
            // 
            // btn_hmpage001
            // 
            this.btn_hmpage001.BackColor = System.Drawing.Color.Teal;
            this.btn_hmpage001.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hmpage001.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hmpage001.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hmpage001.Location = new System.Drawing.Point(19, 686);
            this.btn_hmpage001.Name = "btn_hmpage001";
            this.btn_hmpage001.Size = new System.Drawing.Size(132, 73);
            this.btn_hmpage001.TabIndex = 6;
            this.btn_hmpage001.Text = "Home Page";
            this.btn_hmpage001.UseVisualStyleBackColor = false;
            // 
            // Coach_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.btn_hmpage001);
            this.Controls.Add(this.btn_coatbl);
            this.Controls.Add(this.btn_exit004);
            this.Controls.Add(this.btn_del_coach);
            this.Controls.Add(this.btn_edit_coach);
            this.Controls.Add(this.btn_add_coach);
            this.Controls.Add(this.data_grid_coach);
            this.Name = "Coach_Form";
            this.Text = "Coach_Form";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_coach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_coach;
        private System.Windows.Forms.Button btn_add_coach;
        private System.Windows.Forms.Button btn_edit_coach;
        private System.Windows.Forms.Button btn_del_coach;
        private System.Windows.Forms.Button btn_exit004;
        private System.Windows.Forms.Label btn_coatbl;
        private System.Windows.Forms.Button btn_hmpage001;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}