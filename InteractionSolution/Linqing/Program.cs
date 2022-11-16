namespace Linqing;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Met welke letter moeten de slachtoffers beginnen");
        string letter = Console.ReadLine();

        Bogus.Faker<Person> faker = new Bogus.Faker<Person>();
        List<Person> list = faker
             .RuleFor(p => p.Id, fk => fk.Random.Number(0, 1000))
             .RuleFor(p => p.Name, fk => fk.Person.FullName)
             .RuleFor(p => p.Age, fk => fk.Random.Number(0, 123))
             .Generate(1000)
             .ToList();

        var query = list.Where(p=>p.Name.StartsWith(letter)).OrderBy(p=>p.Age);


        foreach(Person p in query)
        {
            Console.WriteLine($"{p.Name} [{p.Age}]");
        }
    }
    static bool NameStartsWithA(Person p)
    {
        return p.Name.StartsWith("A");
    }
    static bool NameStartsWithB(Person p)
    {
        return p.Name.StartsWith("B");
    }
    static bool AgeIs65(Person p)
    {
        return p.Age == 65;
    }
}