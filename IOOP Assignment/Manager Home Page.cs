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
    public partial class Form1 : Form
    {
        public static string name;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
