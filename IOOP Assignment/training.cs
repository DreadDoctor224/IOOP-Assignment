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








    }
}
