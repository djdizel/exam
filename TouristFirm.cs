using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class TouristFirm
    {
        private string name;
        private int year;
        private string inn;
        private double profit;

        public TouristFirm(string name, int year, string inn, double profit)
        {
            this.name = name;
            this.year = year;
            this.inn = inn;
            this.profit = profit;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Год создания: " + year);
            Console.WriteLine("ИНН: " + inn);
            Console.WriteLine("Прибыль: " + String.Format("{0:F2}", profit));
            Console.WriteLine();
        }

        public string Name
        {
            get { return name; }
        }

        public string INN
        {
            get { return inn; }
        }

        public double Profit
        {
            get { return profit; }
        }
    }
}
