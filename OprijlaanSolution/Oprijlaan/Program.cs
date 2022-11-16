using DoomsdayPreppers;
using Heras;
using Philips;
using Siemens;
using Sony;

namespace Oprijlaan;

internal class Program
{
    static void Main(string[] args)
    {
        var lus = new Detectielus();
        var tl = new Lamp();
        var cam = new Camera();  
        var gate = new Hek();
        var valkuil= new Valkuil();

        lus.Connect(gate);
        lus.Connect(cam); 
        lus.Connect(valkuil);
        lus.Connect(tl);


        lus.Detect();
    }
}