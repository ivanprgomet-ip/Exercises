using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Employee
    {
        private string firstname;
        private string lastname;
        private string ssn;
        private string hourlyWage;

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public string SSN
        {
            get
            {
                //datetime is based on the time right now, 
                //so the years will most likely allways be the same...
                DateTime time= DateTime.Now;
                string format = "yy/mm/dd";
                return time.ToString(format) + " - " + this.ssn;
            }
            set { this.ssn = value; }
        }
        public string HourlyWage
        {
            get { return hourlyWage+" SEK"; }
            set { hourlyWage = value; }
        }
        public string FullName//read-only
        {
            get { return Firstname +", "+ Lastname; }
        }

        //constructor:
        public Employee(string firstName, string lastName, string ssn, string wage)
        {
            Firstname= firstName;
            Lastname=lastName;
            SSN = ssn;
            HourlyWage = wage;
        }
        public Employee(string ssn)
        {
            SSN = ssn;
        }
    }
}
