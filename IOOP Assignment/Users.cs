using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;


namespace IOOP_Assignment
{
  
    public class User
        {
        

        public int UserID { get; set; }
            public string UserName { get; set; }
            public string role { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

        public User(string userName, string password)
        {

            UserName = userName;
            Password = password;

        }

        public User()
        {

        }

        public String login(String un)
        {
            string Status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", UserName);
            cmd.Parameters.AddWithValue("@b", Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0) //if login success
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", UserName);
                cmd2.Parameters.AddWithValue("@b", Password);

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
                    Form10 m = new Form10(un);
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

    }



    }

