using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testform
{
    class Student
    {
        private int iMyStudnum { get; set; }
        private string sMyName { get; set; }
        private string sMyCourse { get; set; }

        public Student(string studentName)
        {
            sMyCourse = "";
            sMyName = studentName;
            Random rand = new Random();
            iMyStudnum = Convert.ToInt32("346" + rand.Next(0, 9999).ToString("D4"));
        }
    }


}
