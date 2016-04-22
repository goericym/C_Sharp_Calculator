using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ClassDot
    {
        internal string Result(string sTemp)
        {
            if (sTemp=="")
            {
                sTemp = "0";
            }
            if (sTemp.IndexOf(".") > 0)
            {
                return sTemp;
            }
            else
            {
                return string.Format("{0}.",sTemp);
            }
        }
    }
}
