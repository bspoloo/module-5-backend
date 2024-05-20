using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1
{
    public class Dictionaries
    {
        public Dictionary<int, string> students;
        public Dictionaries()
        {
            students = new Dictionary<int, string>();
            students.Add(1, "John");
            students.Add(2, "Jane");
            students.Add(3, "Doe");
            students.Add(4, "Smith");
            students.Add(5, "Alex");
            
        }
        public void printKeys()
        {
            foreach (int i in students.Keys)
            {
                Console.WriteLine(i);
            }
        }
        public void printUpdateStudents()
        {
            students.Remove(1);
            students.Add(8, "Pepe");
        }
        public void printStudents()
        {
            foreach (KeyValuePair<int, string> i in students)
            {
                Console.WriteLine(i);
            }
        }
    }
}
