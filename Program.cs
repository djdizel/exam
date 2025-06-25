using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество студентов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для студента " + (i + 1) + ":");
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Фамилия: ");
                string surname = Console.ReadLine();
                Console.Write("Средний балл: ");
                double averageGrade = Convert.ToDouble(Console.ReadLine());

                students[i] = new Student(name, surname, averageGrade);
            }

            Console.WriteLine("\nОтличники (средний балл >= 4.5):");
            bool found = false;
            for (i = 0; i < n; i++)
            {
                if (students[i].IsExcellent())
                {
                    Console.WriteLine("Студент " + (i + 1) + ":");
                    students[i].ShowInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Отличники не найдены.");
            }
        }
    }
}
