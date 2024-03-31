using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public class admin : User
    {


        public void addMembers(int userID, string name, string email, int phoneNumber, string role)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

                using (SqlCommand cmdAdd = new SqlCommand("INSERT INTO members (userID, name, email,  phonenumber, role) VALUES (@uID,@Name, @Email, @PhoneNumber, @Role)", con))
                { 
                    cmdAdd.Parameters.AddWithValue("@uID", userID);
                    cmdAdd.Parameters.AddWithValue("@Name", name);
                    cmdAdd.Parameters.AddWithValue("@Email", email);
                    cmdAdd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmdAdd.Parameters.AddWithValue("@Role", role);

                    cmdAdd.ExecuteNonQuery();
                    con.Close();

                }
            
           


        }

        public string editMembers(int userID, string name, string email, int phoneNumber, string role)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit = new SqlCommand("UPDATE members SET name = @n, email = @e, phonenumber = @ph, role = @r WHERE userID = @ID", con);

            cmdEdit.Parameters.AddWithValue("@ID", userID);
            cmdEdit.Parameters.AddWithValue("@n", name);
            cmdEdit.Parameters.AddWithValue("@e", email);
            cmdEdit.Parameters.AddWithValue("@ph", phoneNumber);
            cmdEdit.Parameters.AddWithValue("@r", role);

            cmdEdit.ExecuteNonQuery();
            con.Close();

            return "Member edited succesfully!";
        }


        public string deleteMembers(int UserIDmem)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmddeleteMembers = new SqlCommand("DELETE FROM members WHERE memberID = @mID", con);

            cmddeleteMembers.Parameters.AddWithValue("@mID", UserIDmem);

            cmddeleteMembers.ExecuteNonQuery();
            con.Close();

            return "Member Deleted Succesfully";
        }

        public void addCoach(int userID, string name, string email, int phoneNumber, int income, string level, int salary)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

                SqlCommand cmdAdd = new SqlCommand("INSERT INTO coaches (userID, name, email, phonenumber, income, level, salary) VALUES (@ID, @n, @e, @ph, @i, @l, @s)", con);
                cmdAdd.Parameters.AddWithValue("@ID", userID);
                cmdAdd.Parameters.AddWithValue("@n", name);
                cmdAdd.Parameters.AddWithValue("@e", email);
                cmdAdd.Parameters.AddWithValue("@ph", phoneNumber);
                cmdAdd.Parameters.AddWithValue("@i", income);
                cmdAdd.Parameters.AddWithValue("@l", level);
                cmdAdd.Parameters.AddWithValue("@s", salary);

                cmdAdd.ExecuteNonQuery();
                con.Close();
            MessageBox.Show("Coach successfully added");
        }

        public string editCoaches(int coachID, int income, string level, int salary)
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

        public void addManager(int userID, string name, string email, int phoneNumber)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdAdd = new SqlCommand("INSERT INTO managers (userID, name, email, phonenumber) VALUES (@ID, @n, @e, @ph)", con);
            cmdAdd.Parameters.AddWithValue("@ID", userID);
            cmdAdd.Parameters.AddWithValue("@n", name);
            cmdAdd.Parameters.AddWithValue("@e", email);
            cmdAdd.Parameters.AddWithValue("@ph", phoneNumber);

            cmdAdd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Manager successfully added");
        }

        public string editManager(int managerID, string name, string email, int phoneNumber)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdEdit = new SqlCommand("UPDATE managers SET name=@n, email=@e, phoneNumber=@ph WHERE managerID =@mID", con);

            cmdEdit.Parameters.AddWithValue("@mID", managerID);
            cmdEdit.Parameters.AddWithValue("@n", name);
            cmdEdit.Parameters.AddWithValue("@e", email);
            cmdEdit.Parameters.AddWithValue("@ph", phoneNumber);

            cmdEdit.ExecuteNonQuery();
            con.Close();

            return "Manager edited successfully.";
        }

        public string deleteManager(int managerID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmddeleteMembers = new SqlCommand("DELETE FROM managers WHERE managerID = @mID", con);

            cmddeleteMembers.Parameters.AddWithValue("mID", managerID);

            cmddeleteMembers.ExecuteNonQuery();
            con.Close();

            return "Manager Deleted Succesfully";
        }


    }
}
