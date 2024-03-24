using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using System.Web;


namespace IOOP_Assignment
{
  
    public class User
        {
        

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string name { get; set; }
        public int phonenumber { get; set; }

        public User(string userName, string password)
        {

            UserName = userName;
            Password = password;

        }


        public User()
        {

        }

        public User(string userName, string role, string password)
        {
            UserName = userName;
            this.role = role;
            Password = password;
        }

        public User(string email, string name, int phonenumber, string password)
        {
            Email = email;
            this.name = name;
            this.phonenumber = phonenumber;
            this.Password = password;
        }

        public String login(String un)
        {
            string Status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a and password =@p", con);
            cmd.Parameters.AddWithValue("@a", UserName);
            cmd.Parameters.AddWithValue("@p", Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0) //if login success
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username =@a and password =@p", con);
                cmd2.Parameters.AddWithValue("@a", UserName);
                cmd2.Parameters.AddWithValue("@p", Password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    //redirect to adminHome Form
                    Home_Page_Admin a = new Home_Page_Admin(un);
                    a.ShowDialog();
                }
                else if (userRole == "member")
                {
                    //member homepage
                    Member_Home_Page m = new Member_Home_Page(un);
                    m.ShowDialog();
                }
                else if (userRole == "manager")
                {  
                    //manager homepage
                    Form1 ma = new Form1(un);
                    ma.ShowDialog();
                }
                else if (userRole == "coach")
                {
                    Home_Page_Coach c = new Home_Page_Coach(un);
                    c.ShowDialog();
                }
            }
            else
                Status = "Incorrect username/password";
            con.Close();

            return Status;
            //status = null if login success
            //status = "Incorrect username/password" if login fail.
        }

        public string signup(string UserName,string role, string Password, string email, string name, int phonenumber)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT (*) from users where username=@username", con);
            cmdCheck.Parameters.AddWithValue("@username", UserName);

            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
            if (count > 0)
            {
                status = "Username always exists";
            }
            else
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO users (username, password, role, email, name, phonenumber) VALUES (@a, @p, @r, @em, @n, @ph)", con); 
                cmdInsert.Parameters.AddWithValue("@a", UserName);
                cmdInsert.Parameters.AddWithValue("@r", role);
                cmdInsert.Parameters.AddWithValue("@p", Password);
                cmdInsert.Parameters.AddWithValue("@em", email);
                cmdInsert.Parameters.AddWithValue("@n", name);
                cmdInsert.Parameters.AddWithValue("@ph", phonenumber);


                int rowaffected = cmdInsert.ExecuteNonQuery();
                if (rowaffected > 0) 
                {
                    status = "Sign up successful";
                }
                else 
                {
                    status = "Sign up failed";
                }

            }
            con.Close();
            return status;


        }

        public static string Update(string email, string name, int phonenumber, string password) 
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE users SET email = @e, phoneNumber = @ph WHERE name = @n AND password = @p", con);
            cmdUpdate.Parameters.AddWithValue("@e", email);
            cmdUpdate.Parameters.AddWithValue("@ph", phonenumber);
            cmdUpdate.Parameters.AddWithValue("@n", name);
            cmdUpdate.Parameters.AddWithValue("@p", password);

            int i = cmdUpdate.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Succesfully";
            }
            else
                status = "Unable to update";
            con.Close();
            return status;

        }

    }



    }

