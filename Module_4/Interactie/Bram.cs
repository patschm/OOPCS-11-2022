namespace Interactie;

// TYPE DEFINITIE
delegate void Instructie();

internal class Bram
{
    public void  Execute(Instructie iets)
    {
        Console.WriteLine("Bram doet nu iets");
        iets();
    }
}