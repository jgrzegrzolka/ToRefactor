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

            Assert.AreEqual(o.Price, 0);
        }

        [Test]
        public void WhenCalculatinPrice_ShouldSumUpAllOrders()
        {
            Product p1 = new Product("Product1", 50);
            Product p2 = new Product("Product2", 150);
            
            Order o = new Order();
            
            o.AddProduct(p1);
            o.AddProduct(p2);

            Assert.AreEqual(o.Price, 200);
        }

        [Test]
        public void WhenCalculatinPriceForNotRegisteredUser_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);
            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.PriceAfterDiscount(0), 50);
        }

        [Test]
        public void WhenCalculatinPriceForAccountYoungerThan5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.PriceAfterDiscount(4), 50);
        }

        [Test]
        public void WhenCalculatinPriceForAccountWithExacly5Yeart_PriceShouldHaveNoDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.PriceAfterDiscount(5), 50);
        }

        [Test]
        public void WhenCalculatinPriceForAccountOlderThan5Yeart_PriceShouldHave10PercentDiscount()
        {
            Product p1 = new Product("Product1", 50);

            Order o = new Order();
            o.AddProduct(p1);

            Assert.AreEqual(o.PriceAfterDiscount(10), 40);
        }
    }
}