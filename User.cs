using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly DateTime dateFilled;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dateFilled = DateTime.Now;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Дата заполнения: {dateFilled:dd.MM.yyyy}");
        }
    }
}
