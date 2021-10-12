namespace StarbuzzCoffee.Condiments
{
    public class Soy:CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }

        public override string Description => _beverage.Description + ", Soy";
    }
}