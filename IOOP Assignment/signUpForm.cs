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

        private void signUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string stat;

            if (!int.TryParse(txtPhNumberSignUp.Text, out int phoneNumber))
            {
                MessageBox.Show("Enter a valid phone number");

                return;
            }
            User obj1 = new User(txtUserNameSignUp.Text, txtRoleSignUp.Text, txtPassWordSignUp.Text, txtEmailSignUp.Text, txtNameSignUp.Text, phoneNumber);
            stat = obj1.signup(txtUserNameSignUp.Text, txtRoleSignUp.Text, txtPassWordSignUp.Text, txtEmailSignUp.Text, txtNameSignUp.Text, phoneNumber);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUserNameSignUp.Text = String.Empty;
            txtRoleSignUp.Text = String.Empty;
            txtPassWordSignUp.Text = String.Empty;
            txtEmailSignUp.Text = String.Empty;
            txtNameSignUp.Text = string.Empty;
            txtPhNumberSignUp.Text = string.Empty;

        }
    }
}
