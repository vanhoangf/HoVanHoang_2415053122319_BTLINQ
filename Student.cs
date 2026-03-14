
namespace Bai18
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public Student() { }
        public Student(int id, string name, double score)
        {
            this.Id = id;
            this.Name = name;
            this.Score = score;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}\nTen: {this.Name}\nDiem: {this.Score}\n";
        }
    }
}
