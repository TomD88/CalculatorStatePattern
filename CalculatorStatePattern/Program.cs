using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConsoleReader inputConsoleReader = 
                new InputConsoleReader();

            Console.WriteLine("Inizio del programma");

            while (true)
            {
                inputConsoleReader.NextInput();
            }
        }
    }
}
