using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Coach : User
    {
        

        public int CoachID { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }

        


        public void AddTraining(int coachID, string name, string description, string level, decimal price, string schedule)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO trainings (coachID, name, description, level, price, schedule) VALUES (@c, @n, @d, @l,@p,@s)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@c", coachID);
            cmdAdd.Parameters.AddWithValue("@n", name);
            cmdAdd.Parameters.AddWithValue("@d", description);
            cmdAdd.Parameters.AddWithValue("@l", level);
            cmdAdd.Parameters.AddWithValue("@p", price);
            cmdAdd.Parameters.AddWithValue("s", schedule);


            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteTraining(int trainingID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM trainings WHERE trainingID = @t", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdDelete.Parameters.AddWithValue("@t", trainingID);

            cmdDelete.ExecuteNonQuery();
            con.Close();
        }
    }




}
