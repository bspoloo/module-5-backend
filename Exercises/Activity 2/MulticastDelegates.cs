using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_5_backend.Exercises.Activity_2
{
    public class MulticastDelegates
    {
        BasicDelegates basicDelegates;
        delegate int MathOperation(int a, int b);

        public MulticastDelegates()
        {
            basicDelegates = new BasicDelegates();
        }
        public void Run()
        {
            MathOperation operations = basicDelegates.Subtract;
            operations += basicDelegates.Add;

            int result = operations(10, 5);
            Console.WriteLine($"The result is: {result}");
        }

    }
}
