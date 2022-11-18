using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;
using Calculator.ParenthesisStates;

namespace Calculator.ArithmeticStates
{
    public class OperatorState : IArithmeticState
    {
        public Calculator Calculator;

        public OperatorState(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void AddOperator(ICalculateStrategy CalculateStrategy)
        {
            Console.WriteLine("Switching Operator");
            this.Calculator.CalculateStrategy = CalculateStrategy;
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula.Substring(0, this.Calculator.ShowingFormula.Length - 1);
            this.Calculator.ShowingFormula = string.Concat(this.Calculator.ShowingFormula, CalculateStrategy.ShowOperator());
        }

        public void AddNumber()
        {
            Console.WriteLine("Save Operator");
            this.Calculator.CalculateStrategy.InsertTreeStack(this.Calculator);
            this.Calculator.ChangeArithmeticState(new NumberState(this.Calculator));
        }

        public void CalculateResult()
        {
            Console.WriteLine("OperatorState CalculateResult");
            this.Calculator.ShowingNumber = this.Calculator.ArithmeticTree.AddEquals().ToString();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula.Substring(0, this.Calculator.ShowingFormula.Length - 1);
            this.Calculator.ShowingFormula = string.Concat(this.Calculator.ShowingFormula, "=");
            this.Calculator.ChangeArithmeticState(new EmptyArithmeticState(this.Calculator));
        }

        public void AddParenthesis()
        {
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + "(";
            this.Calculator.CalculateStrategy.InsertTreeStack(this.Calculator);
            this.Calculator.ArithmeticTree.AddLeftPar();
            this.Calculator.ParenthesisStrategyStack.Push(new DoCloseParenthesisStrategy(this.Calculator));
            this.Calculator.ChangeArithmeticState(new PEmptyArithmeticState(this.Calculator));
        }

        public void CloseParenthesis()
        {
            this.Calculator.ArithmeticTree.AddRightPar();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula.Substring(0, this.Calculator.ShowingFormula.Length - 1);
            this.Calculator.ShowingFormula = string.Concat(this.Calculator.ShowingFormula, ")");
            this.Calculator.ChangeArithmeticState(new PCloseState(this.Calculator));
        }
    }
}
