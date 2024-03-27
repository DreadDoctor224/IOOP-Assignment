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
    public partial class Performance_Form : Form
    {
        public Performance_Form()
        {
            InitializeComponent();
        }

        private void Performance_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet2.memberCompetitions' table. You can move, or remove it, as needed.
            this.memberCompetitionsTableAdapter.Fill(this.ioopDBDataSet2.memberCompetitions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
