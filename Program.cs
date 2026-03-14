using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            double tb = numbers.Average();
            Console.WriteLine("Trung binh day la: {0}", tb);

            Console.ReadKey();
        }
    }
}
