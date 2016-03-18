using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28
{
    class SubClass:BaseClass
    {
        void DoSomething()
        {
            name = "ivan";//public is accessible for all classes
            wage = 5;//protected accessible in inheriting classes
            //private only accessible in own class
        }
    }
}
