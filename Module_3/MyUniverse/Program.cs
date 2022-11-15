#define ABSTRACT

namespace MyUniverse;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Big Bang");

        // Generaliseren
        Pen p10 = new GlitterPen { Kleur = ConsoleColor.Red, Geur = "Kers" };
        (p10 as GlitterPen).Geur = "Banaan"; // Vergrootglas erop

        p10.Schrijf("Gary");


#if !ABSTRACT
        Pen p1 = new Pen();
        //Pen p1 = new Pen(20, ConsoleColor.DarkGreen);
        //p1.lijndikte = 5;
        //p1.kleur = ConsoleColor.DarkBlue;

        p1.Schrijf("Hallo");

        Pen p2 = new Pen(-100, ConsoleColor.DarkBlue);
        p2.Schrijf("Wereld");

        Pen p3 = new Pen { Kleur = ConsoleColor.DarkBlue, Lijndikte = 20 };
        p3.Lijndikte = 35;
        //p3.Set_Lijndikte(35);

        p3.Schrijf("Lachuhh!");

        Pen p4 = new() { Kleur = ConsoleColor.DarkMagenta , Lijndikte = 200 };
        //p4.Set_Lijndikte(100);
        p4.Schrijf("Korter!");

        Console.WriteLine("Big Crunch"); 
#endif
    }
}