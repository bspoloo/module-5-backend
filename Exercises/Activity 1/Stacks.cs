using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1
{
    public class Stacks
    {
        public Stack<string> books;
        public Stacks()
        {
            books = new Stack<string>();

        }
        public void pushBooks()
        {
            books.Push("Book6");
            books.Push("Book7");
            books.Push("Book8");
            books.Push("Book9");
            books.Push("Book10");
        }
        public void removeTwoBooks()
        {
            books.Pop();
            books.Pop();
        }
        public void printStack()
        {
            foreach (string i in books)
            {
                Console.WriteLine(i);
            }
        }
 
    }
}
