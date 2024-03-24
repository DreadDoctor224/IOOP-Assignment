namespace IOOP_Assignment
{
    partial class Form8
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
            this.data_grid_members = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_members)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_members
            // 
            this.data_grid_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_members.Location = new System.Drawing.Point(18, 105);
            this.data_grid_members.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_grid_members.Name = "data_grid_members";
            this.data_grid_members.RowHeadersWidth = 62;
            this.data_grid_members.Size = new System.Drawing.Size(914, 569);
            this.data_grid_members.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Members";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(994, 263);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(112, 35);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(994, 371);
            this.btn_assign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(112, 35);
            this.btn_assign.TabIndex = 3;
            this.btn_assign.Text = "ASSIGN";
            this.btn_assign.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(994, 483);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_grid_members);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_exit;
    }
}