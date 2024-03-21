using TestBakery3;

namespace TestBakery.Test
{
    public class Tests
    {
        [Test]
        public void InputCakeReturnCake()
        {
            var cake =  new Cake();
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
        public void InputChocolateCakeReturnCakeWithChocolate()
        {
            var cake = new Chocolate(new Cake());
            Assert.AreEqual("🧁 with 🍫", cake.GetName());
        }
        [Test]
        public void InputChocolateCookieReturnCookieWithChocolate()
        {
            var cookie = new Chocolate(new Cookie());
            Assert.AreEqual("🍪 with 🍫", cookie.GetName());
        }

        [Test]
        public void InputPriceChocolateCakeReturn11()
        {
            var cake = new Chocolate(new Cake());
            Assert.AreEqual(1.1m, cake.GetPrice());
        }
        [Test]
        public void InputPriceChocolateCookieReturn22()
        {
            var cookie = new Chocolate(new Cookie());
            Assert.AreEqual(2.2m, cookie.GetPrice());
        }
        [Test]
        public void InputChocolateCakeReturnCakeWithChocolateAndPeanut()
        {
            var cake = new Peanut(new Chocolate(new Cake()));
            Assert.AreEqual("🧁 with 🍫 and 🥜", cake.GetName());
        }
        [Test]
        public void InputChocolateCookieReturnCookieWithChocolateAndPeanut()
        {
            var cookie = new Peanut(new Chocolate(new Cookie()));
            Assert.AreEqual("🍪 with 🍫 and 🥜", cookie.GetName());
        }
        [Test]
        public void InputPriceChocolateCakeReturn12()
        {
            var cake = new Peanut(new Chocolate(new Cake()));
            Assert.AreEqual(1.2m, cake.GetPrice());
        }
        [Test]
        public void InputPriceChocolateCookieReturn24()
        {
            var cookie = new Peanut(new Chocolate(new Cookie()));
            Assert.AreEqual(2.4m, cookie.GetPrice());
        }
        [Test]
        public void InputChocolateCookieReturnCookieWithPeanutAndChocolate()
        {
            var cookie = new Chocolate(new Peanut(new Cookie()));
            Assert.AreEqual("🍪 with 🥜 and 🍫", cookie.GetName());
        }
    }
}