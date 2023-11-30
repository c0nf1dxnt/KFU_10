using System;
using System.Collections.Generic;
namespace Part2
{
    public delegate int BookComparison(Book book1, Book book2);
    public class ArrayOfBooks
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SortBooks(BookComparison comparison)
        {
            books.Sort((book1, book2) => comparison(book1, book2));
        }
        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.Write("\n");
        }
    }
}
