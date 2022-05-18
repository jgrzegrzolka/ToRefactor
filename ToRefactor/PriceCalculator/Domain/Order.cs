namespace Domain
{
    public class Order
    {

        private List<Product> _products = new List<Product>();

        public decimal Price => _products.Sum(p => p.Price);

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal PriceAfterDiscount(int timeOfHavingAccountInYears) => Price.ApplyYearDiscount(timeOfHavingAccountInYears);
    }
}
