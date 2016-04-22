using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ClassEqu
    {
        public double dResult;
        public ClassEqu(double V1, double V2, string Oper)
        {
            ClassFactory doubleRes = new ClassFactory();
            abstractClass ac = doubleRes.CreateFactory(Oper);
            dResult = ac.Result(V1, V2);
        }

    }
}
