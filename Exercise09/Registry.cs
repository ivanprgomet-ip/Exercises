using System;
using System.Collections.Generic;

namespace Exercise09
{
    class Registry
    {
        List<Employee> lstEmployee = new List<Employee>();

        public void FilterSearch(string year)
        {
            for(int i=0;i<lstEmployee.Count;i++)
            {
                if (lstEmployee[i].SSN.StartsWith(year))
                    Console.WriteLine(lstEmployee[i].FullName+"| "+ lstEmployee[i].SSN);
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("logg updated");
            Program.log.Log($"filtersearched for employees born in {year}\'");// <-- logging interesting stuff
            Console.ResetColor();
        }
        public void AddEmployee(Employee newEmployee)
        {
            lstEmployee.Add(newEmployee);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("logg updated");
            Program.log.Log("New employee added to the registry");// <-- logging interesting stuff
            Console.ResetColor();
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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("logg updated");
            Program.log.Log(employeeFound ? "employee found and removed from registry" : "employee not found");// <-- logging interesting stuff
            Console.ResetColor();
        }
        public void PrintRegistry()
        {
            foreach(Employee emp in lstEmployee)
            {
                Console.WriteLine(emp.FullName + "| "+emp.SSN);
            }
        }
    }
}
