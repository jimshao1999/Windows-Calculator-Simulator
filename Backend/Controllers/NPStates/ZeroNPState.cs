using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NPStates
{
    public class ZeroNPState : NPState
    {
        public Calculator Calculator;

        public ZeroNPState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void PressNP()
        {

        }
    }
}
