namespace TheCompant;

internal class Desiree : Medewerker
{
    public override void Werkt()
    {
        Beep();
    }
    public void Beep()
    {
        Console.WriteLine("Desiree roept beeeeeeeeeeeeep");
    }
}
