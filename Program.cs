using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Ho Van Hoang\nMSV: 2415053122319\nLop: 225LTC01\n");
            List<Student> students = new List<Student>()
            { new Student { Id = 1, Name = "An", Score = 8 },
              new Student { Id = 2, Name = "Binh", Score = 6 },
              new Student { Id = 3, Name = "Chi", Score = 9 },
              new Student { Id = 4, Name = "Dung", Score = 7 } };

            if (students.Any(x => x.Score < 5))
                Console.WriteLine("Co sinh vien rot");
            else
                Console.WriteLine("Khong co sinh vien nao rot");

            Console.ReadKey();
        }
    }
}
