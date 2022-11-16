namespace RadioStations;

internal class Program
{
    static void Main(string[] args)
    {
        var r538 = new RadioStation();
        r538.subscribers += OntvangstMethodes.ViaSms;
        r538.subscribers += OntvangstMethodes.ViaDABPlus;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaEmail;
        r538.subscribers += OntvangstMethodes.ViaEther;
        r538.subscribers += OntvangstMethodes.ViaKabel;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaEmail;

        r538.Broadcast();

        //r538.subscribers("Heya Klojooos");
    }
}