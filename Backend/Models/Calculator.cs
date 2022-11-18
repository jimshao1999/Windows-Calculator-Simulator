using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.DotStates;
using Calculator.ShowingNumberStates;
using Calculator.NPStates;
using Calculator.ICalculateStrategies;
using Calculator.ArithmeticStates;
using Calculator.TreeStructures;
using Calculator.ParenthesisStates;

namespace Calculator
{
    public class Calculator
    {
        public DotState CalculatorDotState;
        public ShowingNumberState ShowingNumberState;
        public NPState NPState;
        public Stack<ShowingNumberState> BackSpaces;
        public decimal FirstNumber;
        public string Operator;
        public ICalculateStrategy CalculateStrategy;
        public IArithmeticState ArithmeticState;

        // for parenthesis
        public Stack<IParenthesisStrategy> ParenthesisStrategyStack;

        // for tree
        public ArithmeticTree ArithmeticTree;
        public string PreOrderString;
        public string InOrderString;
        public string PostOrderString;

        public string ShowingNumber;
        public string ShowingFormula;

        public void ChangeDotState(DotState dot_state)
        {
            this.CalculatorDotState = dot_state;
        }

        public void ChangeShowingNumberState(ShowingNumberState showing_umber_state)
        {
            this.ShowingNumberState = showing_umber_state;
        }

        public void ChangeNPState(NPState npstate)
        {
            this.NPState = npstate;
        }

        public void ChangeArithmeticState(IArithmeticState arithmetic_state)
        {
            this.ArithmeticState = arithmetic_state;
        }

        public Calculator()
        {
            // InitializeDotState
            this.CalculatorDotState = new WithoutDotState(this);

            // InitializeShowingNumberState
            this.ShowingNumberState = new ShowingNumberZeroState(this);
            this.ShowingNumber = "0";

            // Initialize NPState
            this.NPState = new ZeroNPState(this);

            // Initialize BackSpace List
            this.BackSpaces = new Stack<ShowingNumberState>();
            this.BackSpaces.Push(this.ShowingNumberState);

            // Initialize Calculation State
            this.ArithmeticState = new EmptyArithmeticState(this);

            // Initialize Tree State
            this.ArithmeticTree = new ArithmeticTree(this);

            this.FirstNumber = 0;
            this.ShowingFormula = "";
            this.PreOrderString = "";
            this.InOrderString = "";
            this.PostOrderString = "";
        }
    }
}
