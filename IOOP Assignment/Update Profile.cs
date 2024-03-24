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
    public partial class Update_Profile : Form
    {
        public Update_Profile()
        {
            InitializeComponent();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_updatepfadmin_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(Txtbox_email2.Text, Txtbox_name2.Text, int.Parse(Txtbox_ph2.Text), Txtbox_pw2.Text );
            stat = obj1.Update(Txtbox_email2.Text, Txtbox_name2.Text, int.Parse(Txtbox_ph2.Text), Txtbox_pw2.Text);

        }
    }
}
