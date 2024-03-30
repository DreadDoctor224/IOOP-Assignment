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
            
            Coach Coach= new Coach();
            Coach.AddRecommendations(txtCoachName.Text, txtMembersName.Text, txtCompetitionName.Text);

            

            MessageBox.Show("Recomendation Added Successfully!.");
           
            txtCoachName.Clear();
            txtMembersName.Clear();
            txtCompetitionName.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRecommendations.Text, out int recomendationID))
            {
                MessageBox.Show("Add a recommendation ID");
                return;
            }

           
            Coach Coach = new Coach();
            Coach.EditRecomendations(recomendationID,txtCoachName.Text, txtMembersName.Text, txtCompetitionName.Text);

            

            MessageBox.Show("Recomendation Edit Successfully!.");

            txtRecommendations.Clear();
            txtCoachName.Clear();
            txtMembersName.Clear();
            txtCompetitionName.Clear();

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

            

            MessageBox.Show("Recomendation Added Successfully!.");
            txtRecommendations.Clear();
            txtCoachName.Clear();
            txtMembersName.Clear();
            txtCompetitionName.Clear();
        }

        private void Coach_Add_Recomendations_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRecommendations_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
