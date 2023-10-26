// See https://aka.ms/new-console-template for more information

using Classes;

internal class Program
{
    public static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        Console.WriteLine();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Berk";
        customer.LastName = "Karanfiloglu";

        Customer customer2 = new Customer
        {
            FirstName = "Berk",
            LastName = "Karanfiloglu",
            Id = 2,
            City = "Istanbul"
        };
        Console.WriteLine();

        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }
}

