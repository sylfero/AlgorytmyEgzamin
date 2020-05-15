using System;

namespace Algorytmy_Egzamin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = Data.GetArray("array1.txt");
            int[] a2 = Data.GetArray("array2.txt");
            int[] union = ArraysUnion.Union(a1, a2);
            foreach (int i in union)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
