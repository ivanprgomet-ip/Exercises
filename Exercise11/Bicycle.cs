using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Bicycle:Vehicle
    {
        public bool lightIsOn { get; set; } = false;
        public Bicycle():base("bicycle")
        {

        }
        public override string DescribeVehicle()
        {
            string currentStatus = lightIsOn ? "and the bicycle light is on" : "and the bicycle light is off";//without string.format
            return base.DescribeVehicle()+" "+currentStatus;
        }
        public void LightOn()
        {
            lightIsOn = true;
        }
        public void LightOff()
        {
            lightIsOn = false;
        }
    }

}
