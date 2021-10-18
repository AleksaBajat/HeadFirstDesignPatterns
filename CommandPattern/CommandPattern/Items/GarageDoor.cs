using System;

namespace CommandPattern
{
    public class GarageDoor
    {
        private Light _garageLight;

        public GarageDoor(string place)
        {
            _garageLight = new Light(place);
        }
        
        public void Up()
        {
            Console.WriteLine("Garage door is lifting up..");
            Console.WriteLine("Garage door is up!");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is closing..");
            Console.WriteLine("Garage door is closed!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping...");
        }

        public void LightOn()
        {
            _garageLight.On();
        }

        public void LightOff()
        {
            _garageLight.Off();
        }
    }
}