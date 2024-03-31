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

        private void btn_view_suggestion_Click(object sender, EventArgs e)
        {
            Send_Suggestions form = new Send_Suggestions();
            form.Show();
        }

        private void btn_manage_mem1_Click(object sender, EventArgs e)
        {
            member_display_training_schedule form = new member_display_training_schedule();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Competitions form = new Competitions();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            updateProfile form = new updateProfile();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member_Performance_Form form = new Member_Performance_Form();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Member member = new Member();
          
            member_enrollment enroll = new member_enrollment(member);
            enroll.Show();
        }
    }
}
