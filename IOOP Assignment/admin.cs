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

        public string editMembers(string name, string email, int phoneNumber, string role)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit =new SqlCommand("UPDATE members SET name = @n, email = @e, phonenumber = @ph, role = @r", con);

            cmdEdit.Parameters.AddWithValue("@n", name);
            cmdEdit.Parameters.AddWithValue("@e", email);
            cmdEdit.Parameters.AddWithValue("@ph", phoneNumber);
            cmdEdit.Parameters.AddWithValue("@r", role);

            cmdEdit.ExecuteNonQuery();
            con.Close();

            return "Member edited successfully.";
        }

        public void deleteMembers(string name, string email, int phoneNumber, string role)
        {

        }

    }
}
