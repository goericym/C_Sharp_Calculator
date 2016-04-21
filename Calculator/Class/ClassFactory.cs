using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ClassFactory
    {

        public abstractClass CreateFactory(string Oper)
        {
            abstractClass _oFactory = null;
            switch (Oper)
            {
                case "+":
                    _oFactory = new ClassPlus();
                    break;
                case "-":
                    _oFactory = new ClassMinus();
                    break;
                case "*":
                    _oFactory = new ClassMultiply();
                    break;
                case "/":
                    _oFactory = new ClassDivid();
                    break;
            }
            return _oFactory;
        }

    }
}
