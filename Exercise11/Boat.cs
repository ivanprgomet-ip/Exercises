using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Boat:Vehicle
    {
        public bool sailsUp { get; set; } = false;
        public Boat():base("boat")
        {

        }
        public override string DescribeVehicle()
        {
            string currentStatus= string.Format(sailsUp ? "and the sails are up" : "and the sails are down");//with string.format
            return base.DescribeVehicle()+" "+currentStatus;
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
