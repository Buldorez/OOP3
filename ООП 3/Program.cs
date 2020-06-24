using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Чтец", "Бернхард Шлинк", 224,  true);
            book1.outText();
            Console.ReadLine();
        }
        class Book
        {
            string author;
            string name;
            int str;
            bool collection;
            public Book(string bookName, string bookAuthor, int bookStr, bool bookCollection)
            {
                name = bookName;
                author = bookAuthor;
                str = bookStr;
                collection = bookCollection;
            }
            public Book(string bookName, string bookAuthor, int bookStr)
            {
                name = bookName;
                author = bookAuthor;
                str = bookStr;
                collection = false;
            }
            public Book(string bookName, int bookStr)
            {
                name = bookName;
                author = "Неизвестен";
                str = bookStr;
                collection = false;
            }
            public void outText()
            {
                Console.WriteLine($"Книга: {name}");
                Console.WriteLine($"Автор: {author}");
                Console.WriteLine($"Количество страниц: {str}");
                Console.WriteLine($"Коллекционное издание: {((collection) ? "Да" : "Нет")}");
            }
        }

    }
}
