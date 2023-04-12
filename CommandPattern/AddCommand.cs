using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class AddCommand : Operation
    {
        

        Calculate calculate = new();
        public AddCommand() { }
        public AddCommand(Calculate calc)
        {
            this.calculate = calc;
        }
        public void Operation(double a, double b)
        {
            calculate.Add(a, b);
        }

    }
}
