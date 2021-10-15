using System;
using System.Collections.Generic;

namespace FactoryPattern.Abstractions
{
    public abstract class Pizza
    {
        public string Name { get;protected set; }
        public string Dough { get;protected set; }
        public string Sauce { get;protected set; }
        protected List<string> _toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in _toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 250 deg celsius.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Putting pizza in the box");
        }
    }
}