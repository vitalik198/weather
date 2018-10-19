using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather.ObserverInterfaces
{
   public interface ISubject
    {
         void registerObserver(IObserver o);
         void deleteObserver(IObserver o);
         void notifyObservers();
    }
}
