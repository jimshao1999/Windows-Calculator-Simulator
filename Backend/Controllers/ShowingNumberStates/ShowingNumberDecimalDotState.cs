using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ShowingNumberStates
{
    class ShowingNumberDecimalDotState : ShowingNumberState
    {
        public Calculator Calculator;

        public ShowingNumberDecimalDotState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void AddDot()
        {
            // this.Calculator.ShowingNumber = string.Concat(this.Calculator.ShowingNumber, ".");
            // this.Calculator.ChangeShowingNumberState(new ShowingNumberDecimalState(this.Calculator));
            // this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void AddNumber(string number)
        {
            this.Calculator.ShowingNumber = string.Concat(this.Calculator.ShowingNumber, number);
            this.Calculator.ChangeShowingNumberState(new ShowingNumberDecimalState(this.Calculator));
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void Backward()
        {
            this.Calculator.ShowingNumber = this.Calculator.ShowingNumber.Substring(0, this.Calculator.ShowingNumber.Length - 1);
            this.Calculator.CalculatorDotState.Backward();
            this.Calculator.BackSpaces.Pop();
            this.Calculator.ChangeShowingNumberState(this.Calculator.BackSpaces.Peek());
        }

        public void NullifyNumber()
        {
            this.Calculator.ShowingNumber = "0";
            this.Calculator.BackSpaces = new Stack<ShowingNumberState>();
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
            this.Calculator.ChangeShowingNumberState(new ShowingNumberZeroState(this.Calculator));
        }

        public void AddZero()
        {
            AddNumber("0");
        }
    }
}
