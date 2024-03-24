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
    
    public partial class Member_Home_Page : Form
    {
        public static string name;
        public Member_Home_Page()
        {
            InitializeComponent();
        }

        public Member_Home_Page(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
