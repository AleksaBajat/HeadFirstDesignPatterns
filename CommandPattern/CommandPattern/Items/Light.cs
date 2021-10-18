using System;

namespace CommandPattern
{
    public class Light
    {
        private string _place;
        public Light(string place)
        {
            _place = place;
        }

        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}