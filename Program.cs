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
            Console.Write("Введите количество книг: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Library[] books = new Library[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для книги " + (i + 1) + ":");
                Console.Write("Название: ");
                string title = Console.ReadLine();
                Console.Write("Автор: ");
                string author = Console.ReadLine();
                Console.Write("Год издания: ");
                int year = Convert.ToInt32(Console.ReadLine());

                books[i] = new Library(title, author, year);
            }

            Console.WriteLine("\nСовременные книги (изданы после 2000 года):");
            bool found = false;
            for (i = 0; i < n; i++)
            {
                if (books[i].IsModern())
                {
                    Console.WriteLine("Книга " + (i + 1) + ":");
                    books[i].ShowInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Современные книги не найдены.");
            }
        }
    }
}
