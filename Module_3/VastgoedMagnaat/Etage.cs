namespace VastgoedMagnaat;

class Etage
{
    public int EtageNummer { get; set; }
    public static Lift elevator;

    public void CallElevator()
    {
        Etage.elevator.Call(this.EtageNummer);
    }
    public string Status 
    { 
        get 
        {
            return $"De lift staat op de {elevator.CurrentPosition}";
        } 
    }
    static Etage()
    {
        elevator= new Lift();
    }
}