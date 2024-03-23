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
    
    public partial class Form10 : Form
    {
        public static string name;
        public Form10()
        {
            InitializeComponent();
        }

        public Form10(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
