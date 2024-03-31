using IOOP_Assignment.Resources;
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

        private void btn_manage_mem1_Click(object sender, EventArgs e)
        {
            Add_Training_Schedule form = new Add_Training_Schedule();
            form.Show();
        }

        private void btn_recordperformance_Click(object sender, EventArgs e)
        {
            Record_Performance_Form_Coach form = new Record_Performance_Form_Coach();
            form.Show();
        }

        private void btn_recommendations_Click(object sender, EventArgs e)
        {
            Coach_Add_Recomendations form = new Coach_Add_Recomendations();
            form.Show();
        }

        private void btn_viewpayments_Click(object sender, EventArgs e)
        {
            Coach_view_payments form = new Coach_view_payments();
            form.Show();
        }

        private void btn_updatepf2_Click(object sender, EventArgs e)
        {
            updateProfile form = new updateProfile();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
