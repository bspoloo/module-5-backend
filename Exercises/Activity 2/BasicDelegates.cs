using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_2
{
    public class BasicDelegates
    {
        delegate int MathOperation(int a, int b);

        public BasicDelegates()
        {

        }
        public int Add(int a, int b)
        {
            Console.WriteLine($"Add: {a} + {b} = {a + b}");
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            Console.WriteLine($"Subtract: {a} - {b} = {a - b}");
            return a - b;
        }
        public void Run()
        {
            MathOperation operation = Add;

            int addResult = operation(5, 5);
            Console.WriteLine($"The result add is: {addResult}");

            operation = Subtract;
            int subtractResult = operation(10, 5);
            Console.WriteLine($"The result subtraction is: {subtractResult}");
        }
    }
}
