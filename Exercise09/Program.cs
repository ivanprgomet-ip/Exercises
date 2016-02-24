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

            Employee e1 = new Employee("ivan", "prgomet", "1", "00");
            Employee e2 = new Employee("john", "cena", "2", "00");
            Employee e3 = new Employee("bob", "bobson", "3", "00");
            Employee e4 = new Employee("bill", "billson", "4", "00");
            reg.AddEmployee(e1);
            reg.AddEmployee(e2);
            reg.AddEmployee(e3);
            reg.AddEmployee(e4);



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

        private static void FilteredSearch()
        {
            Console.WriteLine("Enter year with two digits: ");
            reg.FilterSearch(Console.ReadLine());
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
            Console.WriteLine("Enter Choice: ");
        }
        private static void AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("Enter employee firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter employee lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter ssn: ");
            string ssn = Console.ReadLine();
            Console.WriteLine("Enter hourly wage: ");
            string wage = Console.ReadLine();
            reg.AddEmployee(new Employee(firstname, lastname, ssn, wage));
            Console.ReadKey();
        }
        private static void RemoveEmployee()
        {
            Console.Clear();
            Console.WriteLine("Enter ssn");
            reg.RemoveEmployee(Console.ReadLine());
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
