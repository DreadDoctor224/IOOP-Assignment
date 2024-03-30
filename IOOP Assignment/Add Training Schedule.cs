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
    public partial class Add_Training_Schedule : Form
    {
        public Add_Training_Schedule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Training_Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                MessageBox.Show("Add a valid Training ID");
                return;
            }

            


            Coach training = new Coach();
            training.Edit_Training(trainingID, txtName.Text, txtDescription.Text, txtLevel.Text, txtSchedule.Text);

           

            MessageBox.Show("Edit Successful");
           
            txtTrainingID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtSchedule.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingSchedule_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                MessageBox.Show("Add a valid training ID");
                return;
            }

           

            Coach coach = new Coach();
            coach.AddTraining(trainingID, txtName.Text, txtDescription.Text, txtLevel.Text, txtSchedule.Text);

           

            MessageBox.Show("Traning Scheule Added Successfully!.");

            txtTrainingID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtSchedule.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                MessageBox.Show("Add a valid Training ID");
                return;
            }

            Coach coach = new Coach();
            coach.DeleteTraining(trainingID);

            txtTrainingID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtSchedule.Clear();

            MessageBox.Show("Traning Scheule Deleted.");
        }

        private void txtTrainingID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}