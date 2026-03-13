using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var sochan = new List<int> {};

            sochan = numbers.Where(x => x % 2 == 0).ToList();
            Console.Write("Danh cac so chan la: ");
            foreach (int x in sochan)
                Console.Write("{0} ", x);

            Console.ReadKey();
        }
    }
}
