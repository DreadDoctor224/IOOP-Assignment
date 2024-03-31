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
    public partial class manager_view_recommendations : Form
    {
        public manager_view_recommendations()
        {
            InitializeComponent();
        }

        private void showRecommendations()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM recommendations", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            showRecommendations();
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ioopDBDataSet.Recommendations' table. You can move, or remove it, as needed.
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
