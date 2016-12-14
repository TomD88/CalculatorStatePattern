using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class MyMat
    {
        public double Calculate(string operatore, double number1, double number2)
        {
            if ("+".Equals(operatore))
            {
                return number1 + number2;
            }
            if ("*".Equals(operatore))
            {
                return number1 * number2;
            }
            if ("-".Equals(operatore))
            {
                return number1 - number2;
            }
           // if ("/".Equals(operatore))
            //{
                return number1 / number2;
            //}
        }
    }
}
