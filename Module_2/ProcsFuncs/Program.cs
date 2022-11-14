namespace ProcsFuncs;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(args?[0]);
        int x = GeefGetal();
        //int x= Add(1, 2, 3, 4,5,6,7, 8, 9, 10);
        ShowGetal(x);
        //string res = NameAge(age:50, name:"Kees");
        //Console.WriteLine(res);

        //int nr;
        //Console.WriteLine(nr);
        DoeIets(out int nr);
        Console.WriteLine(nr);
    }

    static void DoeIets(out int getal)
    {
        getal = 10;
        getal *= 100;
        Console.WriteLine(getal);
    }

    // Function
    static int GeefGetal()
    {
        Console.WriteLine("Geef een getal");
        string s = Console.ReadLine();
        int nr;
        bool ok = int.TryParse(s, out nr);
        return nr;
    }

    // Procedure
    static void ShowGetal(int getal)
    {
        Console.WriteLine($"Het opgegeven getal is {getal}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    // Overload
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static int Add(params int[] getallen)
    {
        return getallen.Sum();
    }

    static string NameAge(string name = "Jan", int age = 42)
    {
        return $"De naam is {name} en de leeftijd is {age}";
    }
}