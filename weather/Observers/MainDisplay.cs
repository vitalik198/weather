using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weather.ObserverInterfaces;

namespace weather.Observers
{
    class MainDisplay:IObserver,IDisplay
    {
        double temperature;
        double humidity;
        double pressure;
        ISubject weatherData;

        public MainDisplay(ISubject subject)
        {
            this.weatherData = subject;
            weatherData.registerObserver(this);
        }

        public void update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
        public void display()
        {
            Console.WriteLine("\nПогода\nТемпература: {0}\nВлажность: {1}\nДавление: {2}\n",temperature,humidity,pressure);
        }
    }
}
