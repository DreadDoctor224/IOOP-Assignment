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
    public partial class Competitions : Form
    {
        public Competitions()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Competitions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet4.competitions' table. You can move, or remove it, as needed.
            this.competitionsTableAdapter.Fill(this.ioopDBDataSet4.competitions);

        }

        private void Btn_ext06_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
