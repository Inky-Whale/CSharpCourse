// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();

        if (isPrimeNumber(6))
        {
            Console.WriteLine("this is a prime number");
        }
        else
        {
            Console.WriteLine("number is not a prime number");
        }

        Console.ReadLine();
    }

    private static bool isPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }

    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Berk", "Ekin", "Engin" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 0);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }

        Console.WriteLine("number is {0} now", number);
    }

    private static void ForLoop()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("finished");
    }
}
