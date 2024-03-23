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
    public partial class Home_Page_Coach : Form
    {
        public static string name;
        public Home_Page_Coach()
        {
            InitializeComponent();
        }

        public Home_Page_Coach(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Home_Page_Coach_Load(object sender, EventArgs e)
        {

        }
    }
}
