using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1.Application
{
    public class Library
    {
        Dictionary<string, List<Book>> books;
        public Library(){
            books = new Dictionary<string, List<Book>>();
        }
        public void addBook(string genre, Book book)
        {
            if (books.ContainsKey(genre))
            {
                books[genre].Add(book);
            }
            else
            {
                books.Add(genre, new List<Book>() { book });
            }
        }
        public void removeByTitle(string title)
        {
            foreach (KeyValuePair<string, List<Book>> genre in books)
            {
                foreach (Book book in genre.Value)
                {
                    if (book.Title == title)
                    {
                        genre.Value.Remove(book);

                        Console.WriteLine("Book removed");
                        return;
                    }
                }
            }
        }
        public void printLibrary()
        {
            Console.WriteLine("#################################################################");
            foreach (KeyValuePair<string, List<Book>> genre in books)
            {
                Console.WriteLine(genre.Key);
                foreach (Book book in genre.Value)
                {
                    Console.WriteLine(book.Title);
                }
            }
            Console.WriteLine("#################################################################");
        }
        public List<Book> GetBooksByGenre(string genre)
        {
            if (books.ContainsKey(genre))
            {
                return new List<Book>(books[genre]);
            }
            return new List<Book>();
        }

        public Dictionary<string, List<Book>> GetAllBooks()
        {
            return new Dictionary<string, List<Book>>(books);
        }
    }
}
