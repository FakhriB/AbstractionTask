namespace AbstractionTask.Models
{
    internal class Students;

namespace Project.Models
    {
        public class Student : IPerson
        {
            private static int _idCounter = 1;
            public int Id { get; }
            public string Fullname { get; set; }
            public double Point { get; set; }

            public Student(string fullname, float point)
            {
                Id = _idCounter++;
                Fullname = fullname;
                Point = point;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Student -> Id: {Id}, Fullname: {Fullname}, Point: {Point}");
            }
        }
    }

}
