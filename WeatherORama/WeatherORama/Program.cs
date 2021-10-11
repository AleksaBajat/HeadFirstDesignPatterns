using System;

namespace WeatherORama
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            CurrentConditionsDisplay display = new CurrentConditionsDisplay(wd);
            
            wd.SetMeasurements(35,65,34.3);
            wd.SetMeasurements(25,55,31.3);
            wd.SetMeasurements(15,75,38.3);
        }
    }
}