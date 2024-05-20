using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1.Application
{
    public class Application
    {

            public Library library;
            public Application()
            {
                library = new Library();
            }

            public void Run()
            {
                printMenu();
            }
            public void printMenu()
            {
                while (true)
                {
                    Console.WriteLine("\nLibrary Management System");
                    Console.WriteLine("1. Add a new book to a specified genre");
                    Console.WriteLine("2. Remove a book by title from a specified genre");
                    Console.WriteLine("3. List all books in a specified genre");
                    Console.WriteLine("4. List all books in the library, grouped by genre");
                    Console.WriteLine("5. Exit");
                    Console.Write("Select an option: ");

                    int option;
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        switch (option)
                        {
                            case 1:
                                AddBook(library);
                                library.printLibrary();
                                break;
                            case 2:
                                RemoveBookByTitle(library);
                                library.printLibrary();

                                break;
                            case 3:
                                ListBooksInGenre(library);
                                library.printLibrary();
                                break;
                            case 4:
                                ListAllBooks(library);
                                library.printLibrary();
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }

            public void AddBook(Library library)
            {
                Console.Write("Enter genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                Console.Write("Enter author: ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);
                library.addBook(genre, book);
                Console.WriteLine("Book added successfully.");
            }

            public void RemoveBookByTitle(Library library)
            {
                Console.Write("Enter genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter title: ");
                string title = Console.ReadLine();

                library.removeByTitle(title);

            }

            public void ListBooksInGenre(Library library)
            {
                Console.Write("Enter genre: ");
                string genre = Console.ReadLine();

                List<Book> books = library.GetBooksByGenre(genre);
                if (books.Count > 0)
                {
                    Console.WriteLine($"Books in {genre} genre:");
                    foreach (var book in books)
                    {
                        Console.WriteLine(book);
                    }
                }
                else
                {
                    Console.WriteLine("No books found in this genre.");
                }
            }

            public void ListAllBooks(Library library)
            {
                Dictionary<string, List<Book>> allBooks = library.GetAllBooks();
                if (allBooks.Count > 0)
                {
                    Console.WriteLine("All books in the library:");
                    foreach (var genre in allBooks.Keys)
                    {
                        Console.WriteLine($"\nGenre: {genre}");
                        foreach (var book in allBooks[genre])
                        {
                            Console.WriteLine(book);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No books in the library.");
                }
            }

        }
}

