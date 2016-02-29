using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Bicycle:Vehicle
    {
        public bool lightIsOn { get; set; } = false;
        public Bicycle():base("bicycle")
        {

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
