using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStatePattern
{
    class InputConsoleReader
    {

        private double _operando1 = 0;
        private double _operando2 = 0;
        private string _operatore = "";
        private IState _state;


        internal IState State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        internal double Operando11
        {
            get
            {
                return _operando1;
            }

            set
            {
                _operando1 = value;
            }
        }

        internal double Operando22
        {
            get
            {
                return _operando2;
            }

            set
            {
                _operando2 = value;
            }
        }

        internal string Operatore
        {
            get
            {
                return _operatore;
            }

            set
            {
                _operatore = value;
            }
        }

        private OperatorRequestState operatorRequestState;


        public InputConsoleReader(IState state) {
            State = state;
        }

        public InputConsoleReader()
        {
            State = new OperatorRequestState();
        }

        public void NextInput()
        {
            State.NextInput(this);
        }

    }
}
