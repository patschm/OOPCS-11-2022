using ISO;

namespace Sony;

public class Camera: IDetectable
{
    public void Activate()
    {
        Draait();
    }

    public void Draait()
    {
        Console.WriteLine("De camera draait");
    }
}