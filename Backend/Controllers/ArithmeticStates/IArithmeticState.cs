using Calculator.ICalculateStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ArithmeticStates
{
    public interface IArithmeticState
    {
        void AddOperator(ICalculateStrategy CalculateStrategy);

        void AddNumber();

        void CalculateResult();

        void AddParenthesis();

        void CloseParenthesis();
    }
}
