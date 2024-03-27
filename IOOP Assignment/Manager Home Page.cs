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
    public partial class Manager_home_page : Form
    {
        public static string name;
        public Manager_home_page()
        {
            InitializeComponent();
        }

        public Manager_home_page(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            updateProfile form = new updateProfile();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Manager_manage_competitions form = new Manager_manage_competitions();
            form.Show();
        }

        private void btn_view_suggestion_Click(object sender, EventArgs e)
        {
            manager_view_recommendations form = new manager_view_recommendations();
            form.Show();
        }

        private void btn_manage_mem1_Click(object sender, EventArgs e)
        {
            Manager_assign_members form = new Manager_assign_members();
            form.Show();
        }

        private void btn_recordperformance_Click(object sender, EventArgs e)
        {
            Manager_view_results form = new Manager_view_results();
            form.Show();
        }
    }
}
