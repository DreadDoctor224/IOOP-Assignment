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
    public partial class updateProfile : Form
    {
        public updateProfile()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User obj1 = new User(txtEmailUpdate.Text,txtNameUpdate.Text,int.Parse(txtPhoneNumberUpdate.Text),txtPassWordUpdate.Text);
            MessageBox.Show(User.Update(txtEmailUpdate.Text, txtNameUpdate.Text, int.Parse(txtPhoneNumberUpdate.Text), txtPassWordUpdate.Text));
        }
    }
}
