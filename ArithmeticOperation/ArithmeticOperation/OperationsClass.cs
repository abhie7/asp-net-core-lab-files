using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    public class OperationsClass
    {
        public void RunOperations()
        {
            Console.WriteLine("Arithmetic Operations");
            int a = 20, b = 10;
            float sum = 0, sub = 0, mul = 0, div = 0;
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, sub);
            Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, mul);
            Console.WriteLine("Division of {0} and {1} is {2}", a, b, div);
        }
    }
}