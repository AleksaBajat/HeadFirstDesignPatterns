using System;
using WeatherORama.Interfaces;

namespace WeatherORama
{
    public class CurrentConditionsDisplay:IDisplayElement,IObserver
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private WeatherData _data;

        public CurrentConditionsDisplay(WeatherData wd)
        {
            _data = wd;
            wd.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine($"Temperature : {_temperature} " +
                              $"Humidity: {_humidity} " +
                              $"Pressure: {_pressure} ");
        }

        public void Update()
        {
            _temperature = _data.Temperature;
            _humidity = _data.Humidity;
            _pressure = _data.Pressure;
            Display();
        }
    }
}