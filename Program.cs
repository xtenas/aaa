using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }




    }
}