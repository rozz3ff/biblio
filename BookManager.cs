using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_book
{
    // Класс управляет коллекцией книг
    public class BookManager
    {
        // Список книг в библиотеке
        public List<Book> Books { get; private set; }

        // Конструктор инициализирует пустой список книг
        public BookManager()
        {
            Books = new List<Book>();
        }

        // Метод добавляет книгу в список
        public void AddBook(Book book)
        {
            if (book == null) // Проверка, что книга не null
                throw new ArgumentNullException(nameof(book), "Книга не может быть null.");

            if (Books.Exists(b => b.Id == book.Id)) // Проверка, что ID книги уникален
                throw new InvalidOperationException($"Книга с ID {book.Id} уже существует.");

            Books.Add(book); // Добавление книги в список
        }

        // Метод удаляет книгу по её ID
        public void RemoveBook(string bookId)
        {
            var book = GetBook(bookId); // Поиск книги по ID
            if (book == null) // Проверка, что книга существует
                throw new KeyNotFoundException($"Книга с ID {bookId} не найдена.");

            Books.Remove(book); // Удаление книги из списка
        }

        // Метод возвращает книгу по её ID
        public Book GetBook(string bookId)
        {
            return Books.Find(b => b.Id == bookId); // Поиск книги по ID
        }

        // Метод возвращает список всех книг
        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
}
