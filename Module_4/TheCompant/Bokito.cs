namespace TheCompant;

internal class Bokito : IContract, IContract2
{
    void IContract2.DoJob()
    {
        Werkt();
        Console.WriteLine("Bokito ramt dames in elkaar");
    }

    public void DoJob()
    {
        Werkt();
    }

    public void Werkt()
    {
        Console.WriteLine("Bokito gooit met poep");
    }
}
