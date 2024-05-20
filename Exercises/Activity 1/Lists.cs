using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_1
{
    public class Lists
    {
        public List<int> list;
        public Lists()
        {
            list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
        }
        public List<int> printList() {

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            return list;
        }
        public List<int> printUpdatedList()
        {
            list.Remove(0);
            list.Remove(list.Count);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            return list;
        }

    }
}
