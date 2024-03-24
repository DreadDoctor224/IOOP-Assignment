using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class admin : User
    {

       
      public void addMembers(string name, string email, int phoneNumber, string role)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd =new SqlCommand("INSERT INTO members (name, email, phonenumber, role) VALUES (@n, @e, @ph, @r)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@n", name);
            cmdAdd.Parameters.AddWithValue("@e", email);
            cmdAdd.Parameters.AddWithValue("@ph", phoneNumber);
            cmdAdd.Parameters.AddWithValue("@r", role);

            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

    }
}
