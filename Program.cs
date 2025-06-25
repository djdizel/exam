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
            Console.Write("Введите количество сотрудников: ");
            int n = Convert.ToInt32(Console.ReadLine());

            EmployeeSalary[] employees = new EmployeeSalary[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для сотрудника " + (i + 1) + ":");
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Зарплата: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Премия: ");
                double bonus = Convert.ToDouble(Console.ReadLine());

                employees[i] = new EmployeeSalary(name, salary, bonus);
            }

            Console.WriteLine("\nСотрудник с максимальной итоговой зарплатой:");
            int maxIndex = 0;
            double maxSalary = employees[0].CalculateTotalSalary();
            for (i = 1; i < n; i++)
            {
                if (employees[i].CalculateTotalSalary() > maxSalary)
                {
                    maxSalary = employees[i].CalculateTotalSalary();
                    maxIndex = i;
                }
            }
            employees[maxIndex].ShowInfo();
        }
    }
}
