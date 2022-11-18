using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NPStates
{
    public class NegativeNPState : NPState
    {
        public Calculator Calculator;

        public NegativeNPState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void PressNP()
        {
            this.Calculator.ShowingNumber = this.Calculator.ShowingNumber.Substring(1);
            this.Calculator.ChangeNPState(new PositiveNPState(this.Calculator));
        }
    }
}
