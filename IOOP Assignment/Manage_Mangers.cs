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
    public partial class Manage_Mangers : Form
    {
        public Manage_Mangers()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtmuID.Text, out int userID))
            {
                MessageBox.Show("Please enter a valid ID");
            }

            if(!int.TryParse(txtmph.Text, out int phoneNumber)) 
            {
                MessageBox.Show("Please enter a valid Phone Number");
            }

            admin manager = new admin();
            manager.addManager(userID, txtmName.Text, txtmEmail.Text, phoneNumber);
            MessageBox.Show("Manager Added succesfully");

            txtmuID.Clear();
            txtmph.Clear();
            txtmName.Clear();
            txtmEmail.Clear();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtmID.Text, out int managerID))
            {
                MessageBox.Show("Please enter a valid ID");
            }

            if (!int.TryParse(txtmph.Text, out int phoneNumber))
            {
                MessageBox.Show("Please enter a valid Phone Number");
            }

            admin manager = new admin();    
            manager.editManager(managerID,txtmName.Text, txtmEmail.Text, phoneNumber);
            MessageBox.Show("Manager Editied succesfully");

            txtmuID.Clear();
            txtmph.Clear();
            txtmName.Clear();
            txtmEmail.Clear();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmID.Text, out int managerID))
            {
                MessageBox.Show("Please enter a valid ID");
            }

            admin manager= new admin();
            manager.deleteManager(managerID);
            MessageBox.Show("Manager Deleted Succesfully");

            txtmuID.Clear();
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
