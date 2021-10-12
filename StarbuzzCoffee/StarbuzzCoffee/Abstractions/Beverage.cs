using System;

namespace StarbuzzCoffee
{
    public abstract class Beverage
    {
        public virtual string Description { get;protected set; } = "Unclassified Beverage";

        public abstract double Cost();
    }
}