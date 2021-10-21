using System;

namespace BackToDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            
            Console.WriteLine("Turkey: ");
            
            turkey.Gobble();
            turkey.Fly();
            
            Console.Write("Duck: ");
            
            duck.Quack();
            duck.Fly();
            
            Console.WriteLine("Turkey adapter: ");
            
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}