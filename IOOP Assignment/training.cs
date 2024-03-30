using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IOOP_Assignment
{
    public class Training
    {

        public int TrainingID { get; set; }
        public int CoachID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }

        public string Schedule { get; set; }




        public string Edit_Schedule(int TrainingID, int coachID, string name, string description, string level, string schedule)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE trainings SET coachID = @c, name = @n, description = @d, level = @l, schedule = @s WHERE trainingID = @t ", con);
            cmdUpdate.Parameters.AddWithValue("@c", coachID);
            cmdUpdate.Parameters.AddWithValue("@n", name);
            cmdUpdate.Parameters.AddWithValue("@d", description);
            cmdUpdate.Parameters.AddWithValue("@l", level);



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




    }
}
