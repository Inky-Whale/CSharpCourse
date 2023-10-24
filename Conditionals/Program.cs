// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        var number1 = 12;
        var number2 = 15;
        if (number1 == number2)
        {
            Console.WriteLine("numbers are equal");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("number1 is higher then number2");
        }
        else
        {
            Console.WriteLine("number1 is lower then number2");
        }

        Console.WriteLine(number2 == number1 ? "numbers are equal" : "numbers are not equal");

        switch (number1)
        {
            case 10:
                Console.WriteLine("number1 is 10");
                break;
            case 20:
                Console.WriteLine("number1 is 20");
                break;
            default:
                Console.WriteLine("number1 is unknown");
                break;
        }

        if (number1 >= 0 && number1 <= 100)
        {
            Console.WriteLine("number1 is btw 0 and 100");
        }
        else if (number1 > 100 && number1 <= 200)
        {
            Console.Write("number1 is btw 100 and 200");
        }else if (number1 > 200 || number1 < 0)
        {
            Console.WriteLine("number1 is bigger then 200 or lower then 0");
        }

        if (number1 < 100)
        {
            if (number1 >= 90)
            {
                Console.Write("number is btw 90 and 100");
            }
        }

    }
}
