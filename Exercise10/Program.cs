using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData data = new VehicleData();

            Car mustang = new Car();
            Bicycle crescent = new Bicycle();
            Boat yacht = new Boat();

            //you can send anything that inherits 
            //from Vehicle to PrintVehicle:
            data.PrintVehicle(mustang);
            data.PrintVehicle(crescent);
            data.PrintVehicle(yacht);
        }
    }
}
