using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32A
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            User u1 = new User();
            SuperUser su1 = new SuperUser();

            Console.WriteLine($"employe is a employee: {e1 is Employee}");
            Console.WriteLine($"user is a user: {u1 is User}");
            Console.WriteLine($"superuser is a superuser: {su1 is SuperUser}");

            Console.WriteLine($"employee is a superuser: {e1 is SuperUser}");//warning because there's no inheritance involved, so an employee can never be a superuser
            Console.WriteLine($"employee is a user: {e1 is User}");//see warning above

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"user is a superuser: {u1 is SuperUser}");//True
            Console.WriteLine($"superuser is a user: {su1 is User}");//False
            Console.ResetColor();

            SuperUser su2 = new User();//works because a user IS a superuser

            User u3 = (User)su2;

            //superuser is both a superuser and a user
            Console.WriteLine(su2 is SuperUser);
            Console.WriteLine(su2 is User);
            Console.WriteLine(u3 is User);//u3 (which is a superuser casted to user) is a user

            object myUser3 = new User();
            Employee myemp = (Employee)myUser3;
        }
    }
}
