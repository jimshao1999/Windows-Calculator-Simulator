using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;
using Calculator.ParenthesisStates;

namespace Calculator.ArithmeticStates
{
    public class EmptyArithmeticState : IArithmeticState
    {
        public Calculator Calculator;

        public EmptyArithmeticState(Calculator calculator)
        {
            Console.WriteLine("Start Calculator");

            this.Calculator = calculator;
            this.Calculator.ParenthesisStrategyStack = new Stack<IParenthesisStrategy>();
            this.Calculator.ParenthesisStrategyStack.Push(new NotCloseParenthesisStrategy(this.Calculator));
            this.Calculator.ArithmeticTree = new TreeStructures.ArithmeticTree(this.Calculator);
        }

        public void AddOperator(ICalculateStrategy CalculateStrategy)
        {
            this.Calculator.PreOrderString = "";
            this.Calculator.InOrderString = "";
            this.Calculator.PostOrderString = "";

            Console.WriteLine("Empty State Append Number");

            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.CalculateStrategy = CalculateStrategy;
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ShowingFormula = this.Calculator.FirstNumber.ToString() + " " + CalculateStrategy.ShowOperator();
            this.Calculator.ChangeArithmeticState(new OperatorState(this.Calculator));
        }

        public void AddNumber()
        {
            this.Calculator.ShowingFormula = "";
            this.Calculator.PreOrderString = "";
            this.Calculator.InOrderString = "";
            this.Calculator.PostOrderString = "";
        }

        public void CalculateResult()
        {
            this.Calculator.FirstNumber = decimal.Parse(this.Calculator.ShowingNumber);
            this.Calculator.ArithmeticTree.AddNumber(this.Calculator.FirstNumber);
            this.Calculator.ShowingNumber = this.Calculator.ArithmeticTree.AddEquals().ToString();
            this.Calculator.ShowingFormula = this.Calculator.ShowingNumber + " =";
        }

        public void AddParenthesis()
        {
            this.Calculator.ShowingFormula = "(";
            this.Calculator.ArithmeticTree.AddLeftPar();
            this.Calculator.ParenthesisStrategyStack.Push(new DoCloseParenthesisStrategy(this.Calculator));
            this.Calculator.ChangeArithmeticState(new PEmptyArithmeticState(this.Calculator));
        }

        public void CloseParenthesis()
        {
            // no close in here
        }
    }
}
