using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public   class  Calculator
    {
       public  double a, b;
        public char c;
        public double  A 
        { 
            get { return a;} 
            set { a = value;} 
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public  virtual void calculate()
        {
            Console.WriteLine("计算");
        }
    }
}
