using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Coach : User
    {
        public int CoachID { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }
    }

}
