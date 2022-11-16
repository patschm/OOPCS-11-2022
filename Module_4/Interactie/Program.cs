namespace Interactie;

internal class Program
{
    static void Main(string[] args)
    {
        Bram b = new Bram();
        Patrick pat = new Patrick();

        Instructie fun = Ontplof;

        b.Execute(fun);
        b.Execute(pat.Bestel);
        b.Execute(Ontplof);

    }

    static void Ontplof()
    {
        Console.WriteLine("Kaboooom");
    }
}