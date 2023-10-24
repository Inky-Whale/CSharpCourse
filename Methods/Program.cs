// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Add();

        int number1 = 20;
        int number2 = 100;
        var result = Add2(2);
        var result2 = Add3(ref number1, number2);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(number1);

        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2, 4, 5));
        Console.WriteLine(Add4(4,5,6,23,3,1,4));

        Console.ReadLine();
    }

    static void Add()
    {
        Console.Write("Added!");
    }

    static int Add2(int number1, int number2 = 130)
    {
        return number1 + number2;
    }

    static int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }

    

}
