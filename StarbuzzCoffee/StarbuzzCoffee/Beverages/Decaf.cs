namespace StarbuzzCoffee.Beverages
{
    public sealed class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}