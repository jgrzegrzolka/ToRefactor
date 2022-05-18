using Domain;
using NUnit.Framework;

namespace PriceCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenCreateEmptyOrder_PriceShouldBeZero()
        {
            Order o = new Order();

            Assert.AreEqual(o.Calculate("notRegisteredOrder", 0), 0);
        }

        [Test]
        public void WhenCalculatingPrice_ShouldSumUpAllOrrders()
        {
            Product p1 = new Product("Product1", 50);
            Product p2 = new Product("Product1", 150);
            
            Order o = new Order();
            
            o.Add(p1);
            o.Add(p2);

            Assert.AreEqual(o.Calculate("notRegisteredOrder", 0), 200);
        }

        [Test]
        public void WhenCalculatingPriceForNotRegisteredUser_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);
            Order o = new Order();
            o.Add(p1);

            Assert.AreEqual(o.Calculate("notRegisteredOrder", 0), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountYoungerThan5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.Add(p1);

            Assert.AreEqual(o.Calculate("registeredOrder", 4), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountWithExacly5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.Add(p1);

            Assert.AreEqual(o.Calculate("registeredOrder", 5), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountOlderThan5Yeart_PriceShouldHave10PercentDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.Add(p1);

            Assert.AreEqual(o.Calculate("registeredOrder", 6), 40);
        }
    }
}