using System;
using SimUDuck.Ducks;
using SimUDuck.FlyBehaviors;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}