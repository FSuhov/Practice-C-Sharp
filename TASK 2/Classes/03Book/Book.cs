using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Book
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string _title, string _content)
        {
            this.title = new Title(_title);
            this.content = new Content(_content);
        }      

        public void SetAuthor(Author _author)
        {
            this.author = _author;
        }

        public void ShowBook()
        {
            if(title!=null && author!=null && content != null)
            {
                title.Show();
                author.Show();
                content.Show();
            }
            else Console.WriteLine("По данной книге не внесены все необходимые данные");
        }
    }
}
