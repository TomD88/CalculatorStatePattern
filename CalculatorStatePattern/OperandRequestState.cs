using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class OperandRequestState : AbstractState
    {
        double OperandoA = 0;
        double OperandoB = 0;
        bool OperandoAAssegnato = false;
        bool OperandoBAssegnato = false;
        
        public override void NextInput(InputConsoleReader input)
        {
            if (!OperandoAAssegnato)
            {
                getOperandoAFromInput(input);
            }
            else
            {
                getOperandoBFromInput(input);
            }
        }

        private void getOperandoAFromInput(InputConsoleReader input)
        {
            try
            {
                Console.WriteLine("Inserisci l'operando A:");
                OperandoA = double.Parse(this.MyConsoleReadLine());
                OperandoAAssegnato = true;
                input.Operando11 = OperandoA;
            }
            catch (Exception)
            {
                Console.WriteLine("Errore: Hai inserito l'operando A errato");    
            }           
        }

        private void getOperandoBFromInput(InputConsoleReader input)
        {
            try
            {
                Console.WriteLine("Inserisci l'operando B:");
                OperandoB = double.Parse(this.MyConsoleReadLine());
                OperandoBAssegnato = true;
                input.Operando22 = OperandoB;
                input.State = new ComputeState();
            }
            catch (Exception)
            {
                Console.WriteLine("Errore: Hai inserito l'operando B errato");
            }
        }
    }
}
