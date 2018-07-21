using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно
 * строковое поле и метод void Show().
 * Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
 * Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
*/

namespace _03Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            string title;
            string content;
            string author;

            while (true)
            {                
                Console.WriteLine("Enter title of the book");
                title = Console.ReadLine();
                Console.WriteLine("Enter author of the book");
                author = Console.ReadLine();
                Author authorInstance = new Author(author);                
                Console.WriteLine("Describe the content. Can be multiline. To stop the input enter -1 on the next line");
                content = RecordContent();
                Book book = new Book(title, content);
                book.SetAuthor(authorInstance);
                book.ShowBook();
                bookList.Add(book);
                Console.WriteLine("Press Escape to stop application or any other key to enter another book");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("You have entered the following books");
                    foreach(Book item in bookList)
                    {                        
                        item.ShowBook();                        
                    }
                    Console.WriteLine("Goodbye");
                    return;
                }
            }
        }

        public static string RecordContent()
        {
            StringBuilder content = new StringBuilder();
            int x = 0;
           
            while (x!=-1)
            {
                string userInput = Console.ReadLine();
                Int32.TryParse(userInput, out x);
                if(x!=-1)
                {
                    content.Append(userInput);
                    content.Append("\n");
                }
            }
            content.Remove(content.Length - 1, 1);
            return content.ToString();
        }


        public static string delimiter = "+======================+";
    }
}
