using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public class WeatherData : IMySubject
    {
        private List<IMyObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IMyObserver>();
        }

        public void RegisterObserver(IMyObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IMyObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }


    }
}
