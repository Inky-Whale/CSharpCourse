// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        string[] students = new string[3];
        students[0] = "Berk";
        students[1] = "Ekin";
        students[2] = "Engin";


        string[] students2 = new string[3] {"Berk", "Ekin", "Salih"};

        string[,] regions = new string[5, 3]
        {
            {"İstanbul","İzmit","Balıkesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mersin"},
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"},
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
            Console.WriteLine("*********");
        }
    }
}
