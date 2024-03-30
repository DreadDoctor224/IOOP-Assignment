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




        public void AddTraining(int trainingID, string name, string description, string level, string schedule)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO trainings (trainingID, name, description, level, schedule) VALUES (@TID, @n, @d, @l, @s)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@TID", trainingID);
            cmdAdd.Parameters.AddWithValue("@n", name);
            cmdAdd.Parameters.AddWithValue("@d", description);
            cmdAdd.Parameters.AddWithValue("@l", level);
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

        public string Edit_Training(int TrainingID, string name, string description, string level, string schedule)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE trainings SET name= @n, description = @d, level = @l, schedule = @s WHERE trainingID = @t ", con);
            cmdUpdate.Parameters.AddWithValue("@t",TrainingID);
            cmdUpdate.Parameters.AddWithValue("@n", name);
            cmdUpdate.Parameters.AddWithValue("@d", description);
            cmdUpdate.Parameters.AddWithValue("@l", level);
            cmdUpdate.Parameters.AddWithValue("@s", schedule);



            int i = cmdUpdate.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Edit Succesfully";
            }
            else
                status = "Unable to Edit";
            con.Close();
            return status;
        }


        public void AddRecommendations(int coachID, int memberID, int competitionID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO recommendations(coachID, memberID, competitionID) VALUES (@c, @m, @c)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@c", coachID);
            cmdAdd.Parameters.AddWithValue("@m", memberID);
            cmdAdd.Parameters.AddWithValue("@c", competitionID);
          

            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteRecomendations(int RecomendationsID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM trainings WHERE recomandationsID = @r", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdDelete.Parameters.AddWithValue("@r", RecomendationsID);
            

            cmdDelete.ExecuteNonQuery();
            con.Close();
        }

        public string EditRecomendations(int RecomendationsID, int coachID, int memberID, int competitionID)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE trainings SET coachID = @c, memberID = @m, competitionID = @c WHERE recomendationID = @r ", con);
            cmdUpdate.Parameters.AddWithValue("@c", coachID);
            cmdUpdate.Parameters.AddWithValue("@m", memberID);
            cmdUpdate.Parameters.AddWithValue("@c", competitionID);
            cmdUpdate.Parameters.AddWithValue("@r", RecomendationsID);
            


            int i = cmdUpdate.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Edit Succesfully";
            }
            else
                status = "Unable to Edit";
            con.Close();
            return status;
        }


    }




}
