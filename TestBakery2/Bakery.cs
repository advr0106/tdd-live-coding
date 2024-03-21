namespace TestBakery2
{
    public interface IBakery
    {
        public string GetName();
        public decimal GetPrice();
    }

    public class Cake : IBakery
    {
        public string GetName()
        {
            return "🧁";
        }

        public decimal GetPrice()
        {
            return 1.0m;
        }
    }

    public class Cookie : IBakery
    {
        public string GetName()
        {
            return "🍪";
        }

        public decimal GetPrice()
        {
            return 2.0m;
        }
    }

    public abstract class BakeryDecorator : IBakery
    {
        protected IBakery _bakery;

        public BakeryDecorator(IBakery bakery)
        {
            _bakery = bakery;
        }

        public abstract string GetName();

        public abstract decimal GetPrice();
    }

    public class Chocolate : BakeryDecorator
    {
        public Chocolate(IBakery bakery) : base(bakery)
        {
        }

        public override string GetName()
        {
            if (_bakery.GetName().Contains("with"))
            {
                return _bakery.GetName() + " and 🍫";
            }
            return _bakery.GetName() + " with 🍫";
        }

        public override decimal GetPrice()
        {
            return Math.Round(_bakery.GetPrice() * 1.1m, 1);
        }
    }
    public class Peanut : BakeryDecorator
    {
        public Peanut(IBakery bakery) : base(bakery)
        {
        }

        public override string GetName()
        {
            if (_bakery.GetName().Contains("with"))
            {
                return _bakery.GetName() + " and 🥜";
            }
            return _bakery.GetName() + " with 🥜";
        }

        public override decimal GetPrice()
        {
            return Math.Round(_bakery.GetPrice() * 1.1m, 1);
        }
    }
}