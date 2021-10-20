using System;

namespace CommandPattern
{
    public class CeilingFan
    {
        public const int Off = 0;
        public const int Low = 1;
        public const int Medium = 2;
        public const int High = 3;

        private string _location;
        private int _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = Off;
        }

        public void SetOff()
        {
            _speed = Off;
        }
        
        public void SetLow()
        {
            _speed = Low;
        }

        public void SetMedium()
        {
            _speed = Medium;
        }

        public void SetHigh()
        {
            _speed = High;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}