using System;
using SimUDuck.Interfaces;

namespace SimUDuck.QuackBehaviors
{
    public class RealQuack:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}