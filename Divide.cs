using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Divide:Calculator
    {
        public override void calculate()
        {
            if (b != 0)
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            else
                Console.WriteLine("除数不能为0");
        }
    }
}
