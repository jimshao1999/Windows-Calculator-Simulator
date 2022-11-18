using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;
using Calculator.ParenthesisStates;

namespace Calculator.ArithmeticStates
{
    public class NumberState : IArithmeticState
    {
        public Calculator Calculator;

        public NumberState(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void AddOperator(ICalculateStrategy CalculateStrategy)
        {
            Console.WriteLine("NumberState Save Number");
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.CalculateStrategy = CalculateStrategy;
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.ShowingNumber + " " + this.Calculator.CalculateStrategy.ShowOperator();
            this.Calculator.ChangeArithmeticState(new OperatorState(this.Calculator));
        }

        public void AddNumber()
        {
        }

        public void CalculateResult()
        {
            Console.WriteLine("NumberState Calculate Result");
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.ShowingNumber + " =";
            this.Calculator.ShowingNumber = this.Calculator.ArithmeticTree.AddEquals().ToString();
            this.Calculator.ChangeArithmeticState(new EmptyArithmeticState(this.Calculator));
        }

        public void AddParenthesis()
        {
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula +  " (";
            this.Calculator.ArithmeticTree.AddLeftPar();
            this.Calculator.ParenthesisStrategyStack.Push(new DoCloseParenthesisStrategy(this.Calculator));
            this.Calculator.ChangeArithmeticState(new PEmptyArithmeticState(this.Calculator));
        }

        public void CloseParenthesis()
        {
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ArithmeticTree.AddRightPar();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.ShowingNumber + " )";
            this.Calculator.ChangeArithmeticState(new PCloseState(this.Calculator));
        }
    }
}
