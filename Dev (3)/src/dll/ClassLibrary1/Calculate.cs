using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Calculate
{
    public class Calculate
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public int MyPlus(int a, int b)
        {
            return a + b + 2000;
        }

        public int MyCalc(int a, int b)
        {
            if (a >= b)
            {
                return a + b;
            }
            else
            {
                return a - b;
            }
        }
    }
}
