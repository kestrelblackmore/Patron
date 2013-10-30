using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public class CurrentConditionsDisplay : IMyObserver, IMyDisplayElement
    {
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(IMySubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(IMySubject weatherData)
        {
            _temperature = weatherData.GetTemperature(); ;
            _humidity = weatherData.GetHumidity();

            Display();
        }
        public string Display()
        {
            return String.Format("Current Conditions: {0} celsius and humidity {1}", _temperature, _humidity); 
        }
        
    }
}
