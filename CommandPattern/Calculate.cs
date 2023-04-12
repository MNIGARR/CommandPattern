using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Calculate : Operation
    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine(result);
        }
        public void Minus(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine(result);
        }
        public void Divide(double num1, double num2)
        {
            double result = num1 / num2;
            if (num2 == 0)
                Console.WriteLine("Zero division is invalid ");
            else
                Console.WriteLine(result);
        }
        public void Multiple(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine(result);
        }
        public void Operation(double num1, double num2)
        {
            throw new NotImplementedException();
        }
    }
}
