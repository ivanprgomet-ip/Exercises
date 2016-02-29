using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Boat:Vehicle
    {
        public bool sailsUp { get; set; } = false;
        public Boat():base("boat")
        {

        }
        public void RaiseSails()
        {
            sailsUp = true;
        }
        public void LowerSails()
        {
            sailsUp = false;
        }

    }
}
