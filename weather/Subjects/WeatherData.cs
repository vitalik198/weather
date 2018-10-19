using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using weather.ObserverInterfaces;

namespace weather.Subjects
{
    class WeatherData : ISubject
    {
        ArrayList observers;
        double temperature;
        double humidity;
        double pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void deleteObserver(IObserver o)
        {
            int index = observers.IndexOf(o);
            if (index >= 0)
            {
                observers.Remove(index);
            }
        }
        public void notifyObservers()
        {
            for (int i = 0; i < observers.ToArray().Length; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementChanged()
        {
            notifyObservers();
        }

        public void setMesurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }

        public void start()
        {
            Thread t = new Thread(new ThreadStart(dataSourse));
            t.Start();
        }
        void dataSourse()
        {
            Random r = new Random();


            while (true)
            {
                setMesurements(r.Next(10, 20), r.Next(30, 100), r.Next(800, 900));
                Thread.Sleep(5000);
            }
        }
    }
}
