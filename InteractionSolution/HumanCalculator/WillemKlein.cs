namespace HumanCalculator;

delegate int MathDel(int bliep, int blob);

internal class WillemKlein
{
    public void Reken(MathDel fun, int x, int y)
    {
        Console.WriteLine("Willem begint te rekenen...");

        int result = fun(x,y);

        // TODO

        Console.WriteLine($"Eureka! Het antwoord is {result}");
    }
}
