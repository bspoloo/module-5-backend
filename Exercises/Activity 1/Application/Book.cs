using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1.Application
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }
    }
}
