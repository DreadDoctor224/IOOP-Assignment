﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class Admin_Add_Coach : Form
    {
        public Admin_Add_Coach()
        {
            InitializeComponent();

        }

        private void btn_exit004_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coach_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet6.coaches' table. You can move, or remove it, as needed.
            // this.coachesTableAdapter.Fill(this.ioopDBDataSet6.coaches);

        }

      
        private void data_grid_coach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_del_coach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserID.Text, out int UserIDCoach))
            {
                MessageBox.Show("Add a valid User ID.");
                return;
            }



            admin obj1 = new admin();
            MessageBox.Show(obj1.deleteCoaches(UserIDCoach));
        }

        private void btn_edit_coach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCoachID.Text, out int coachID))
            {
                MessageBox.Show("Add a valid User ID.");
                return;
            }

            if (!int.TryParse(txtIncome.Text, out int income))
            {
                MessageBox.Show("Add a valid Income.");
                return;
            }

            if (!int.TryParse(txtSalaryCoach.Text, out int salary))
            {
                MessageBox.Show("Add a valid Salary.");
                return;
            }


            admin obj1 = new admin();
            MessageBox.Show(obj1.editCoaches(coachID, income, txtLvlCoach.Text, salary));

            txtCoachID.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtIncome.Clear();
            txtLvlCoach.Clear();
            txtSalaryCoach.Clear();
        }

        private void btn_add_coach_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtUserID.Text, out int userID))
            {
                MessageBox.Show("Add a valid User ID.");
                return;
            }


            if (!int.TryParse(txtPhoneNumber.Text, out int phoneNumber))
            {
                MessageBox.Show("Add a valid Phone Number.");
                return;
            }

            if (!int.TryParse(txtIncome.Text, out int income))
            {
                MessageBox.Show("Add a valid Income.");
                return;
            }

            if (!int.TryParse(txtSalaryCoach.Text, out int salary))
            {
                MessageBox.Show("Add a valid Salary.");
                return;
            }






            admin admin = new admin();
            admin.addCoach(userID, txtName.Text, txtEmail.Text, phoneNumber, income, txtLvlCoach.Text, salary);



            MessageBox.Show("Coach Added Successfully!");

            txtUserID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtIncome.Clear();
            txtLvlCoach.Clear();
            txtSalaryCoach.Clear();

            // Assuming you have a method to refresh the coaches list or data grid
            //RefreshCoachesList();

        }
    }
}
