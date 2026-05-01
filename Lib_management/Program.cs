using System;
using System.Collections.Generic;

namespace Lib_management
{
    public class Book
    {
        public string Title { get; set; }
        public Book(string title)
        {
            Title = title;
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
            Console.WriteLine($"Added: {book.Title}");
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
    public void DisplayBooks()
        {
            Console.WriteLine("Books in library:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                if (input == "exit")
                {
                    break;
                }
                else if (input.StartsWith("add "))
                {
                    var title = input.Substring(4);
                    if (title == "")
                    {
                        Console.WriteLine("Title cannot be empty. Please try again.");
                        continue;
                    }
                    library.AddBook(new Book(title));
                }
                else if (input.StartsWith("remove "))
                {
                    var title = input.Substring(7);
                    library.removeBook(title);
                }
                else if (input == "display")
                {
                    library.DisplayBooks();
                }
                else
                {
                    Console.WriteLine("Unknown command. Use 'add <title>', 'remove <title>', 'display', or 'exit'.");
                }
            }
        }
    }
}

