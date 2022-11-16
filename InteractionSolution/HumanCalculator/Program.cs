namespace HumanCalculator;

internal class Program
{
    static void Main(string[] args)
    {
        var wk = new WillemKlein();
        var svm = new SimonVanDeMeer();

        MathDel m = svm.Add;
        m += svm.Subtract;
        m += svm.Add;
        m -= svm.Add;

        foreach(var met in m.GetInvocationList())
        {
            Console.WriteLine(met.Method.Name);
        }
        
        int res = m(1, 2);

        Console.WriteLine(res);

        //wk.Reken(svm.Add, 1, 2);
        //wk.Reken(svm.Subtract, 1, 2);
    }
}