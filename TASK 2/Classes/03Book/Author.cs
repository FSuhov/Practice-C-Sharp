using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Book
{
    class Author
    {
        private string bookAuthor;
        private static ConsoleColor textColor = ConsoleColor.Cyan;

        public Author(string _author)
        {
            this.bookAuthor = _author;
        }

        public void Show()
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(bookAuthor);
            Console.ResetColor();
        }
    }
}
