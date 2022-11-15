namespace VastgoedMagnaat;

class Lift
{
    public int CurrentPosition;

    public void Call(int nr)
    {      
        Console.WriteLine($"De lift zoeft naar de {nr}e verdieping"); 
        CurrentPosition= nr;
    }
}