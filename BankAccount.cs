using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class BankAccount
    {
        private string accountNumber;
        private double balance;
        private string accountType;

        public BankAccount(string accountNumber, double balance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            if (accountType != "сберегательный" && accountType != "текущий")
            {
                Console.WriteLine("Ошибка: тип счёта должен быть 'сберегательный' или 'текущий'!");
                this.accountType = "текущий";
            }
            else
            {
                this.accountType = accountType;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Счёт пополнен на " + String.Format("{0:F2}", amount));
            }
            else
            {
                Console.WriteLine("Ошибка: сумма пополнения должна быть положительной!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Снято " + String.Format("{0:F2}", amount));
            }
            else
            {
                Console.WriteLine("Ошибка: недостаточно средств или некорректная сумма!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Номер счёта: " + accountNumber);
            Console.WriteLine("Баланс: " + String.Format("{0:F2}", balance));
            Console.WriteLine("Тип счёта: " + accountType);
            Console.WriteLine();
        }
    }
}
