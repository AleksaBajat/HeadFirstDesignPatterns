using System;
using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck!");
        }

        public MallardDuck()
        {
            QuackBehavior = new RealQuack();
            FlyBehavior = new FlyWithWings();
        }
    }
}