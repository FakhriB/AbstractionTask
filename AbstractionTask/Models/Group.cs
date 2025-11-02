using AbstractionTask.Models.Project.Models;

namespace Project.Models
{
    public class Group
    {
        public string GroupNo { get; }
        public int StudentLimit { get; }

        private Student[] students;

        public Group(string groupNo, int studentLimit)
        {
            if (!IsValidGroupNo(groupNo) || studentLimit < 5 || studentLimit > 18)
            {
                Console.WriteLine("Qrup məlumatları yanlışdır.");
                return;
            }

            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[studentLimit];
        }

        bool IsValidGroupNo(string no)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 2 && !(no[i] >= 'A' && no[i] <= 'Z')) return false;
                if (i >= 2 && !(no[i] >= '0' && no[i] <= '9')) return false;
            }
            return true;
        }

        public void AddStudent(Student s)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = s;
                    Console.WriteLine("Tələbə əlavə olundu.");
                    return;
                }
            }
            Console.WriteLine("Limit dolub.");
        }

        public Student GetStudent(int id)
        {
            foreach (var s in students)
                if (s != null && s.Id == id)
                    return s;

            return null;
        }

        public Student[] GetAllStudents() => students;
    }
}
