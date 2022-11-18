using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotStates
{
    class WithoutDotState : DotState
    {

        public Calculator Calculator;

        public WithoutDotState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void Backward()
        {
            
        }

        public void NullifyNum()
        {
            
        }

        public void PressDot()
        {
            this.Calculator.ArithmeticState.AddNumber();
            this.Calculator.ShowingNumberState.AddDot();
            this.Calculator.ChangeDotState(new WithDotState(this.Calculator));
        }
    }
}
