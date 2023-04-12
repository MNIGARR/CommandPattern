using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DivideCommand : Operation
    {
        Calculate calculate = new();

        public void Operation(double a, double b)
        {
            calculate.Divide(a, b);
        }
        public DivideCommand() { }
        public DivideCommand(Calculate calc)
        {
            this.calculate = calc;
        }

        
    }
}
