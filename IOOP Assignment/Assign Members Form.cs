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
    public partial class Manager_assign_members : Form
    {
        public Manager_assign_members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberID.Text, out int MemberID))
            {
                MessageBox.Show("Add a valid Member ID");
                return;
            }

            if (!int.TryParse(txtCompetitionID.Text, out int CompetitionID))
            {
                MessageBox.Show("Add a valid Competition ID");
                return;
            }

            Manager admin = new Manager();
            admin.assignMembers(MemberID, CompetitionID);

            txtCompetitionID.Clear();
            txtMemberID.Clear();

            MessageBox.Show("Member Assigned Successfully!.");
        }
    }
}
