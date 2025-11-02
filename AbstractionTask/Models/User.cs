using System;

namespace AbstractionTask.Models
{
    public class User : Account, IPerson
    {
        private static int _idCounter = 1;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                while (string.IsNullOrWhiteSpace(value) || !PasswordChecker(value))
                {
                    if (string.IsNullOrWhiteSpace(value))
                        Console.WriteLine("Ad boş buraxila bilmez");
                    else
                        Console.WriteLine(" Şifrə yanlışdır. (Min 8 simvol, 1 böyük, 1 kiçik, 1 rəqəm)");

                    Console.Write("Yeni şifrə daxil et: ");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        public User(string fullname, string email, string password)
        {
            Id = _idCounter++;

            while (string.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("Ad boş buraxila bilmez");
                Console.Write("Fullname daxil et: ");
                fullname = Console.ReadLine();
            }
            Fullname = fullname;

       
            while (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine(" Email boş ola bilməz!");
                Console.Write("Email daxil et: ");
                email = Console.ReadLine();
            }
            Email = email;

            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User -> Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
