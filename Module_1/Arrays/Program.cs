namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        Basic();
    }

    private static void Basic()
    {
        //int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array[0] = 1;
        array[1] = 2;

        Console.WriteLine(array[5]);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4,5,6 } };   
        matrix[0,1] = 3;

        int[,,] kubus = new int[3, 3, 3];

        int[][] jagged = new int[3][];
        jagged[0] = new int[10];
        jagged[1] = new int[5];

        for(int x = 0; x < array.Length; x++)
        {
            int tmp = array[x];
            Console.WriteLine(tmp);
        }
        foreach(int tmp in array)
        {
            Console.WriteLine(tmp);
        }

        List<int> list = new List<int>();
        //Stack<int> stack = new Stack<int>();    
        //Queue<int> queue = new Queue<int>();    
        Dictionary<string,int> dictionary = new Dictionary<string,int>();
        dictionary.Add("honderd", 100);
        Console.WriteLine(dictionary["honderd"]);
       
    }
}