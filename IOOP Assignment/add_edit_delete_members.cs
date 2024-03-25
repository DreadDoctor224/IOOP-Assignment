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

        public static string name;
        public add_edit_delete_members()
        {
            InitializeComponent();
        }

        public add_edit_delete_members(string n)
        {
            InitializeComponent();
            name = n;
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

        private void btncls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhMem.Text, out int phoneNumber))
            {
                MessageBox.Show("Add a valid Phone Number.");
                return;
            }
            admin obj1 =  new admin();
            MessageBox.Show(obj1.editMembers(txtNameMem.Text, txtEmailMem.Text, phoneNumber, txtRoleMem.Text));
        }
    }
}
