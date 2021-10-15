using FactoryPattern.Abstractions;
using FactoryPattern.Pizzas;

namespace FactoryPattern
{
    public class ChicagoPizzaStore:PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else return null;
        }
    }
}