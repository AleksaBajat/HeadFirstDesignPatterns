using System;
using FactoryPattern.Abstractions;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Buddy ordered a {pizza.Name} \n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Guy ordered a {pizza.Name} \n");
        }
    }
}