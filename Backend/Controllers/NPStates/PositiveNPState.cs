using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NPStates
{
    public class PositiveNPState : NPState
    {
        public Calculator Calculator;

        public PositiveNPState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void PressNP()
        {
            this.Calculator.ShowingNumber = string.Concat("-", this.Calculator.ShowingNumber);
            this.Calculator.ChangeNPState(new NegativeNPState(this.Calculator));
        }
    }
}
