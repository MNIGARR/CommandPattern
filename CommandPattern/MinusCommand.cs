using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MinusCommand : Operation
    {
        Calculate calculate = new();
        public MinusCommand() { }
        public MinusCommand(Calculate calc)
        {
            this.calculate = calc;
        }
        public void Operation(double a, double b)
        {
            calculate.Minus(a, b);
        }
        
    }
}
