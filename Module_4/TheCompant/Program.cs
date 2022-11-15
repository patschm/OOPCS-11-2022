namespace TheCompant;

internal class Program
{
    static void Main(string[] args)
    {
        var robin = new Robin();
        var desiree = new Desiree();
        var lauren= new Lauren();
        var company = new ACME();
        var bram = new Bram();
        var bokito = new Bokito();

        company.Hire(desiree);
        company.Hire(lauren);
        company.Hire(robin);
        company.Hire(bram);
        //company.Fire(lauren);
        company.Hire(bokito);

        company.Stoomfluit();

        (bokito as IContract2).DoJob();

        Console.ReadLine();
    }
}