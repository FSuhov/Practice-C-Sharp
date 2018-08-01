using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using Microsoft.Office.Interop.Word;

/*
Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия,
создания, редактирования, сохранения определенного формата документа. 
*/

namespace _01AbstractFileHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt_path = "text.txt";
            string xml_path = "document.xml";
            string doc_path = @"D:\IT Step\C#\ISD TASKS\TASK 4\Abstractions\01AbstractFileHandler\bin\Debug\docum.doc";

            string path = txt_path;
            string extension = Path.GetExtension(path);

            AbstractHandler filehandler;

            switch (extension)
            {
                case ".txt":
                    filehandler = new TXTHandler();
                    filehandler.Create(path);
                    break;
                case ".xml":
                    filehandler = new XMLHandler();
                    filehandler.Create(path);
                    break;
                case ".doc":
                    filehandler = new DOCHandler();
                    filehandler.Create(path);
                    break;
                default:
                    break;
            }
        }

        
    }

    abstract class AbstractHandler
    {        
        public abstract void Open(string path);
        public abstract void Create(string path);
        public abstract void Change();
        public abstract void Save(string path, string data);
    }

    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            throw new NotImplementedException();
        }

        public override void Create(string path)
        {
            Save(path, "");
        }

        public override void Open(string path)
        {
            string data = "";
            try
            {
                data = File.ReadAllText(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(data);
        }

        public override void Save(string path, string data)
        {
            using (StreamWriter writer =  new StreamWriter(path))
            {
                writer.Write(data);
            }
        }
    }

    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            throw new NotImplementedException();
        }

        public override void Create(string path)
        {
            Save(path, "");
        }

        public override void Open(string path)
        {
            string data = "";
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    data += reader.Value;
                }
            }
            Console.WriteLine(data);
        }

        public override void Save(string path, string data)
        {
            using (XmlWriter writer = XmlWriter.Create(path))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DOCUMENT");

                writer.WriteElementString("Data", data);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            throw new NotImplementedException();
        }

        public override void Create(string path)
        {
            Save(path, "");
        }

        public override void Open(string path)
        {
            Application application = new Application();
            Document document = application.Documents.Open(path);
            StringBuilder data = new StringBuilder("");
            int count = document.Words.Count;
            for(int i = 1; i <=count; i++)
            {
                data.Append(document.Words[i].Text);
                data.Append(" ");
            }
            application.Quit();
            Console.WriteLine(data);
        }

        public override void Save(string path, string data)
        {
            object filename = path;
            object oMissing = System.Reflection.Missing.Value;
            object missing = System.Reflection.Missing.Value;
            Application application = new Application();
            Document document = application.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            document.Content.Text = data;
            document.SaveAs2(ref filename);
            application.Quit();
        }
    }
}
