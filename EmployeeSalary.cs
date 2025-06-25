using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class EmployeeSalary
    {
        private string name;
        private double salary;
        private double bonus;

        public EmployeeSalary(string name, double salary, double bonus)
        {
            this.name = name;
            this.salary = salary;
            this.bonus = bonus;
        }

        public double CalculateTotalSalary()
        {
            return salary + bonus;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Зарплата: " + String.Format("{0:F2}", salary));
            Console.WriteLine("Премия: " + String.Format("{0:F2}", bonus));
            Console.WriteLine("Итоговая зарплата: " + String.Format("{0:F2}", CalculateTotalSalary()));
            Console.WriteLine();
        }
    }
}
