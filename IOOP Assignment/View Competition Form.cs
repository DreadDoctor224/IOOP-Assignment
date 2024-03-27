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
    public partial class View_Competition_Form : Form
    {
        public View_Competition_Form()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Competition_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet3.competitions' table. You can move, or remove it, as needed.
            this.competitionsTableAdapter.Fill(this.ioopDBDataSet3.competitions);

        }
    }
}
