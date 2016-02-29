using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Car:Vehicle
    {
        public bool engineIsRunnin {get; set;} = false;
        //inherited class constructor
        public Car(): base("car")
        {

        }
        public void StartEngine()
        {
            engineIsRunnin = true;
        }
        public void StopEngine()
        {
            engineIsRunnin = false;
        }

    }
}
