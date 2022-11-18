using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ParenthesisStates
{
    class NotCloseParenthesisStrategy : IParenthesisStrategy
    {
        public Calculator Calculator;

        public NotCloseParenthesisStrategy(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void CloseParenthesis()
        {
        }
    }
}
