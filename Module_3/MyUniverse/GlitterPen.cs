namespace MyUniverse;

class GlitterPen : Pen
{
    public string? Geur { get; set; }

    public override void Schrijf(string text)
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"{text} Glitter in lijndikte {Lijndikte} en het ruikt naar {Geur}");
        Console.ResetColor();
    }
    public GlitterPen(int lijndikte, ConsoleColor kleur) : base(lijndikte, kleur)
    {
    }
    public GlitterPen():base()
    {

    }
}
