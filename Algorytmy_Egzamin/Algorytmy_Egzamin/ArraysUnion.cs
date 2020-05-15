using System.Collections.Generic;

namespace Algorytmy_Egzamin
{
    static class ArraysUnion
    {
        public static int[] Union(int[] array1, int[] array2)
        {
            int[] clone1 = (int[])array1.Clone();
            int[] clone2 = (int[])array2.Clone();
            QuickSort.Sort(clone1);
            QuickSort.Sort(clone2);

            List<int> output = new List<int>();

            int Index1 = 0, Index2 = 0;

            while(Index1 < clone1.Length && Index2 < clone2.Length)
            {
                if (clone1[Index1] < clone2[Index2])
                {
                    output.Add(clone1[Index1]);
                    Index1++;
                }
                else if (clone1[Index1] > clone2[Index2])
                {
                    output.Add(clone2[Index2]);
                    Index2++;
                }
                else
                {
                    output.Add(clone1[Index1]);
                    Index1++;
                    Index2++;
                }
            }

            for (int i = Index1; i < clone1.Length; i++)
            {
                output.Add(clone1[i]);
            }

            for (int i = Index2; i < clone2.Length; i++)
            {
                output.Add(clone2[i]);
            }

            for (int i = output.Count - 1; i > 0; i--)
            {
                if (output[i] == output[i - 1])
                {
                    output.RemoveAt(i);
                }
            }

            return output.ToArray();
        }
    }
}
