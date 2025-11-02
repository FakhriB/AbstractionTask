using AbstractionTask.Models.Project.Models;
using System;
using Project.Models;


namespace AbstractionTask.Models
{
    class Program
    {
        static void Main()
        {

            Console.Write("Fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            User user = new(fullname, email, password);

            Console.Clear();
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");
            Console.Write("Seçim: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                user.ShowInfo();
                return;
            }

            if (choice == "2")
            {
                Console.Write("GroupNo (məs: AB123): ");
                string groupNo = Console.ReadLine();

                Console.Write("Student limit (5-18): ");
                int limit = int.Parse(Console.ReadLine());

                Group group = new(groupNo, limit);
                Console.WriteLine($"Yeni qrup yaradıldı: {group.GroupNo}");

                while (true)
                {
                    Console.WriteLine("\n1. Show all students \n2. Get student by id \n3. Add student \n0. Quit \nSeçim: ");
                    string secim = Console.ReadLine();

                    if (secim == "0")
                    {
                        Console.WriteLine("----Proqram bitdi---- ");
                        break;
                    }

                    switch (secim)
                    {
                        case "1":
                            var students = group.GetAllStudents();
                            if (students.Length == 0)
                                Console.WriteLine("❗ Heç bir student yoxdur.");
                            else
                                foreach (var s in students)
                                    if (s != null) s.ShowInfo();
                            break;

                        case "2":
                            Console.Write("Student Id: ");
                            int id = int.Parse(Console.ReadLine());
                            var found = group.GetStudent(id);
                            if (found != null) found.ShowInfo();
                            else Console.WriteLine("Tapılmadı ");
                            break;

                        case "3":
                            Console.Write("Fullname: ");
                            string sFull = Console.ReadLine();
                            Console.Write("Point: ");
                            float sPoint = float.Parse(Console.ReadLine());
                            group.AddStudent(new Student(sFull, sPoint));
                            break;

                        default:
                            Console.WriteLine("Yanlış seçim!");
                            break;
                    }
                }
            }
        }
    }
}