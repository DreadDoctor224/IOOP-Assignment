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
    public partial class Coach_Form : Form
    {
        public Coach_Form()
        {
            InitializeComponent();
        }

        private void btn_exit004_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coach_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet6.coaches' table. You can move, or remove it, as needed.
            this.coachesTableAdapter.Fill(this.ioopDBDataSet6.coaches);

        }

        private void data_grid_coach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
