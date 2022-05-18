using Domain;

class Program
{
    static public void Main(String[] args)
    {

        Product p1 = new Product("Product1", 50);
        Product p2 = new Product("Product2", 50);

        Order o = new Order();
        o.Add(p1);
        o.Add(p2);

        Console.WriteLine("Price for not registered: " + o.Calculate("notRegisteredOrder", 0));
        Console.WriteLine("Price with 1 year registrarion: " + o.Calculate("registeredOrder", 1));
        Console.WriteLine("Price with 5 year registrarion: " + o.Calculate("registeredOrder", 5));
        Console.WriteLine("Price with 10 year registrarion: " + o.Calculate("registeredOrder", 10));
    }
}