using System;
using SimUDuck.Interfaces;

namespace  SimUDuck.QuackBehaviors
{
    public class MuteQuack:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("* Silence *");
        }
    }
}