using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class OperatorRequestState : AbstractState
    {
        public override void NextInput(InputConsoleReader input)
        {
            string OperatoreInput;

            Console.WriteLine("*** CALCOLATRICE STATE PATTERN ***");
            Console.WriteLine("Inserisci un operatore tra (+,-,*,/)");
            OperatoreInput = this.MyConsoleReadLine();

            if (CheckOperator(OperatoreInput))
            {
                input.Operatore = OperatoreInput;
                input.State = new OperandRequestState();
            }
        }


        private bool CheckOperator(string operatore)
        {
            bool FlagOperator = true;

            if(operatore.Equals("+")||
               operatore.Equals("-") ||
               operatore.Equals("*") ||
               operatore.Equals("/"))
            {
                FlagOperator = true;
            }
            else
            {
                FlagOperator = false;
            }
            return FlagOperator;
        }
    }
}
