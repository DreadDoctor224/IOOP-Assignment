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
       
      public void addMembers(string name, string email, string phoneNumber)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmdAdd =new SqlCommand("INSERT INTO Members (Name, Email, PhoneNumber) VALUES (@name, @email, @phonenumber)", con);
        }

    }
}
