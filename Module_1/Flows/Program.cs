namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        //Forwaards();
        Loopuh();
    }

    private static void Loopuh()
    {
        int age = 10;
        //while(age < 10)
        //{
        //    Console.WriteLine(age++);
        //}
        //do
        //{
        //    Console.WriteLine(age++);
        //} 
        //while (age < 10);

        //int a = 0;
        //for (Console.WriteLine("Init"); a < 10; Console.WriteLine("Tja!"))
        for(int a = 0; a < 10; a = a + 1) 
        {
            Console.WriteLine($"Aha! {a}");

        }
        //Console.WriteLine(a);
    }

    private static void Forwaards()
    {
        int age = 100;
        if (age < 18)
        {
            Console.WriteLine("Jonger dan 18");
        }
        else if (age <=67)
        {
            Console.WriteLine("Jonger dan 67");
        }
        else
        {
            Console.WriteLine("Ouder");
        }

        switch(age)
        {
            case 1:
                Console.WriteLine("");
                break;
            case 11:
            case 12:
                Console.WriteLine("");
                break;
            default:
                Console.WriteLine();
                break;
        }
          
    }
}