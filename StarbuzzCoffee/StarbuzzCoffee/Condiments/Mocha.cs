namespace StarbuzzCoffee.Condiments
{
    public class Mocha:CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }

        public override string Description => _beverage.Description + ", Mocha";
    }
}