using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testform
{
    class Employee
    {
        private string eName { get; set; }
        private string ePosition { get; set; }
        private int eAge { get; set; }
        private DateTime eStartDate { get; set; }


        public Employee(string name, DateTime startDate)
        {
            eName = name;
            ePosition = "";
            eAge = 0;
            eStartDate = startDate;
        }

        public Employee(string name)
        {
            eName = name;
            ePosition = "";
            eAge = 0;
        }

        public Employee(string name, string position, int age)
        {
            eName = name;
            ePosition = position;
            eAge = age;
            eStartDate = DateTime.Now;
        }
    }
}
