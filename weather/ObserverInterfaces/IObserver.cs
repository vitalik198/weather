using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather.ObserverInterfaces
{
    public interface IObserver
    {
        void update(double temp, double humidity, double pressure);
    }
}
