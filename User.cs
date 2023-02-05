using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLessons
{
    public class User
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Description { get; set; }


        public User(string name, string lastName, string middleName, string description)
        {
            Login=CreateLogin();
            Password=CreatePassword();
            Name=name;
            LastName=lastName;
            MiddleName=middleName;
            Description=description;
        }

        public string CreatePassword()
        {
            string Pas = "12345";
            return Pas;
        }

        public string CreateLogin()
        {
            string Log = "Example";
            return Log;
        }

        public void Print()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Ваши данные. Всё верно?");
            Console.WriteLine($"ФИО:{Name} {LastName} {MiddleName}");
            Console.WriteLine("Сгенерирован логин...");
            Console.WriteLine($"Логин:{Login}");
            Console.WriteLine("Сгенерирован пароль...");
            Console.WriteLine($"Пароль:{Password}");
            Console.WriteLine($"О себе:{Description}");
        }
    }
}
