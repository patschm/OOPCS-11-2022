namespace VastgoedMagnaat;

internal class Program
{
    static void Main(string[] args)
    {
        //StaticMembers();  
        StaticMethods();
    }

    private static void StaticMethods()
    {
        Point p1 = new Point { X=10, Y=20 };
        Point p2 = new Point { X = 100, Y = 200 };
        //Point p3 = Point.Add(p1, p2);
        Point p3 = p1 + p2;

        Console.WriteLine(p3.Coor);
    }

    private static void StaticMembers()
    {
        Etage.elevator.Call(100);

        Etage[] flat = new Etage[40];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }

        flat[30].CallElevator();

        foreach (var et in flat)
        {
            Console.WriteLine(et.Status);
        }
    }
}