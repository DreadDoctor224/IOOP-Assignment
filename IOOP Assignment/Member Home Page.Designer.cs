namespace IOOP_Assignment
{
    partial class Member_Home_Page
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
            this.btn_send_suggestions = new System.Windows.Forms.Button();
            this.btn_view_competitions = new System.Windows.Forms.Button();
            this.btn_view_performance = new System.Windows.Forms.Button();
            this.btn_view_training_schedule = new System.Windows.Forms.Button();
            this.btn_enroll_training = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update_profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_send_suggestions
            // 
            this.btn_send_suggestions.Location = new System.Drawing.Point(681, 354);
            this.btn_send_suggestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send_suggestions.Name = "btn_send_suggestions";
            this.btn_send_suggestions.Size = new System.Drawing.Size(195, 35);
            this.btn_send_suggestions.TabIndex = 11;
            this.btn_send_suggestions.Text = "Send Suggestions";
            this.btn_send_suggestions.UseVisualStyleBackColor = true;
            // 
            // btn_view_competitions
            // 
            this.btn_view_competitions.Location = new System.Drawing.Point(681, 237);
            this.btn_view_competitions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_view_competitions.Name = "btn_view_competitions";
            this.btn_view_competitions.Size = new System.Drawing.Size(195, 35);
            this.btn_view_competitions.TabIndex = 10;
            this.btn_view_competitions.Text = "View Competitions";
            this.btn_view_competitions.UseVisualStyleBackColor = true;
            // 
            // btn_view_performance
            // 
            this.btn_view_performance.Location = new System.Drawing.Point(333, 474);
            this.btn_view_performance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_view_performance.Name = "btn_view_performance";
            this.btn_view_performance.Size = new System.Drawing.Size(195, 35);
            this.btn_view_performance.TabIndex = 9;
            this.btn_view_performance.Text = "View Performance";
            this.btn_view_performance.UseVisualStyleBackColor = true;
            // 
            // btn_view_training_schedule
            // 
            this.btn_view_training_schedule.Location = new System.Drawing.Point(333, 354);
            this.btn_view_training_schedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_view_training_schedule.Name = "btn_view_training_schedule";
            this.btn_view_training_schedule.Size = new System.Drawing.Size(195, 35);
            this.btn_view_training_schedule.TabIndex = 8;
            this.btn_view_training_schedule.Text = "View Training Schedule";
            this.btn_view_training_schedule.UseVisualStyleBackColor = true;
            // 
            // btn_enroll_training
            // 
            this.btn_enroll_training.Location = new System.Drawing.Point(333, 237);
            this.btn_enroll_training.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_enroll_training.Name = "btn_enroll_training";
            this.btn_enroll_training.Size = new System.Drawing.Size(195, 35);
            this.btn_enroll_training.TabIndex = 7;
            this.btn_enroll_training.Text = "Enroll in Training";
            this.btn_enroll_training.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Home Page";
            // 
            // btn_update_profile
            // 
            this.btn_update_profile.Location = new System.Drawing.Point(681, 474);
            this.btn_update_profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_profile.Name = "btn_update_profile";
            this.btn_update_profile.Size = new System.Drawing.Size(195, 35);
            this.btn_update_profile.TabIndex = 12;
            this.btn_update_profile.Text = "Update Profile";
            this.btn_update_profile.UseVisualStyleBackColor = true;
            // 
            // Member_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_update_profile);
            this.Controls.Add(this.btn_send_suggestions);
            this.Controls.Add(this.btn_view_competitions);
            this.Controls.Add(this.btn_view_performance);
            this.Controls.Add(this.btn_view_training_schedule);
            this.Controls.Add(this.btn_enroll_training);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Member_Home_Page";
            this.Text = "Member_Home_Page";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send_suggestions;
        private System.Windows.Forms.Button btn_view_competitions;
        private System.Windows.Forms.Button btn_view_performance;
        private System.Windows.Forms.Button btn_view_training_schedule;
        private System.Windows.Forms.Button btn_enroll_training;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update_profile;
    }
}