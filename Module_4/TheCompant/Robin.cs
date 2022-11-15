namespace TheCompant;

internal class Robin : Medewerker
{
    public override void Werkt()
    {
        DoetIets();
    }
    public void DoetIets()
    {
        Console.WriteLine("Robin speelt met cobolts");
    }
}
