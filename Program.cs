using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var sc = numbers.Count(x => x % 2 == 0);
            Console.Write("So phan tu chan la: {0}", sc);
            Console.ReadKey();
        }
    }
}
