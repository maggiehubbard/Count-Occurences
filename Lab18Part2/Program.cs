using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 7, 8, 3, 2, 3, 7, 8, 0, 10, 1, 2, 2, 2 };

            Dictionary<int, int> freqCounts = new Dictionary<int, int>();
            foreach (int arrayValue in myarray)
            {
                if (!freqCounts.ContainsKey(arrayValue))
                {
                    freqCounts.Add(arrayValue, 1);
                }
                else
                {
                    freqCounts[arrayValue]++;
                }
            }

            foreach (int key in freqCounts.Keys.OrderBy(key => key))
            {
                Console.WriteLine(key.ToString() + " = " + freqCounts[key].ToString());
            }

            Console.ReadKey();
        }
    }
}
