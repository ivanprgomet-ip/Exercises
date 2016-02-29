using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            -> logger VARIABLE is from the logger CLASS which is inheriting from the ILogger INTERFACE
            -> application VARIABLE is from the LogApplication CLASS and the constructor takes an ILogger interface member as a parameter
            -> logger goes into the LogApplication constructor sucessfully because logger is inheriting from the ILogger interface
            */
            //var logger = new Logger();
            //var application = new LogApplication(logger);

            //while (true)
            //{
            //    application.Run();
            //}

            var timeLogger = new DateTimeLogger();
            var application = new LogApplication(timeLogger);

            while (true)
            {
                application.Run();
            }


        }
    }
}
