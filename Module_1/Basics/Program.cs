using System.Security.Cryptography.X509Certificates;

namespace Basics;


internal class Program
{

    static void Main(string[] args)
    {
        int? month = null;
        string last = "hoi";

        Console.WriteLine(last.Length);
        Console.WriteLine(month ?? 8);

        int age = month = 25;      
        string name = "Patrick";
        bool lessThan = age > 18;

        bool isOk = lessThan && age < 65;

        int res = 1 | 2;

        Console.WriteLine(++age);
        Console.WriteLine(age);

        unsafe
        {

        }

        string iets = age > 25 ? "Is Ok" : age < 65 ? "Ok" : "Niet Ok";

    }
}