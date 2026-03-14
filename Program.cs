using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai11
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

            var diem = students.Max(x => x.Score);
            var SV = students.Where(x => x.Score == diem);
            foreach (var student in SV)
                Console.WriteLine(student);
            Console.ReadKey();
        }
    }
}
