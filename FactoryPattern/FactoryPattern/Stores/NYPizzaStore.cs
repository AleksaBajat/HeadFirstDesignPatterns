using FactoryPattern.Abstractions;
using FactoryPattern.Pizzas;

namespace FactoryPattern
{
    public class NYPizzaStore:PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else return null;
        }
    }
}