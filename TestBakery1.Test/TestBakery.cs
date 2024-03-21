namespace TestBakery1.Test
{
    public class Tests
    {

        [Test]
        public void InputCakeReturnCake()
        {
            var cake = new Cake();
            Assert.AreEqual("🧁", cake.GetName());
        }

        [Test]
        public void InputCookieReturnCookie()
        {
            var cookie = new Cookie();
            Assert.AreEqual("🍪", cookie.GetName());
        }

        [Test]
        public void InputPriceCakeReturn1()
        {
            var cake = new Cake();
            Assert.AreEqual(1.0m, cake.GetPrice());
        }

        [Test]
        public void InputPriceCookieReturn2()
        {
            var cookie = new Cookie();
            Assert.AreEqual(2.0m, cookie.GetPrice());
        }

        [Test]
        public void InputChocolateCakeReturnCakewithChocolate()
        {
            var cake = new Chocolate(new Cake());
            Assert.AreEqual("🧁 with 🍫", cake.GetName());
        }

        [Test]
        public void InputChocolateCookieReturnCookiewithChocolate()
        {
            var cookie = new Chocolate(new Cookie());
            Assert.AreEqual("🍪 with 🍫", cookie.GetName());
        }

        [Test]
        public void InputNutsChocolateCakeReturnCakewithChocolateandNuts()
        {
            var cake = new Nuts(new Chocolate(new Cake()));
            Assert.AreEqual("🧁 with 🍫 and 🥜", cake.GetName());
        }

        [Test]
        public void InputNutsChocolateCookieReturnCookiewithChocolateandNuts()
        {
            var cookie = new Nuts(new Chocolate(new Cookie()));
            Assert.AreEqual("🍪 with 🍫 and 🥜", cookie.GetName());
        }

        [Test]
        public void InputPriceNutsChocolateCakeReturn12()
        {
            var cake = new Nuts(new Chocolate(new Cake()));
            Assert.AreEqual(1.2m, cake.GetPrice());
        }

        [Test]
        public void InputNutsChocolateCookieReturn22()
        {
            var cookie = new Nuts(new Chocolate(new Cookie()));
            Assert.AreEqual(2.4m, cookie.GetPrice());
        }
    }
}