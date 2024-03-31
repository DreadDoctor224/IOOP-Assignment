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


        public bool managerCheck(int managerID)
        {
            bool check = false;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM managers WHERE managerID = @managerID", con);
            cmdCheck.Parameters.AddWithValue("@managerID", managerID);
            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                check = true;
            }
            con.Close();
            return check;
        }

        
        public void AddCompetition(int managerID, string competitionName, string date)
        {
            if (!managerCheck(managerID))
            {
                throw new Exception("Manager does not exist.");
            }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO competitions (managerID, competitionName, date) VALUES (@mID, @cn, @d)", con);
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

         public bool memExist(int memberID)
        {
            bool mem = false;

            SqlConnection con =new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM members WHERE memberID = @mID", con);
            check.Parameters.AddWithValue("@mID", memberID);

            

            int c = Convert.ToInt32(check.ExecuteScalar());

            if (c == 0)
            {
                mem =true;
            }

            con.Close();
            return mem;
        }

        public bool compExist(int compitionID) 
        {
            bool comp = false;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM competitions WHERE competitionID = @cID", con);
            check.Parameters.AddWithValue("@cID", compitionID);
            
            int c = Convert.ToInt32(check.ExecuteScalar());
            if (c == 0)
            {
                comp = true;
            }
            con.Close();
            return comp;
        }

        public void assignMembers(int compeitionID, string competitionName, string result)
        {



            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO memberCompetitions (competitionID, competitionName, result) VALUES (@cID, @cn, @r)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@cID", compeitionID);
            cmdAdd.Parameters.AddWithValue("@cn", competitionName);
            cmdAdd.Parameters.AddWithValue("@r", result);


            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

    }



}
