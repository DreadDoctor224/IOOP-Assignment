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
    public partial class Home_Page_Admin : Form
    {
        public static string name;
        public Home_Page_Admin()
        {
            InitializeComponent();
        }
        public Home_Page_Admin(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_Page_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateProfile form = new updateProfile();
            form.Show();
        }

        private void btnOpenManageMem_Click(object sender, EventArgs e)
        {
            add_edit_delete_members form = new add_edit_delete_members();
            form.Show();
        }

        private void btn_view_suggestions_Click(object sender, EventArgs e)
        {
            Suggestion_Form form = new Suggestion_Form();
            form.Show();
        }

        private void btn_view_competitions_Click(object sender, EventArgs e)
        {
            Competitions form = new Competitions();
            form.Show();
        }

        private void btn_view_income_Click(object sender, EventArgs e)
        {
            Admin_income_view form = new Admin_income_view();
            form.Show();
        }

        private void btn_manage_coaches_Click(object sender, EventArgs e)
        {
            Admin_Add_Coach form = new Admin_Add_Coach();
            form.Show();
        }
    }
}
