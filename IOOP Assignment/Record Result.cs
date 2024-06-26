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
    public partial class Manager_view_results : Form
    {
        public Manager_view_results()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showResults()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM memberCompetitions", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showResults();
        }

        private void Manager_view_results_Load(object sender, EventArgs e)
        {

        }
    }
}
