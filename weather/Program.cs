using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weather.Observers;
using weather.Subjects;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            MainDisplay display = new MainDisplay(data);
            data.start();
        }
    }
}
