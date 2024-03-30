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
    public partial class Manager_manage_competitions : Form
    {
        public Manager_manage_competitions()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtManID.Text, out int managerID))
            {
                MessageBox.Show("Add a managerID");
                return;
            }

            Manager manager = new Manager();
            try
            {
                manager.AddCompetition(managerID, txtCompName.Text, txtDate.Text);
                MessageBox.Show("Competition added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            txtManID.Clear();
            txtDate.Clear();
            txtCompName.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtManID.Text, out int managerID))
            {
                MessageBox.Show("Add a managerID");
                return;
            }

            if (!int.TryParse(txtCompID.Text, out int competitionID))
            {
                MessageBox.Show("Add a managerID");
                return;
            }
            Manager manager = new Manager();    
            manager.EditCompetition(competitionID,managerID,txtCompName.Text,txtDate.Text);

            MessageBox.Show("Competition Edited");
            txtManID.Clear();
            txtDate.Clear();
            txtCompName.Clear();
            txtCompID.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCompID.Text, out int competitionID))
            {
                MessageBox.Show("Add a managerID");
                return;
            }

            Manager manager = new Manager();    
            manager.DeleteCompetition(competitionID);
            MessageBox.Show("Competition Deleted!");

        }
    }
}
