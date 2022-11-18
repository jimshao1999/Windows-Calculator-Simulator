using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.NPStates;

namespace Calculator.ShowingNumberStates
{
    public class ShowingNumberZeroState : ShowingNumberState
    {
        public Calculator Calculator;

        public ShowingNumberZeroState(Calculator Calculator)
        {
            this.Calculator = Calculator;
        }
        public void AddDot()
        {
            this.Calculator.ShowingNumber = "0.";
            this.Calculator.ChangeNPState(new PositiveNPState(this.Calculator));
            this.Calculator.ChangeShowingNumberState( new ShowingNumberOneDotState(this.Calculator));
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void AddNumber(string number)
        {
            this.Calculator.ShowingNumber = number;
            this.Calculator.ChangeNPState(new PositiveNPState(this.Calculator));
            this.Calculator.ChangeShowingNumberState(new ShowingNumberOneState(this.Calculator));
            this.Calculator.BackSpaces.Push(this.Calculator.ShowingNumberState);
        }

        public void Backward()
        {
        }

        public void NullifyNumber()
        {
        }

        public void AddZero()
        {
            this.Calculator.ShowingNumber = "0";
        }
    }
}
