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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void txtUserNameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(txtUserNameSignUp.Text,txtRoleSignUp.Text,txtPassWordSignUp.Text);
            stat = obj1.signup(txtUserNameSignUp.Text,txtRoleSignUp.Text, txtPassWordSignUp.Text, txtEmailSignUp.Text,txtNameSignUp.Text,int.Parse(txtPhNumberSignUp.Text));
            if (stat != null ) 
            {
                MessageBox.Show(stat);
            }
            txtUserNameSignUp.Text = String.Empty;
            txtRoleSignUp.Text = String.Empty;
            txtPassWordSignUp.Text = String.Empty;
            txtEmailSignUp.Text = String.Empty;
            txtNameSignUp.Text = string.Empty;
            txtPhNumberSignUp.Text= string.Empty;

        }

        private void txtPassWordSignUp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
