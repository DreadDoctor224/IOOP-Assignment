using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Manager : User
    {
        public int managerID { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }


        public void AddCompetition(int managerID, string competitionName, string date)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO competitions (managerID, competitionName, date) VALUES (@mID, @cn, @d)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@mID", managerID);
            cmdAdd.Parameters.AddWithValue("@cn", competitionName);
            cmdAdd.Parameters.AddWithValue("@d", date);


            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCompetition(int competitionID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM competitions WHERE competitionID = @cID", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdDelete.Parameters.AddWithValue("@cID", competitionID);


            cmdDelete.ExecuteNonQuery();
            con.Close();
        }

        public string EditCompetition(int competitionID, int managerID, string competitionName, string date)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE competitions SET managerID = @mID, competitionName =@cn, date = @d WHERE competitionID = @cID ", con);
            cmdUpdate.Parameters.AddWithValue("@mID", managerID);
            cmdUpdate.Parameters.AddWithValue("@cn", competitionName);
            cmdUpdate.Parameters.AddWithValue("@d", date);
            cmdUpdate.Parameters.AddWithValue("@cID", competitionID);



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


        public void assignMembers(int memberID, int compeitionID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO memberCompetitions (memberID, competitionID) VALUES (@m, @c)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@m", memberID);
            cmdAdd.Parameters.AddWithValue("@e", compeitionID);


            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

    }



}
