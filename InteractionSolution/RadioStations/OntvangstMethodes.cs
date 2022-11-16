namespace RadioStations;

internal static class OntvangstMethodes
{
    public static void ViaSms(string msg)
    {
        Console.WriteLine($"Ontvangen via SMS: {msg}");
    }
    public static void ViaKabel(string msg)
    {
        Console.WriteLine($"Ontvangen via Kabel: {msg}");
    }
    public static void ViaEther(string msg)
    {
        Console.WriteLine($"Ontvangen via Ether: {msg}");
    }
    public static void ViaEmail(string msg)
    {
        Console.WriteLine($"Ontvangen via Email: {msg}");
    }
    public static void ViaDABPlus(string msg)
    {
        Console.WriteLine($"Ontvangen via DAB+: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Ontvangen via postduif: {msg}");
    }
}
