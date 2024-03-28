namespace IOOP_Assignment
{
    partial class Coach_Add_Recomendations
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
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.txtMembersID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCompetitionsID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAddd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecommendations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCoachID
            // 
            this.txtCoachID.Location = new System.Drawing.Point(512, 331);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(251, 26);
            this.txtCoachID.TabIndex = 1;
            // 
            // txtMembersID
            // 
            this.txtMembersID.Location = new System.Drawing.Point(512, 404);
            this.txtMembersID.Name = "txtMembersID";
            this.txtMembersID.Size = new System.Drawing.Size(251, 26);
            this.txtMembersID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coach ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Competitions ID";
            // 
            // txCompetitionsID
            // 
            this.txCompetitionsID.Location = new System.Drawing.Point(512, 480);
            this.txCompetitionsID.Name = "txCompetitionsID";
            this.txCompetitionsID.Size = new System.Drawing.Size(251, 26);
            this.txCompetitionsID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manage Recomendations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btAddd
            // 
            this.btAddd.Location = new System.Drawing.Point(367, 632);
            this.btAddd.Name = "btAddd";
            this.btAddd.Size = new System.Drawing.Size(96, 40);
            this.btAddd.TabIndex = 9;
            this.btAddd.Text = "ADD";
            this.btAddd.UseVisualStyleBackColor = true;
            this.btAddd.Click += new System.EventHandler(this.btAddd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 715);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recomendations ID";
            // 
            // txtRecommendations
            // 
            this.txtRecommendations.Location = new System.Drawing.Point(512, 267);
            this.txtRecommendations.Name = "txtRecommendations";
            this.txtRecommendations.Size = new System.Drawing.Size(251, 26);
            this.txtRecommendations.TabIndex = 13;
            // 
            // Coach_Add_Recomendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1133, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecommendations);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btAddd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCompetitionsID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMembersID);
            this.Controls.Add(this.txtCoachID);
            this.Name = "Coach_Add_Recomendations";
            this.Text = "Coach_Send_recommandations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCoachID;
        private System.Windows.Forms.TextBox txtMembersID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCompetitionsID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAddd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecommendations;
    }
}