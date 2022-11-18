using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculateStrategies
{
    public interface ICalculateStrategy
    {
        string ShowOperator();

        decimal CalculateResult(decimal Num1, decimal Num2);

        int ShowPriority();

        void InsertTreeStack(Calculator calculator);
    }
}
