using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    abstract class AbstractState : IState
    {

        public abstract void NextInput(InputConsoleReader input);
        protected String MyConsoleReadLine() {
            String car=Console.ReadLine();
            if (car.Equals("c"))
            {
                Console.WriteLine("Ci vediamo tra qualche giorno");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
                
            return car;
        }        
    }
}
