namespace TheCompant;

internal class Medewerker: Persoon, IContract
{
    public void DoJob()
    {
        Werkt();
    }

    public virtual void Werkt()
    {
        Console.WriteLine("Doet niets");
    }
}
