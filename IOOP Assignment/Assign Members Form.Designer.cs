namespace IOOP_Assignment
{
    partial class Manager_assign_members
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
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtCompetitionID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assign Members";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(305, 346);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(75, 23);
            this.btn_assign.TabIndex = 3;
            this.btn_assign.Text = "ASSIGN";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(466, 346);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Competition ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(385, 172);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(137, 20);
            this.txtMemberID.TabIndex = 7;
            // 
            // txtCompetitionID
            // 
            this.txtCompetitionID.Location = new System.Drawing.Point(385, 219);
            this.txtCompetitionID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompetitionID.Name = "txtCompetitionID";
            this.txtCompetitionID.Size = new System.Drawing.Size(137, 20);
            this.txtCompetitionID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "competition Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(385, 267);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(137, 20);
            this.txtCN.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(385, 308);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(137, 20);
            this.txtResult.TabIndex = 12;
            // 
            // Manager_assign_members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompetitionID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.label1);
            this.Name = "Manager_assign_members";
            this.Text = "Assign members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtCompetitionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtResult;
    }
}