using System.Collections.Generic;
using WeatherORama.Interfaces;

namespace WeatherORama
{
    public class WeatherData:ISubject
    {
        private List<IObserver> _observers;

        public double Temperature { get; private set; } = 0;
        public double Humidity { get; private set; } = 0;
        public double Pressure { get; private set; } = 0;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temp, double hum, double pres)
        {
            Temperature = temp;
            Humidity = hum;
            Pressure = pres;
            MeasurementsChanged();
        }
    }
}