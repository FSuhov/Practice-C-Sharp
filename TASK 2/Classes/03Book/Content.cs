using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Book
{
    class Content
    {
        private string bookContent;
        private static ConsoleColor textColor = ConsoleColor.Magenta;

        public Content(string _content)
        {
            this.bookContent = _content;
        }

        public void Show()
        {
            Console.WriteLine(Program.delimiter);
            Console.ForegroundColor = textColor;
            Console.WriteLine(bookContent);
            Console.ResetColor();
            Console.WriteLine(Program.delimiter);
        }
    }
}
