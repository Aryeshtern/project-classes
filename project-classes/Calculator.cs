using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_classes
{
    public class Calculator
    {

        internal static int Add(int x, int y)
        {
            return x + y;
        }

        
    }

    public class MathOperations 
    {
        
        public int AddNumber(int x, int y)
        {
            return Calculator.Add(x, y);
        }
    }
}
