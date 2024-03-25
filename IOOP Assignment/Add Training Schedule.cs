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

            if (!int.TryParse(txtCoachID.Text, out int coachID))
            {
                MessageBox.Show("Add a valid Coach ID");
                return;
            }


            Training training = new Training();
            training.Edit_Schedule(trainingID, coachID, txtName.Text, txtDescription.Text, txtLevel.Text, txtSchedule.Text);

            txtTrainingID.Clear();
            txtCoachID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtPrice.Clear();
            txtSchedule.Clear();

            MessageBox.Show("Edit Successful");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainingSchedule_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCoachID.Text, out int coachID))
            {
                MessageBox.Show("Add a valid Coach ID");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Add a valid price");
                return;
            }

            Coach coach = new Coach();
            coach.AddTraining(coachID, txtName.Text, txtDescription.Text, txtLevel.Text, price, txtSchedule.Text);

            txtCoachID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtPrice.Clear();
            txtSchedule.Clear();

            MessageBox.Show("Traning Scheule Added Successfully!.");
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
            txtCoachID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLevel.Clear();
            txtPrice.Clear();
            txtSchedule.Clear();

            MessageBox.Show("Traning Scheule Deleted.");
        }
    }
}