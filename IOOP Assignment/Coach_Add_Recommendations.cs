using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class Coach_Add_Recomendations : Form
    {
        public Coach_Add_Recomendations()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btAddd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCoachID.Text, out int coachID))
            {
                MessageBox.Show("Add a Coach ID");
                return;
            }

            if (!int.TryParse(txtMembersID.Text, out int memberID))
            {
                MessageBox.Show("Add a valid Member ID");
                return;
            }

            if (!int.TryParse(txCompetitionsID.Text, out int competitionID ))
            {
                MessageBox.Show("Add a valid Competition ID");
                return;
            }
            Coach Coach= new Coach();
            Coach.AddRecommendations(coachID, memberID, competitionID);

            txtCoachID.Clear();
            txtMembersID.Clear();
            txCompetitionsID.Clear();

            MessageBox.Show("Recomendation Added Successfully!.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRecommendations.Text, out int recomendationID))
            {
                MessageBox.Show("Add a Coach ID");
                return;
            }

            if (!int.TryParse(txtCoachID.Text, out int coachID))
            {
                MessageBox.Show("Add a Coach ID");
                return;
            }

            if (!int.TryParse(txtMembersID.Text, out int memberID))
            {
                MessageBox.Show("Add a valid Member ID");
                return;
            }

            if (!int.TryParse(txCompetitionsID.Text, out int competitionID))
            {
                MessageBox.Show("Add a valid Competition ID");
                return;
            }
            Coach Coach = new Coach();
            Coach.EditRecomendations(recomendationID,coachID, memberID, competitionID);

            txtRecommendations.Clear();
            txtCoachID.Clear();
            txtMembersID.Clear();
            txCompetitionsID.Clear();

            MessageBox.Show("Recomendation Edit Successfully!.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRecommendations.Text, out int recomendationID))
            {
                MessageBox.Show("Add a Coach ID");
                return;
            }
            Coach Coach = new Coach();
            Coach.DeleteRecomendations(recomendationID);

            txtRecommendations.Clear();
            txtCoachID.Clear();
            txtMembersID.Clear();
            txCompetitionsID.Clear();

            MessageBox.Show("Recomendation Added Successfully!.");
        }
    }
}
