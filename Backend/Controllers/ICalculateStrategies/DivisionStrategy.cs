using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculateStrategies
{
    public class DivisionStrategy : ICalculateStrategy
    {
        public string ShowOperator()
        {
            return "/";
        }

        public decimal CalculateResult(decimal Num1, decimal Num2)
        {
            decimal res;
            try
            {
                res = decimal.Round(Num1 / Num2, 5);
                return res;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public int ShowPriority()
        {
            return 2;
        }

        public void InsertTreeStack(Calculator calculator)
        {
            calculator.ArithmeticTree.AddDivision();
        }
    }
}
