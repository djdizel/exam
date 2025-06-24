using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Book
    {
        private Title bookTitle;
        private Author bookAuthor;
        private Content bookContent;

        public void SetTitle(Title title)
        {
            bookTitle = title;
        }

        public void SetAuthor(Author author)
        {
            bookAuthor = author;
        }

        public void SetContent(Content content)
        {
            bookContent = content;
        }

        public void Show()
        {
            bookTitle?.Show();
            bookAuthor?.Show();
            bookContent?.Show();
        }
    }
}
