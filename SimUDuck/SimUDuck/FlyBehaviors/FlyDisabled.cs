using System;
using SimUDuck.Interfaces;

namespace SimUDuck.FlyBehaviors
{
    public class FlyDisabled:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm unable to fly!");
        }
    }
}