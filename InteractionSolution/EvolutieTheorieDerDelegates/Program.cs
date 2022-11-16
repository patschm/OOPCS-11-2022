namespace EvolutieTheorieDerDelegates;

delegate int MathDel(int x, int y);

internal class Program
{
    static void Main(string[] args)
    {
        int c = 10;
        // Framework 1.0/1.1 (2002/2003)
        MathDel d1 = new MathDel(Add);
        int result = d1(1, 2);

        // Framework 2.0 (2005)
        MathDel d2 = Add;
        result = d2(2, 3);

        MathDel d3 = delegate (int a, int b)
            {
                return a + b + c;
            };
        result = d3(3, 4);

        // Framework 3.0/3.5 (2008)
        MathDel d4 = (a, b) => a + b + c;
        result = d4(7, 8);

        // Procedures
        Action<string> a = (s) => Console.WriteLine(s);
        a("Hallo");

        // Functions
        Func<int, int, int> ff = Add;
        result = ff(7, 8);

        int AddInt(int a, int b)
        {
            return a + b;
        }
        result = AddInt(9, 10);
        Console.WriteLine(result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}