using System;
using SimUDuck.Interfaces;

namespace SimUDuck.FlyBehaviors
{
    public class FlyWithWings:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}