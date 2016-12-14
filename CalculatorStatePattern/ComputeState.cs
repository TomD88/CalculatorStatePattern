using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class ComputeState : AbstractState
    {
        public override void NextInput(InputConsoleReader input)
        {
            double operando1 = input.Operando11;
            double operando2 = input.Operando22;
            string operatore = input.Operatore;

            Console.WriteLine("Sono pronto per fare il calcolo. Premi un tasto per calcolare");

            MyMat m = new MyMat();
            double result = m.Calculate(operatore, operando1, operando2);
            Console.WriteLine("Il risultato finale e' " + result.ToString());
            this.MyConsoleReadLine();

            input.State = new OperatorRequestState();

        }
    }
}
