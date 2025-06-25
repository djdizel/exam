using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Модель: " + model);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
        }
    }
}
