using System;
using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks
{
    public class ModelDuck:Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }

        public ModelDuck()
        {
            FlyBehavior = new FlyDisabled();
            QuackBehavior = new RealQuack();
        }
    }
}