using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Student
    {
        private string name;
        private string surname;
        private double averageGrade;

        public Student(string name, string surname, double averageGrade)
        {
            this.name = name;
            this.surname = surname;
            this.averageGrade = averageGrade;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Средний балл: " + String.Format("{0:F2}", averageGrade));
            Console.WriteLine();
        }

        public bool IsExcellent()
        {
            if (averageGrade >= 4.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
