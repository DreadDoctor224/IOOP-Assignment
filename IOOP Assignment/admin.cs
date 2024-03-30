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
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit =new SqlCommand("UPDATE members SET name = @n, email = @e, phonenumber = @ph, role = @r", con);

            cmdEdit.Parameters.AddWithValue("@n", name);
            cmdEdit.Parameters.AddWithValue("@e", email);
            cmdEdit.Parameters.AddWithValue("@ph", phoneNumber);
            cmdEdit.Parameters.AddWithValue("@r", role);

            int i = cmdEdit.ExecuteNonQuery();
            if (i != 0)
            {
                status = "updated succesfully";
            }
            else
                status = "Unabale to update";
            con.Close();

            return status;
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

        public void addCoach(int userID, string name, string email, int phoneNumber, int income, string level, int salary)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheckUser = new SqlCommand("SELECT COUNT(*) FROM users WHERE userID =@ID", con);
            cmdCheckUser.Parameters.AddWithValue("@ID", userID);
            int userCount = (int)cmdCheckUser.ExecuteScalar();
            if (userCount > 0)
            {

                SqlCommand cmdAdd = new SqlCommand("INSERT INTO coaches (userID, name, email, phonenumber, income, level, salary) VALUES (@ID, @n, @e, @ph, @i, @l, @s)", con);
                cmdAdd.Parameters.AddWithValue("@ID", userID);
                cmdAdd.Parameters.AddWithValue("@n", name);
                cmdAdd.Parameters.AddWithValue("@e", email);
                cmdAdd.Parameters.AddWithValue("@ph", phoneNumber);
                cmdAdd.Parameters.AddWithValue("@i", income);
                cmdAdd.Parameters.AddWithValue("@l", level);
                cmdAdd.Parameters.AddWithValue("@s", salary);

                cmdAdd.ExecuteNonQuery();
            }

            else
            {
                throw new Exception("The userID does not exist in the users table.");
            }

            con.Close();
        }

        public string editCoaches(int coachID,int income, string level, int salary)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit = new SqlCommand("UPDATE coaches SET income = @i, level =@l, salary=@s WHERE coachID =@c", con);

            cmdEdit.Parameters.AddWithValue("@c", coachID);
            cmdEdit.Parameters.AddWithValue("@i", income);
            cmdEdit.Parameters.AddWithValue("@l", level);
            cmdEdit.Parameters.AddWithValue("@s", salary);

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
