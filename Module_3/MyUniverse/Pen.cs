namespace MyUniverse;

abstract class Pen
//class Pen
{
    // Fields. Hierin slaan we de eigenschappen op
    private int lijndikte = 20;
    //private ConsoleColor kleur = ConsoleColor.DarkRed;

    // Access method
    // Old school voo Javanen en C++-erts
    //public void Set_Lijndikte(int ld)
    //{
    //    if (ld >0 && ld < 40)
    //    {
    //        lijndikte= ld;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Niet ok");
    //    }
    //}
    //public int Get_Lijndikte()
    //{
    //    return lijndikte;   
    //}

    // Properties. Hiermee geven we gecontroleerd toegang tot de private fields
    
    // Auto generating property
    public ConsoleColor Kleur { get; set; }
    
    public int Lijndikte
    {
        get 
        { 
            return lijndikte; 
        }
        set
        {
            if (value > 0 && value < 40)
            {
                lijndikte = value;
            }
            else
            {
                Console.WriteLine("Niet ok");
            }
        }
    }

    // Methods. Hierin definieren we gedrag
    // Abstract. Afgeleide classen MOETEN overschrijven.. Jouw implementatie is dan ook overbodig.
    // Gevolg is wel dat de hele class abstract.
    public abstract void Schrijf(string text);

    // Virtual: Afgeleide classen mogen (OPTIONEEL) overschrijven, maar hoeft niet.
    //public virtual void Schrijf(string text)
    //{
    //    Console.ForegroundColor = Kleur;
    //    Console.WriteLine($"{text} in lijndikte {lijndikte}");
    //    Console.ResetColor();
    //}

    // Constructor. Hierin geef je jouw fields een initiele waarde.
    // Gebruik met mate!!!!
    public Pen(int lijndikte, ConsoleColor kleur)
    {
        this.Lijndikte = lijndikte;
        this.Kleur = kleur;
    }
    public Pen()
    {

    }
}
