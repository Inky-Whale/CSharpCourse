// See https://aka.ms/new-console-template for more information

using Interfaces;

internal class Program
{
    public static void Main(string[] args)
    {
        //InterfacesIntro();
        //Demo();

        ICustomerDal[] customerDals = new ICustomerDal[]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer { Id = 1, FirstName = "Berk", LastName = "Karanfiloglu", Address = "Istanbul" });
        Customer customer2 = new Customer
        {
            Id = 2,
            FirstName = "Ekin",
            LastName = "Dara",
            Address = "Ankara"
        };
        manager.Add(customer2);

        Student student = new Student
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Ornek",
            Department = "CS"
        };

        manager.Add(student);

        manager.Add(new Worker
        {
            FirstName = "Mert",
            LastName = "Ornek1",
            Id = 3
        });
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Id);
            
        }
    }
}
