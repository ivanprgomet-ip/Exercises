using System;

namespace Exercise09
{
    class Program
    {
        private static bool active = true;
        private static Registry reg = new Registry();

        //smart! now you can access the logger log method 
        //statically in every other class, making it less cluttery:
        public static Logger log = new Logger();

        static void Main(string[] args)
        {

            #region demo employees added to list
            //demo employees
            Employee e1 = new Employee("firstname1", "lastname1", "920320-4585", "250");
            Employee e2 = new Employee("firstname2", "lastname2", "920412-4263", "450");
            Employee e3 = new Employee("firstname3", "lastname3", "950805-2485", "550");
            reg.AddEmployee(e1);
            reg.AddEmployee(e2);
            reg.AddEmployee(e3);
            #endregion

            while (active)
            {
                Menu();
                string choice = Console.ReadLine();

                if (choice == "1")
                    AddEmployee();
                else if (choice == "2")
                    RemoveEmployee();
                else if (choice == "3")
                    PrintRegistry();
                else if (choice == "4")
                    FilteredSearch();
                else if (choice == "5")
                    active = false;
                else
                    Console.WriteLine("invalid input");
            }
        }

        //these are private because I dont want other classes to reach these methods
        //thru Program. , making the code more capsulated:
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. Print entire registry");
            Console.WriteLine("4. Show filtered search");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter Choice: ");
        }
        private static void AddEmployee()
        {
            Console.Clear();
            Console.Write("Enter employee firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter employee lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter SSN (YYMMDD-XXXX): ");
            string ssn = Console.ReadLine();
            Console.Write("Enter hourly wage: ");
            string wage = Console.ReadLine();
            reg.AddEmployee(new Employee(firstname, lastname, ssn, wage));
            Console.ReadKey();
        }
        private static void RemoveEmployee()
        {
            Console.Clear();
            Console.Write("Enter ssn ");
            reg.RemoveEmployee(Console.ReadLine());
            Console.ReadKey();
        }
        private static void FilteredSearch()
        {
            Console.Clear();
            Console.Write("Enter year with two digits: ");
            reg.FilterSearch(Console.ReadLine());
            Console.ReadKey();
        }
        private static void PrintRegistry()
        {
            Console.Clear();
            reg.PrintRegistry();
            Console.ReadKey();
        }
    }
}
