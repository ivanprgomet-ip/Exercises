using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class Weather
    {
        public enum Type
        {
            Sunny,
            Cloudy,
            Rainy,
            Stormy,
            Windy,
            Misty,
            Snowy,
            Icy,
        }
        public Type Forecast(DateTime date)
        {
            //random logic to calculate forecast
            Type myForecast = Type.Sunny;

            if (date.Month <= 12 && date.Month >= 10)
                myForecast = Type.Snowy;
            if (date.Month < 10 && date.Month >= 8)
                myForecast = Type.Rainy;
            if (date.Month < 8 && date.Month >= 6)
                myForecast = Type.Sunny;
            if (date.Month < 6 && date.Month >= 3)
                myForecast = Type.Misty;
            if (date.Month < 3 && date.Month >= 1)
                myForecast = Type.Stormy;
            return myForecast;
        }
    }
}
