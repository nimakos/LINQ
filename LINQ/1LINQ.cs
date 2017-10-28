using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class _1LINQ
    {
        long memoryBefore = GC.GetTotalMemory(true);
        // The Three Parts of a LINQ Query:
        //  1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };


        public void create_the_query()
        {
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int i in numQuery)
            {
                Console.Write("{0,2} ", i);
            }
            long memoryAfter = GC.GetTotalMemory(false);
            Console.ReadLine();
            Console.WriteLine("Memory Used  = \t" +
                string.Format(((memoryAfter - memoryBefore) / 1000).ToString(), "n") + "kb");
            Console.ReadKey();
        }
       
    }
}
