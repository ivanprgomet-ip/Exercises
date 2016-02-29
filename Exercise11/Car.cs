using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Car:Vehicle
    {
        public bool engineIsRunnin {get; set;} = false;
        //inherited class constructor
        public Car(): base("car")
        {

        }
        public override string DescribeVehicle()
        {
            //todo: what does the base keyword do here?
            return base.DescribeVehicle()+" "+string.Format(engineIsRunnin?"and the engine is running":"and the engine isn't running");
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
