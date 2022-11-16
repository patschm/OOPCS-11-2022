using ISO;

namespace Siemens;

public delegate void Detectable();

public class Detectielus
{
    private List<IDetectable> devices = new List<IDetectable>();
    public event Detectable Detecting;

    public void Connect(IDetectable device)
    {
        devices.Add(device);
    }

    public void Detect()
    {
        Console.WriteLine("De detectielus ziet iets");
        foreach(IDetectable device in devices)
        {
            device.Activate();
        }
        Detecting?.Invoke();
    }
}