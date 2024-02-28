using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSecondPart
{
    public class Courses
    {
        public string CourseNumber { get; set; }

        public string CourseTitle { get; set; }

        public int Duration { get; set; }

        public Courses(string courseNumber, string courseTitle, int duration)
        {
            this.CourseNumber = courseNumber;
            this.CourseTitle = courseTitle;
            this.Duration = duration;
        }
    }
}
