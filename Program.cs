using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
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
              new Student { Id = 4, Name = "Dung", Score = 5 } };

            var groups = students.GroupBy(x =>
            {
                if (x.Score >= 8)
                    return "Gioi";
                else
                    if (x.Score >= 6)
                        return "Kha";
                    else
                        return "Trung binh";
            });

            foreach (var group in groups)
            {
                Console.WriteLine("Xep loai: {0}", group.Key);
                foreach (var student in group)
                    Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
