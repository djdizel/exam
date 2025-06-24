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
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите должность: ");
            string position = Console.ReadLine();
            Console.Write("Введите стаж (в годах): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(surname, name);
            var (salary, tax) = employee.CalculateSalaryAndTax(position, experience);

            Console.WriteLine($"Сотрудник: {surname} {name}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Оклад: {salary:F2}");
            Console.WriteLine($"Налог: {tax:F2}");
        }
    }
}
