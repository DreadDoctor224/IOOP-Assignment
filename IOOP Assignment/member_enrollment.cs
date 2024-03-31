using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{

    public partial class member_enrollment : Form
    {

        private Member newMember;
        private bool unenrolledcheck = false;

        public member_enrollment(Member member)
        {
            InitializeComponent();
            newMember = member;
        }

        private void member_enrollment_Load(object sender, EventArgs e)
        {
            populateComboBox();
        }

      

        private void populateComboBox()
        {
            List<training> list = new List<training>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM trainings", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            training train = new training
                            {
                                trainingID = reader.GetInt32(0),
                                name = reader.GetString(1),
                                description = reader.GetString(2),
                                level = reader.GetString(3),
                                schedule = reader.GetString(4)
                            };

                            list.Add(train);
                        }
                    }
                }
            }

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "trainingID";
        }

        private void txtUnpaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTrainingID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFeedBack_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FeedBack_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMem.Text, out int memberID) && int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                bool isPaid = checkBoxPaid.Checked;
                newMember.trainingEnrollmentAndPayment(memberID, trainingID, isPaid);
                MessageBox.Show("Enrolled!");
                unenrolledcheck = false;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtMem.Text, out int memberID) && int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                bool isPaid = txtUnpaid.Checked;
                newMember.unenrollTraining(memberID, trainingID);
                MessageBox.Show("Unenrolled");
                unenrolledcheck = true;
            }
            
        }


        private void txtsubmitFeedBack_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMem.Text, out int memberID) && int.TryParse(txtTrainingID.Text, out int trainingID))
            {
                newMember.feedBack(memberID, trainingID, txtFeedBack.Text);
                MessageBox.Show("Feedback recorded");
            }
            
        }
    }


}

