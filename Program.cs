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
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            MyString myString1 = new MyString(str1);

            Console.Write("Введите вторую строку для объединения: ");
            string str2 = Console.ReadLine();
            MyString myString2 = new MyString(str2);

            Console.WriteLine("Объединённая строка: " + myString1.Concatenate(myString2));

            Console.Write("Введите подстроку для поиска: ");
            string substring = Console.ReadLine();
            int pos = myString1.FindSubstring(substring);
            if (pos != -1)
            {
                Console.WriteLine("Подстрока найдена на позиции: " + pos);
            }
            else
            {
                Console.WriteLine("Подстрока не найдена");
            }

            Console.Write("Введите подстроку для замены: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Введите новую подстроку: ");
            string newSubstring = Console.ReadLine();
            Console.WriteLine("Результат замены: " + myString1.ReplaceSubstring(oldSubstring, newSubstring));
        }
    }
}
