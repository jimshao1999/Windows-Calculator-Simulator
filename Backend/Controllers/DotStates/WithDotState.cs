using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotStates
{
    class WithDotState : DotState
    {

        public Calculator Calculator;

        public WithDotState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void Backward()
        {
            this.Calculator.ChangeDotState(new WithoutDotState(this.Calculator));
        }

        public void NullifyNum()
        {
            this.Calculator.ChangeDotState(new WithoutDotState(this.Calculator));
        }

        public void PressDot()
        {

        }
    }
}
