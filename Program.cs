using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            var xhMax = numbers.GroupBy(x => x).Where(y => y.Count() == numbers.GroupBy(c => c).Max(d => d.Count()));
            foreach (var num in xhMax)
                Console.Write(" {0} " , num.Key);

            Console.ReadKey();
        }
    }
}
