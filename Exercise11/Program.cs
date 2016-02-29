using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mustang = new Car();
            Bicycle crescent = new Bicycle();
            Boat yacht = new Boat();

            VehicleData data = new VehicleData();

            /*Notice that PrintVehicle has no idea 
            what kind of object you send in beyond Vehicle. 
            The only information it has, is that it’s 
            a Vehicle, but that’s all. Still, it works 
            with Car (and any other sub class) and its 
            specialized behavior. This is polymorphism.*/
            data.PrintVehicle(mustang);
            data.PrintVehicle(crescent);
            data.PrintVehicle(yacht);

        }
    }
}
