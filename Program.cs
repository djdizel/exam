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
            Console.Write("Введите номер счёта: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Введите начальный баланс: ");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите тип счёта (сберегательный/текущий): ");
            string accountType = Console.ReadLine();

            BankAccount account = new BankAccount(accountNumber, balance, accountType);

            Console.WriteLine("\nИнформация о счёте:");
            account.ShowInfo();

            Console.Write("Введите сумму для пополнения: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Введите сумму для снятия: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            Console.WriteLine("\nОбновлённая информация о счёте:");
            account.ShowInfo();
        }
    }
}
