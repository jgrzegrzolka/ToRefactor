using PriceCalculator.Domain;
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

            Assert.AreEqual(o.GetPriceAfterDiscount(0), 0);
        }

        [Test]
        public void WhenCalculatingPrice_ShouldSumUpAllOrrders()
        {
            Product p1 = new Product("Product1", 50);
            Product p2 = new Product("Product1", 150);
            
            Order o = new Order();
            
            o.AddProduct(p1);
            o.AddProduct(p2);

            Assert.AreEqual(o.GetPriceAfterDiscount(0), 200);
        }

        [Test]
        public void WhenCalculatingPriceForNotRegisteredUser_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);
            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.GetPriceAfterDiscount(0), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountYoungerThan5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.GetPriceAfterDiscount(4), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountWithExacly5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.GetPriceAfterDiscount(5), 50);
        }

        [Test]
        public void WhenCalculatingPriceForAccountOlderThan5Yeart_PriceShouldHave10PercentDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.GetPriceAfterDiscount(6), 40);
        }
    }
}