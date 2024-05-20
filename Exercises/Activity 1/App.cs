using module_5_backend.Exercises.Activity_1;
using module_5_backend.Exercises.Activity_1.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this is the main of the game

namespace Ship_Shooting_Game
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Excerise 1: ");

            Lists integers = new Lists();
            Console.WriteLine("Print the list elements to the console: ");
            integers.printList();
            Console.WriteLine("Remove the first and last elements from the list: ");
            integers.printUpdatedList();

            Console.WriteLine("Excerise 2: ");

            Dictionaries students = new Dictionaries();
            Console.WriteLine("Print the keys of the dictionary to the console: ");
            students.printKeys();
            Console.WriteLine("Remove the first element and add a new element to the dictionary: ");
            students.printUpdateStudents();
            students.printStudents();

            Console.WriteLine("Excerise 3: ");
            Queues customers = new Queues();
            Console.WriteLine("Add elements to the queue: ");
            customers.Enqueue();
            customers.printQueue();
            Console.WriteLine("Remove the first two elements from the queue: ");
            customers.Dequeue();
            customers.printQueue();

            Console.WriteLine("Excerise 4: ");
            Stacks books = new Stacks();
            Console.WriteLine("Add elements to the stack: ");
            books.pushBooks();
            books.printStack();
            Console.WriteLine("Remove the last two elements from the stack: ");
            books.removeTwoBooks();
            books.printStack();


            Console.WriteLine("Excerise 5: ");
            Console.WriteLine("Application: ");
            Application app = new Application();
            app.Run();

        }
    }
}