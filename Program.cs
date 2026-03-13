using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var sx = numbers.OrderByDescending(x => x);
            Console.Write("Danh sach sau khi sap xep: ");
            foreach (var x in sx)
                Console.Write("{0} ", x);
            Console.ReadKey();
        }
    }
}
