namespace Misc;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        Console.WriteLine(p1);
        // pxx = p1
        ZetInDeHens(p1);
        Console.WriteLine(p1);
    }

    private static void ZetInDeHens(Point pxx)
    {
        pxx.X = 1000;
        pxx.Y = 2000;
    }
}