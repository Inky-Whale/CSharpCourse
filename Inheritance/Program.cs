// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {

        Person[] persons = new Person[]
        {
            new Customer{FirstName = "Berk"},
            new Student{FirstName = "Ekin", Department = "CS"},
            new Person{FirstName = "Engin"}
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set; }
    }
}
