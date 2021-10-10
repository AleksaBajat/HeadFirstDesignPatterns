using System;
using SimUDuck.Interfaces;

namespace SimUDuck.FlyBehaviors
{
    public class FlyRocketPowered:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Iron Man would be jealous!");
        }
    }
}