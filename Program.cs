using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var num = new List<int>();

            num = numbers.Where(x => x > 5).ToList();
            Console.Write("Danh sach so lon hon 5: ");
            foreach (var x in num)
                Console.Write("{0} ", x);
            Console.ReadKey();
        }
    }
}
