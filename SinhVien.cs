
namespace BTTrenLop
{
    internal class SinhVien
    {
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string Khoa { get; set; }
        public double DTB { get; set; }

        public SinhVien() {}
        public SinhVien(string ten, int tuoi, string khoa, double dtb)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Khoa = khoa;
            this.DTB = dtb;
        }

        public override string ToString()
        {
            return $"Ten: {this.Ten}\nTuoi: {this.Tuoi}\nKhoa: {this.Khoa}\nDiem: {this.DTB}\n";
        }
    }
}
