namespace Tuples;

internal class Program
{
    static void Main(string[] args)
    {
        (int Id, string Name, int Age) p1 = (1, "Patrick", 23);
        DoeIets(p1);

        Console.WriteLine(p1.Id);
        Console.WriteLine(p1.Name);
    }

    private static void DoeIets((int, string, int) p1)
    {
        p1.Item1 = 20;
    }
}