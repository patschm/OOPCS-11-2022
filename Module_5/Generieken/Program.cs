using System.Security.Cryptography.X509Certificates;

namespace Generieken;

internal class Program
{
    static void Main(string[] args)
    {
        Point<Bakfiets> f1 = new Point<Bakfiets>();
        var bf = f1.Create();


        Bakfiets a = new () { X = 10 };
        Bakfiets b = new() { X = 100 };
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    private static void Swap<T>(ref T aa, ref T bb)
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }

    //private static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //private static void Swap(ref decimal aa, ref decimal bb)
    //{
    //    decimal tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
}