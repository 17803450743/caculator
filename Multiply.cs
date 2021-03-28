using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Multiply:Calculator
    {
        public override void calculate()
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        }
    }
}
