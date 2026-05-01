using System;
using System.Collections.Generic;

namespace Lib_management
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
    public class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added: {book.Title} by {book.Author}");
        }

        public void removeBook(string title)
        {
            var bookToRemove = books.Find(b => b.Title == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Removed: " + bookToRemove.Title);
            }
            else
            {
                Console.WriteLine($"Book with title '{title}' not found.");

            }
        }

    public static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.removeBook("To Kill a Mockingbird");
        }
    }
}

