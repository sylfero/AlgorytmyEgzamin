using System.Collections.Generic;
using System.IO;

namespace Algorytmy_Egzamin
{
    static class Data
    {
        public static int[] GetArray(string path)
        {
            List<int> output = new List<int>();

            using(StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                    output.Add(int.Parse(reader.ReadLine()));
            }

            return output.ToArray();
        }
    }
}
