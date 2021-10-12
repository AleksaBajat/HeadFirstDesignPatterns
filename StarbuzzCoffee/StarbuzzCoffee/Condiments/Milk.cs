namespace StarbuzzCoffee.Condiments
{
    public class Milk:CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Milk";

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}