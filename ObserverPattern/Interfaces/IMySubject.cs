using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public interface IMySubject
    {
        void RegisterObserver(IMyObserver observer);
        void RemoveObserver(IMyObserver observer);
        void NotifyObservers();

        float GetTemperature();
        float GetHumidity();
        float GetPressure();
    }
}
