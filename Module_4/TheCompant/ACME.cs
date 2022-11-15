namespace TheCompant;

internal interface IContract
{
    void DoJob();
}

internal class ACME
{
    private List<IContract> werknemers = new List<IContract>();

    public void Hire(IContract emp)
    {
        werknemers.Add(emp);
    }
    public void Fire(IContract emp)
    {
        werknemers.Remove(emp);
    }
    public void Stoomfluit()
    {
        Console.WriteLine("De stoomfluit gaat. ACME wordt wakker");

        foreach(IContract emp in werknemers) 
        {
            emp.DoJob();
        }
    }
}
