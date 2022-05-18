using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {

        List<Product> Products;

        public decimal Price;

        public void Add(Product product)
        {
            if (Products == null) Products = new List<Product>();

            Products.Add(product);

            Price += product.Price;
        }

        public decimal Calculate(string customerType, int durationOfRegistreationInYears)
        {
            decimal result = 0;
            decimal discount_for_years = (durationOfRegistreationInYears > 5) ? (decimal)20 / 100 : 0;

            if (customerType == "notRegisteredOrder")
            {
                result = this.Price;
            }
            else if (customerType == "registeredOrder")
            {
                result = this.Price - (this.Price * discount_for_years);
            }

            return result;
        }
    }
}
