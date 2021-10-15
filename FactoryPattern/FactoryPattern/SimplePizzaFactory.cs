using FactoryPattern.Abstractions;

namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                //
            }else if (type.Equals("pepperoni"))
            {
                //
            }else if (type.Equals("clam"))
            {
                //
            }else if (type.Equals("veggie"))
            {
                //
            }

            return pizza;
        }
    }
}

//Not used in this case but it is a way to encapsulate the 
//creation of pizzas