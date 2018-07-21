using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Book
{
    class Title
    {
        private string bookTitle;
        private static ConsoleColor textColor = ConsoleColor.Green;

        public Title(string _title)
        {
            this.bookTitle = _title;
        }

        public void Show()
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(bookTitle);
            Console.ResetColor();
        }
    }
}
