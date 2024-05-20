using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1
{
    public class Queues
    {
        public Queue<string> queue;
        public Queues()
        {
            queue = new Queue<string>();
            
        }
        public void Enqueue()
        {
            queue.Enqueue("John");
            queue.Enqueue("Jane");
            queue.Enqueue("Doe");
            queue.Enqueue("Smith");
            queue.Enqueue("Alex");
        }
        public void Dequeue()
        {
            queue.Dequeue();
            queue.Dequeue();
        }
        public void printQueue()
        {
            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
