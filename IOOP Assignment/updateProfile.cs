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
            if (!int.TryParse(txtPhoneNumberUpdate.Text, out int phoneNumber))
            {
                MessageBox.Show("Add a valid Phone Number.");
                return;
            }

            if (!int.TryParse(txtUserIDUpdate.Text, out int userID))
            {
                MessageBox.Show("Add a valid Phone Number.");
                return;
            }
            User obj1 = new User(txtEmailUpdate.Text,txtNameUpdate.Text,phoneNumber,txtPassWordUpdate.Text);
            MessageBox.Show(User.Update(userID,txtEmailUpdate.Text, txtNameUpdate.Text, phoneNumber, txtPassWordUpdate.Text));
        }

        private void updateProfile_Load(object sender, EventArgs e)
        {

        }

        private void txtNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
