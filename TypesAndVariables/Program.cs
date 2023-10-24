// See https://aka.ms/new-console-template for more information

internal class TypesAndVariables
{
    public static void Main(string[] args)
    {
        //Value Types
        int number1 = 10;
        short number2 = 32767;
        long number3 = 2147483649;
        byte number4 = 255;
        bool condition = false;
        char character = 'A';
        double number5 = 12.4;
        decimal number6 = 27.43434m;
        var number7 = 102;
        number7 = 'A';

        Console.WriteLine("Numbers are {0}, {1}, {2}, {3}, {4}", number1, number2, number3, number4, number5);
        Console.WriteLine("Character is:" + character);
        Console.WriteLine(Days.Friday);
        Console.WriteLine(number7);
        Console.ReadLine();
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
