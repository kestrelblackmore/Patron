using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Patron.ObserverPattern;

namespace Patron.Tests
{
    [TestFixture]
    public class ObserverPatternTests
    {
        [Test]
        public void weather_data_updates_observers_correctly() 
        {
            var wd = new WeatherData();
            var conditions = new CurrentConditionsDisplay(wd);
            var heat = new HeatIndexDisplay(wd);
            var stats = new StatisticsDisplay(wd);
            var forecast = new ForecastDisplay(wd);

            wd.SetMeasurements(80, 65, 30.4f);
            Assert.AreEqual("Current Conditions: 80 celsius and humidity 65", conditions.Display());
            Assert.AreEqual("Heat index is 82.95535", heat.Display());
            Assert.AreEqual("Avg/Max/Min Temperature: 80/80/80", stats.Display());
            Assert.AreEqual("Improving weather on the way!", forecast.Display());

            wd.SetMeasurements(78, 90, 29.2f);
            Assert.AreEqual("Current Conditions: 78 celsius and humidity 90", conditions.Display());
            Assert.AreEqual("Heat index is 83.64967", heat.Display());
            Assert.AreEqual("Avg/Max/Min Temperature: 79/80/78", stats.Display());
            Assert.AreEqual("Weather is getting bad!", forecast.Display());
        }

        [Test]
        public void weather_data_updates_heatindex_correctly()
        {
            var wd = new WeatherData();
            var heatdisplay = new HeatIndexDisplay(wd);

            wd.SetMeasurements(80, 65, 30.4f);
            Assert.AreEqual("Heat index is 82.95535", heatdisplay.Display());

            wd.SetMeasurements(78, 90, 29.2f);
            Assert.AreEqual("Heat index is 83.64967", heatdisplay.Display());
        }

        [Test]
        public void weather_data_updates_statistics_correctly()
        {
            var wd = new WeatherData();
            var display = new StatisticsDisplay(wd);

            wd.SetMeasurements(20, 15, 73);
            Assert.AreEqual("Avg/Max/Min Temperature: 20/20/20", display.Display());

            wd.SetMeasurements(40, 15, 73);
            Assert.AreEqual("Avg/Max/Min Temperature: 30/40/20", display.Display());

            wd.SetMeasurements(0, 15, 73);
            Assert.AreEqual("Avg/Max/Min Temperature: 20/40/0", display.Display());
        }

        [Test]
        public void weather_data_updates_forecast_correctly()
        {
            var wd = new WeatherData();
            var display = new ForecastDisplay(wd);

            wd.SetMeasurements(20, 15, 73);
            Assert.AreEqual("Improving weather on the way!", display.Display());

            wd.SetMeasurements(40, 15, 40);
            Assert.AreEqual("Weather is getting bad!", display.Display());

            wd.SetMeasurements(0, 15, 40);
            Assert.AreEqual("More of the same", display.Display());
        }


    }
}
