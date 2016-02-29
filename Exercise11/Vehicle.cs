using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    abstract class Vehicle
    {
        public string Type { get; private set; }
        public Vehicle(string _type)
        {
            this.Type = _type;
        }
        public virtual string DescribeVehicle()
        {
            return string.Format($"This vehicle is a {Type}");
        }
    }
}
