using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии
Про".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
форматах доступно в версии Эксперт".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите
соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в
новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если
пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр
базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр
соответствующей версии класса, приведенный к базовому - DocumentWorker.
*/

namespace _04Document
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker;
            Console.WriteLine("Введите ключ или нажмите Enter если у вас его нет");
            string userKey = Console.ReadLine();
            if (Array.IndexOf(Utils.proKeys, userKey) != -1)
            {
                worker = new ProDocumentWorker();
            }
            else if (Array.IndexOf(Utils.expertKeys, userKey) != -1)
            {
                worker = new ExpertDocumentWorker();
            }
            else worker = new DocumentWorker();

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }

    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт...");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }


    static class Utils
    {
        public const string DELIMITER = "+===============================+";

        public static string[] proKeys =
        {
            "qwe",
            "rty",
            "uio"
        };

        public static string[] expertKeys =
        {
            "asdfg",
            "zxcvb"
        };
    }
}
