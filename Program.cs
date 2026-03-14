using System;
using System.Collections.Generic;
using System.Linq;

namespace BTTrenLop
{
    internal class Program
    {
        static List<SinhVien> InitRandomSinhVien(int n)
        {
            Random rand = new Random();

            string[] ten = { "Hoang", "Binh", "Chi", "Dung", "Huy", "Lan", "Minh", "Nam", "Phuc", "Trang" };
            string[] khoa = { "Cong Nghe So", "Co Khi", "Dien tu", "Xay dung", "Cong Nghiep" };

            List<SinhVien> list = new List<SinhVien>();

            for (int i = 0; i < n; i++)
            {
                list.Add(new SinhVien
                {
                    Ten = ten[rand.Next(ten.Length)],
                    Tuoi = rand.Next(18, 25),
                    Khoa = khoa[rand.Next(khoa.Length)],
                    DTB = Math.Round(rand.NextDouble() * 10, 2)
                });
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<SinhVien> ds = InitRandomSinhVien(15);

            Console.WriteLine("Danh sach sinh vien: ");
            foreach (var sv in ds)
                Console.WriteLine(sv);

            var tuoiMax = ds.Max(x => x.Tuoi);
            Console.WriteLine("Tuoi Max: {0}", tuoiMax);
            var tuoiMin = ds.Min(x => x.Tuoi);
            Console.WriteLine("Tuoi Min: {0}", tuoiMin);

            if (ds.Any(x => x.Khoa == "Cong Nghe So"))
                Console.WriteLine("Co sinh vien thuoc khoa CNS");
            else
                Console.WriteLine("Khong co sinh vien thuoc khoa CNS");

            Console.WriteLine("10 sinh vien diem trung binh cao nhat khoa: ");
            var top10TheoKhoa = ds.GroupBy(x => x.Khoa).Select(g => new
                                                        {
                                                            Khoa = g.Key,
                                                            SinhViens = g.OrderByDescending(x => x.DTB).Take(10)
                                                        });
            foreach (var group in top10TheoKhoa)
            {
                Console.WriteLine($"KHOA: {group.Khoa}");
                foreach (var sv in group.SinhViens)
                    Console.WriteLine(sv);
            }

            Console.WriteLine("Danh sach sinh vien khong phai nam cuoi:");

            var svConLai = ds.Where(x => x.Tuoi < 22);

            foreach (var sv in svConLai)
                Console.WriteLine(sv);

            Console.ReadKey();
        }
    }
}
