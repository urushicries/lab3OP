using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    // Интерфейс для печати
    public interface IPrintable
    {
        void Print();
    }

    // Класс, представляющий документ
    public class Document : IPrintable
    {
        public string Content { get; set; }

        public Document(string content)
        {
            Content = content;
        }

        public void Print()
        {
            Console.WriteLine("Printing document: " + Content);
        }
    }

    // Класс, представляющий отчет
    public class Report : IPrintable
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Report(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public void Print()
        {
            Console.WriteLine("Printing report: " + Title);
            Console.WriteLine("Body: " + Body);
        }
    }



}
