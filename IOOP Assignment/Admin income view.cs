using System;
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
    public partial class Admin_income_view : Form
    {
        public Admin_income_view()
        {
            InitializeComponent();
        }

        private void Admin_income_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet5.coaches' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlDataAdapter view_income = new SqlDataAdapter("SELECT coachID, name, income FROM coaches", con);
            DataTable dt = new DataTable();
            view_income.Fill(dt);

            DataGridViewadmincome.DataSource = view_income;

            con.Close();
        }

        private void Btn_exit96_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewadmincome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
