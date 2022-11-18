using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;
using Calculator.ParenthesisStates;

namespace Calculator.ArithmeticStates
{
    class PEmptyArithmeticState : IArithmeticState
    {
        public Calculator Calculator;

        public PEmptyArithmeticState(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void AddOperator(ICalculateStrategy CalculateStrategy)
        {
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.CalculateStrategy = CalculateStrategy;
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.FirstNumber.ToString() + " " + CalculateStrategy.ShowOperator();
            this.Calculator.ChangeArithmeticState(new OperatorState(this.Calculator));
        }

        public void AddNumber()
        {
        }

        public void CalculateResult()
        {
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ShowingNumber = this.Calculator.ArithmeticTree.AddEquals().ToString();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + this.Calculator.ShowingNumber + " =";
        }

        public void AddParenthesis()
        {
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + "(";
            this.Calculator.ArithmeticTree.AddLeftPar();
            this.Calculator.ParenthesisStrategyStack.Push(new DoCloseParenthesisStrategy(this.Calculator));
            this.Calculator.ChangeArithmeticState(new PEmptyArithmeticState(this.Calculator));
        }

        public void CloseParenthesis()
        {
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.ShowingNumber + " )";
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ArithmeticTree.AddRightPar();
            this.Calculator.ChangeArithmeticState(new PCloseState(this.Calculator));
            // this.Calculator.ShowingNumber = "Invalid Move! Press C to Restart.";
        }
    }
}
