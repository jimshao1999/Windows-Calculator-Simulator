using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.NPStates;

namespace Calculator.ShowingNumberStates
{
    class ShowingNumberOneState : ShowingNumberState
    {
        public Calculator Calculator;

        public ShowingNumberOneState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }

        public void AddDot()
        {
            this.Calculator.ShowingNumber = string.Concat(this.Calculator.ShowingNumber, ".");
            this.Calculator.ChangeShowingNumberState(new ShowingNumberDecimalDotState(this.Calculator));
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void AddNumber(string number)
        {
            this.Calculator.ShowingNumber = string.Concat(this.Calculator.ShowingNumber, number);
            this.Calculator.ChangeShowingNumberState(new ShowingNumberDecimalState(this.Calculator));
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void Backward()
        {
            this.Calculator.ChangeNPState(new ZeroNPState(this.Calculator));
            this.Calculator.ShowingNumber = "0";
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
