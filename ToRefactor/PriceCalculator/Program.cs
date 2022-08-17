using PriceCalculator.Domain;

class Program
{
    static public void Main(String[] args)
    {

        Product p1 = new Product("Product1", 50);
        Product p2 = new Product("Product2", 50);

        Order o = new Order();
        o.AddProduct(p1);
        o.AddProduct(p2);

        Console.WriteLine("Price for not registered: " + o.GetPriceAfterDiscount(0));
        Console.WriteLine("Price with 1 year registration: " + o.GetPriceAfterDiscount(1));
        Console.WriteLine("Price with 5 year registration: " + o.GetPriceAfterDiscount(5));
        Console.WriteLine("Price with 10 year registration: " + o.GetPriceAfterDiscount(10));
    }
}
