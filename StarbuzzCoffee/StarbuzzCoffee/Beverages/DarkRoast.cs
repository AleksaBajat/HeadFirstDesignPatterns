namespace StarbuzzCoffee.Beverages
{
    public sealed class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}