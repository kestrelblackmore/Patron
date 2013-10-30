using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.ObserverPattern
{
    public class ForecastDisplay : IMyObserver, IMyDisplayElement
    {
        private float _lastpressure;
        private float _currentpressure = 30;

        public ForecastDisplay(IMySubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(IMySubject weatherData)
        {
            _lastpressure = _currentpressure;
            _currentpressure = weatherData.GetPressure();

            Display();
        }
        public string Display()
        {
            var result = "More of the same";

            if (_currentpressure > _lastpressure)
            {
                result = "Improving weather on the way!";
            }
            else if (_currentpressure < _lastpressure)
            {
                result = "Weather is getting bad!";
            }

            return result;
        }
        
    }
}
