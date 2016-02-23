using System;
using System.Collections.Generic;

namespace Exercise09
{
    class Registry
    {
        List<Employee> lstEmployee = new List<Employee>();

        //todo: fix this
        //public List<string> FilterSearch(string year)
        //{
        //    List<string> matchingEmployees = new List<string>();
        //    //add code which loops throug all employees and
        //    //checks which year numbers their ssn starts with 
        //    //and add the matching employees to the list.


        //    return matchingEmployees;
        //}
        public void AddEmployee(Employee newEmployee)
        {
            lstEmployee.Add(newEmployee);
            Program.log.Log("New employee added to the registry");// <-- logging interesting stuff
        }
        public void RemoveEmployee(string ssn)
        {
            bool employeeFound = false;
            for(int i =0;i<lstEmployee.Count;i++)
            {
                if(lstEmployee[i].SSN==ssn)
                {
                    //removes the employee object at the 
                    //index of where the ssn matches with input ssn.
                    //dont forget that ssn is based of a datetime
                    //and it wont find if you only search on ssn
                    //  (mm/dd/yyyy-ssn)
                    lstEmployee.Remove(lstEmployee[i]);
                    employeeFound = true;
                    break;
                }
            }
            Program.log.Log(employeeFound ? "employee found and removed from registry" : "employee not found");// <-- logging interesting stuff
            Console.ReadKey();
        }
        public void PrintRegistry()
        {
            foreach(Employee emp in lstEmployee)
            {
                Console.WriteLine(emp.FullName);
            }
        }
    }
}
