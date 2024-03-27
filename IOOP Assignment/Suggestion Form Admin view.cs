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
    public partial class Suggestion_Form : Form
    {
        public Suggestion_Form()
        {
            InitializeComponent();
        }

        private void DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_exi8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
