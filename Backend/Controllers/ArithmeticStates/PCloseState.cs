using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;

namespace Calculator.ArithmeticStates
{
    class PCloseState : IArithmeticState
    {
        public Calculator Calculator;

        public PCloseState(Calculator calculator)
        {
            this.Calculator = calculator;
        }

        public void AddOperator(ICalculateStrategy CalculateStrategy)
        {
            this.Calculator.CalculateStrategy = CalculateStrategy;
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " " + this.Calculator.CalculateStrategy.ShowOperator();
            this.Calculator.ChangeArithmeticState(new OperatorState(this.Calculator));
        }

        public void AddNumber()
        {
            // dont do anything
        }

        public void CalculateResult()
        {
            this.Calculator.ShowingNumber = this.Calculator.ArithmeticTree.AddEquals().ToString();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " =";
            this.Calculator.ChangeArithmeticState(new EmptyArithmeticState(this.Calculator));
        }

        public void AddParenthesis()
        {
            // dont move
            // this.Calculator.ShowingNumber = "Invalid Move. Press C to Reset.";
        }

        public void CloseParenthesis()
        {
            this.Calculator.ArithmeticTree.AddRightPar();
            this.Calculator.ShowingFormula = this.Calculator.ShowingFormula + " )";
            this.Calculator.ChangeArithmeticState(new PCloseState(this.Calculator));
        }
    }
}
