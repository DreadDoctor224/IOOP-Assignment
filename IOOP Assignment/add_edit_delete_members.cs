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
    public partial class add_edit_delete_members : Form
    {
        public add_edit_delete_members()
        {
            InitializeComponent();
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhMem.Text,out int phoneNumber))
            {
                MessageBox.Show("Add a valid Phone Number");
                return;
            }
            admin admin = new admin();
            admin.addMembers(txtNameMem.Text, txtEmailMem.Text, phoneNumber, txtRoleMem.Text);

            txtNameMem.Clear();
            txtEmailMem.Clear();
            txtPhMem.Clear();
            txtRoleMem.Clear();

            MessageBox.Show("Member Added Successfully!.");
        }
    }
}
