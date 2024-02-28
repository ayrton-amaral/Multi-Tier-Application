using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSecondPart.Business
{
    public class Teachers
    {
        public int TeacherID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Teachers(int teacherID, string firstName, string lastName, string email)
        {
            this.TeacherID = teacherID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }


    }
}
