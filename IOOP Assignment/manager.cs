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
