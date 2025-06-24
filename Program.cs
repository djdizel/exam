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
            Book book = new Book();
            book.SetTitle(new Title("Программирование на C#"));
            book.SetAuthor(new Author("Иван Иванов"));
            book.SetContent(new Content("Книга о программировании на C#."));
            book.Show();
        }
    }
}
