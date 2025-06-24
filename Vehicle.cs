using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract class Vehicle
    {
        protected int x, y;
        protected double price;
        protected int speed;
        protected int year;

        public Vehicle(int x, int y, double price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Тип: " + GetType().Name);
            Console.WriteLine("Координаты: (" + x + ", " + y + ")");
            Console.WriteLine($"Цена: {price:F2}");
            Console.WriteLine("Скорость: " + speed + " км/ч");
            Console.WriteLine("Год выпуска: " + year);
        }
    }

}
