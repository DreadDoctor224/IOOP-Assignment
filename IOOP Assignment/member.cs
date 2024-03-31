using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Member : User
    {
        public int memberID { get; set; }
        public string name{ get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }


        public void trainingEnrollmentAndPayment(int memberID, int trainingID, bool isPaid)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO enrollment (memberID, trainingID, enrollmentDate, paymentStatus) VALUES(@mID, @tID, GETDATE(), @ps)", con))
                {
                    cmd.Parameters.AddWithValue("@mID", memberID);
                    cmd.Parameters.AddWithValue("@tID", trainingID);
                    cmd.Parameters.AddWithValue("@ps", isPaid ? "Paid" : "Pending");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("No rows were affected by the insert operation.");
                    }
                }
            }
        }

        public void unenrollTraining(int memberID, int traingingID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM enrollment WHERE memberID =@mID AND trainingID = @tID",con);
            cmd.Parameters.AddWithValue("@mID", memberID);
            cmd.Parameters.AddWithValue("@tID", traingingID);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                throw new Exception("No enrollment found for the member and the specified training.");
            }
            con.Close();
        }

        public void feedBack(int memberID, int trainingID, string feedback)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE enrollment SET feedback = @fd WHERE memberID = @mID AND trainingID = @tID", con);
            cmd.Parameters.AddWithValue("@mID", memberID);
            cmd.Parameters.AddWithValue("@tID", trainingID);
            cmd.Parameters.AddWithValue("@fd", feedback);

            cmd.ExecuteNonQuery();
            con.Close ();
        }


    }

   

     
}
