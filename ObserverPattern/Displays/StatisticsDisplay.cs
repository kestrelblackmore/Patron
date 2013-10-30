using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public class StatisticsDisplay : IMyObserver, IMyDisplayElement
    {
        private float _maxtemperature;
        private float _mintemperature;
        private float _sumtemperature;
        private int _numberofreadings = 0;

        public StatisticsDisplay(IMySubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(IMySubject weatherData)
        {
            var temperature = weatherData.GetTemperature();

            _numberofreadings++;
            _sumtemperature += temperature;

            if (_numberofreadings == 1)
            {
                // first reading so default both to the same temperature
                _maxtemperature = temperature;
                _mintemperature = temperature;
            }
            else
            {
                // do checks
                if (temperature > _maxtemperature)
                {
                    _maxtemperature = temperature;
                }

                if (temperature < _mintemperature)
                {
                    _mintemperature = temperature;
                }
            }

            Display();
        }
        public string Display()
        {
            return String.Format("Avg/Max/Min Temperature: {0}/{1}/{2}", _sumtemperature / _numberofreadings, _maxtemperature, _mintemperature); 
        }
        
    }
}
