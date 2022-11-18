using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ParenthesisStates
{
    class DoCloseParenthesisStrategy : IParenthesisStrategy
    {
        public Calculator Calculator;

        public DoCloseParenthesisStrategy(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void CloseParenthesis()
        {
            this.Calculator.ParenthesisStrategyStack.Pop();
            this.Calculator.ArithmeticState.CloseParenthesis();
        }
    }
}
