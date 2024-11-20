using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_book
{
    // Класс представляет книгу в библиотеке
    public class Book
    {
        // Уникальный идентификатор книги
        public string Id { get; set; }

        // Название книги
        public string Title { get; set; }

        // Автор книги
        public string Author { get; set; }

        // Год издания книги
        public int YearPublished { get; set; }

        // Переопределение метода ToString для удобного вывода информации о книге
        public override string ToString()
        {
            return $"ID: {Id}, Название: {Title}, Автор: {Author}, Год издания: {YearPublished}";
        }
    }
}
