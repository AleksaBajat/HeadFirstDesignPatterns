using System.Runtime.CompilerServices;
using FactoryPattern.Abstractions;

namespace FactoryPattern.Pizzas
{
    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            _toppings.Add("Grated Reggiano Cheese");
        }
    }
}