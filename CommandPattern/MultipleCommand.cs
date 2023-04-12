using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MultipleCommand : Operation
    {
        Calculate calculate = new();
        public MultipleCommand() { }
        public MultipleCommand(Calculate calc)
        {
            this.calculate = calc;
        }
        public void Operation(double a, double b)
        {
            calculate.Multiple(a, b);
        }


    }
}
