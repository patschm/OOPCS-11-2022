namespace Typen;

enum Weekdays : long
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64
}

internal class Program
{
    static void Main(string[] args)
    {
        int dag = 17;

        var state = dag & (int)Weekdays.Thursday;
        Console.WriteLine(state);
        //Weekdays day = Weekdays.Friday;
        Weekdays day = (Weekdays)dag;
        Console.WriteLine($"{day} [{(int)day}]");

    }
}