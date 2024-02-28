using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSecondPart.Business
{
    public class Users
    {
        public int UserID { get; set; }

        public string Password { get; set; }

        public string JobTitle { get; set; }

        public Users(int userID, string password, string jobTitle)
        {
            this.UserID = userID;
            this.Password = password;
            this.JobTitle = jobTitle;
        }
    }
}
