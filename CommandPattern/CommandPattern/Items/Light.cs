using System;

namespace CommandPattern
{
    public class Light
    {
        public bool State { get; private set; } = false;

        public Light()
        {
        }

        public void On()
        {
            State = true;
        }

        public void Off()
        {
            State = false;
        }

        public void CheckState()
        {
            if(State)
                Console.WriteLine("The light is on!");
            else
                Console.WriteLine("The light is off!");
        }
    }
}