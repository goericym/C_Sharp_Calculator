using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ClassDivid : abstractClassDivid
    {
        internal override double Result(double x, double y)
        {
            if (y == 0)
            {
                return double.MaxValue;
            }
            return x / y;
        }
    }
}
