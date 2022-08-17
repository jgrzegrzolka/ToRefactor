using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator.Domain
{
    public class Order
    {

        private List<Product> _products = new List<Product>();

        public decimal Price => _products.Sum(p => p.Price);

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetPriceAfterDiscount(int timeOfHavingAccountInYears) => Price.ApplyYearDiscount(timeOfHavingAccountInYears);
    }
}
