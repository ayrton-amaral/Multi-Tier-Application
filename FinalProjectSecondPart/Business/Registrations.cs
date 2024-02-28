using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSecondPart.Business
{
    public class Registrations
    {
        public int RegistrationID { get; set; }

        public string CourseNumber { get; set; }

        public int TeacherID { get; set; }

        public Registrations(int registrationID, string courseNumber, int teacherID)
        {
            this.RegistrationID = registrationID;
            this.CourseNumber = courseNumber;
            this.TeacherID = teacherID;
        }
    }
}
