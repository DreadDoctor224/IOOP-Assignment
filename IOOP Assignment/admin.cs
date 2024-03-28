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

        public string deleteMembers(int UserIDmem)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmddeleteMembers = new SqlCommand("DELETE FROM members WHERE userID = @u", con);

            cmddeleteMembers.Parameters.AddWithValue("u", UserIDmem);

            cmddeleteMembers.ExecuteNonQuery();
            con.Close();

            return "Member Deleted Succesfully";
        }

        public void addCoach(string name, string email, int phoneNumber, int income)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd = new SqlCommand("INSERT INTO coaches (name, email, phonenumber, income) VALUES (@n, @e, @ph, @i)", con);
            //cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@n", name);
            cmdAdd.Parameters.AddWithValue("@e", email);
            cmdAdd.Parameters.AddWithValue("@ph", phoneNumber);
            cmdAdd.Parameters.AddWithValue("@i", income);

            cmdAdd.ExecuteNonQuery();
            con.Close();
        }

        public string editCoaches(string name, string email, int phoneNumber, int income)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit = new SqlCommand("UPDATE coaches SET name = @n, email = @e, phonenumber = @ph, income = @i", con);

            cmdEdit.Parameters.AddWithValue("@n", name);
            cmdEdit.Parameters.AddWithValue("@e", email);
            cmdEdit.Parameters.AddWithValue("@ph", phoneNumber);
            cmdEdit.Parameters.AddWithValue("@i", income);

            cmdEdit.ExecuteNonQuery();
            con.Close();

            return "Coach edited successfully.";
        }

        public string deleteCoaches(int UserIDCoach)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmddeleteMembers = new SqlCommand("DELETE FROM coaches WHERE userID = @u", con);

            cmddeleteMembers.Parameters.AddWithValue("u", UserIDCoach);

            cmddeleteMembers.ExecuteNonQuery();
            con.Close();

            return "Coach Deleted Succesfully";
        }

    }
}
