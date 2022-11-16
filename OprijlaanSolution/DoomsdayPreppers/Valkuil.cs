using ISO;

namespace DoomsdayPreppers;

public class Valkuil: IDetectable
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil opent en scherpe spiezen worden zichtbaar");
    }
}