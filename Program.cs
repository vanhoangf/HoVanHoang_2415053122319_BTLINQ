using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            if (numbers.Any(x => x > 10))
                Console.WriteLine("Co so lon hon 10");
            else
                Console.WriteLine("Khong co so lon hon 10");
            Console.ReadKey();
        }
    }
}
