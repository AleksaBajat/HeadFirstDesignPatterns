using System;
using StarbuzzCoffee.Beverages;
using StarbuzzCoffee.Condiments;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev1 = new Espresso();
            Console.WriteLine(bev1.Description);

            Beverage bev2 = new Decaf();
            Console.WriteLine(bev2.Description);

            Beverage bev3 = new Mocha(bev2);
            Console.WriteLine(bev3.Description);

            Beverage bev4 = new Milk(bev3);
            Console.WriteLine(bev4.Description);

            Beverage bev5 = new Soy(bev4);
            Console.WriteLine(bev5.Description + " " + bev5.Cost());
        }
    }
}