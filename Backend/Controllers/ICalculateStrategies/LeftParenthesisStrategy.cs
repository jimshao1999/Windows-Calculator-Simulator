using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculateStrategies
{
    class LeftParenthesisStrategy : ICalculateStrategy
    {
        public string ShowOperator()
        {
            return "(";
        }

        public decimal CalculateResult(decimal Num1, decimal Num2)
        {
            return 0;
        }

        public int ShowPriority()
        {
            return 0;
        }

        public void InsertTreeStack(Calculator calculator)
        {
            calculator.ArithmeticTree.AddLeftPar();
        }
    }
}
