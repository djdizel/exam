using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Employee
    {
        private string surname, name;

        public Employee(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }

        public (double salary, double tax) CalculateSalaryAndTax(string position, int experience)
        {
            double baseSalary = 0;
            switch (position.ToLower())
            {
                case "менеджер": baseSalary = 2000; break;
                case "разработчик": baseSalary = 3000; break;
                case "тестировщик": baseSalary = 1500; break;
                default: baseSalary = 1000; break;
            }

            double experienceBonus = experience > 5 ? 1.5 : experience > 2 ? 1.2 : 1.0;
            double salary = baseSalary * experienceBonus;
            double tax = salary * 0.13; // Налог 13%

            return (salary, tax);
        }
    }
}
