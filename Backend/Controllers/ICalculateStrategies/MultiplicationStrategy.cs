using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculateStrategies
{
    public class MultiplicationStrategy : ICalculateStrategy
    {
        public string ShowOperator()
        {
            return "*";
        }

        public decimal CalculateResult(decimal Num1, decimal Num2)
        {
            return Num1 * Num2;
        }

        public int ShowPriority()
        {
            return 2;
        }

        public void InsertTreeStack(Calculator calculator)
        {
            calculator.ArithmeticTree.AddMultiplication();
        }
    }
}
