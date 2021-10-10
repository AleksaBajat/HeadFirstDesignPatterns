using System;
using SimUDuck.Interfaces;

namespace SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public Duck(){}

        public void PerformFly()
        {
            FlyBehavior.Fly();   
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}