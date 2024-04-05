using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Week1
{
    public class Calculator : CalculatorBase
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public override int Subtract(int a, int b)
        {
            return a - b;
        }

        public override int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
