namespace RadioStations;

delegate void Method(string msg);

internal class RadioStation
{
    public event Method subscribers;


    public void Broadcast()
    {
        subscribers("Halloooo luisteraars");
    }
}
