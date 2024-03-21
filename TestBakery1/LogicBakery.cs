using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBakery1
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
        public decimal GetBasePrice()
        {
            return _bakery.GetPrice();
        }
    }

    public class Chocolate : BakeryDecorator
    {
        public Chocolate(IBakery bakery) : base(bakery)
        {
        }

        public override string GetName()
        {
            if (!_bakery.GetName().Contains("with"))
            {
                return _bakery.GetName() + " with 🍫";
            }

            return _bakery.GetName() + " and 🍫";
        }

        public override decimal GetPrice()
        {
            return Math.Round(_bakery.GetPrice() * 1.1m,1);
        }
    }

    public class Nuts : BakeryDecorator
    {
        public Nuts(IBakery bakery) : base(bakery)
        {
        }

        public override string GetName()
        {
            if (!_bakery.GetName().Contains("with"))
            {
                return _bakery.GetName() + " with 🥜";
            }

            return _bakery.GetName() + " and 🥜";
        }

        public override decimal GetPrice()
        {
            return Math.Round(_bakery.GetPrice() * 1.1m,1);
        }
    }
    internal class LogicBakery
    {
    }
}
