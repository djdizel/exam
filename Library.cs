using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Library
    {
        private string title;
        private string author;
        private int year;

        public Library(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Год издания: " + year);
            Console.WriteLine();
        }

        public bool IsModern()
        {
            if (year > 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
