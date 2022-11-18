using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.ArithmeticStates;
using Calculator.ICalculateStrategies;
using Calculator.NPStates;
using Calculator.ShowingNumberStates;
using Microsoft.AspNetCore.Mvc;

namespace Calculator
{
    public class CalculatorServices : ICalculatorServices
    {
        public AllCalculators AllCalculators;
        public ResultText ResultText;

        public CalculatorServices()
        {
            this.AllCalculators = new AllCalculators();
        }

        public void ResetShowingNumbers(string id)
        {
            this.AllCalculators.AllCalculator[id].ChangeShowingNumberState(new ShowingNumberZeroState(this.AllCalculators.AllCalculator[id]));
            this.AllCalculators.AllCalculator[id].BackSpaces = new Stack<ShowingNumberState>();
            this.AllCalculators.AllCalculator[id].BackSpaces.Push(this.AllCalculators.AllCalculator[id].ShowingNumberState);
            this.AllCalculators.AllCalculator[id].CalculatorDotState.NullifyNum();
        }

        public void SetResultText(string id)
        {
            this.ResultText = new ResultText(
                this.AllCalculators.AllCalculator[id].ShowingNumber,
                this.AllCalculators.AllCalculator[id].ShowingFormula,
                this.AllCalculators.AllCalculator[id].PreOrderString,
                this.AllCalculators.AllCalculator[id].InOrderString,
                this.AllCalculators.AllCalculator[id].PostOrderString);
        }

        public ActionResult<ResultText> AddDot(string id)
        {
            this.AllCalculators.AllCalculator[id].CalculatorDotState.PressDot();

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> AddNumbers(string id, string number)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddNumber();
            this.AllCalculators.AllCalculator[id].ShowingNumberState.AddNumber(number);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> AddZero(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddNumber();
            this.AllCalculators.AllCalculator[id].ShowingNumberState.AddZero();

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> ChangeNP(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddNumber();
            this.AllCalculators.AllCalculator[id].NPState.PressNP();

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> RemoveAllState(string id)
        {
            this.AllCalculators.AllCalculator[id].ShowingNumberState.NullifyNumber();
            this.AllCalculators.AllCalculator[id].CalculatorDotState.NullifyNum();
            this.AllCalculators.AllCalculator[id].ChangeNPState(new ZeroNPState(this.AllCalculators.AllCalculator[id]));
            this.AllCalculators.AllCalculator[id].BackSpaces = new Stack<ShowingNumberState>();
            this.AllCalculators.AllCalculator[id].BackSpaces.Push(this.AllCalculators.AllCalculator[id].ShowingNumberState);
            this.AllCalculators.AllCalculator[id].ArithmeticState = new EmptyArithmeticState(this.AllCalculators.AllCalculator[id]);

            this.AllCalculators.AllCalculator[id].ShowingNumber = "0";
            this.AllCalculators.AllCalculator[id].ShowingFormula = "";
            this.AllCalculators.AllCalculator[id].PreOrderString = "";
            this.AllCalculators.AllCalculator[id].InOrderString = "";
            this.AllCalculators.AllCalculator[id].PostOrderString = "";

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> DoSqrt(string id)
        {
            double res = Math.Sqrt(double.Parse(this.AllCalculators.AllCalculator[id].ShowingNumber));
            this.AllCalculators.AllCalculator[id].ShowingNumber = res.ToString();

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public string RegisterUser(string id)
        {
            this.AllCalculators.AllCalculator.Add(id, new Calculator());
            return id;
        }

        public ActionResult<ResultText> RemoveCurrentNumber(string id)
        {
            this.AllCalculators.AllCalculator[id].ShowingNumberState.NullifyNumber();
            this.AllCalculators.AllCalculator[id].CalculatorDotState.NullifyNum();
            this.AllCalculators.AllCalculator[id].ChangeNPState(new ZeroNPState(this.AllCalculators.AllCalculator[id]));
            this.AllCalculators.AllCalculator[id].BackSpaces = new Stack<ShowingNumberState>();
            this.AllCalculators.AllCalculator[id].BackSpaces.Push(this.AllCalculators.AllCalculator[id].ShowingNumberState);
            this.AllCalculators.AllCalculator[id].ShowingNumber = "0";

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> RemoveLastWord(string id)
        {
            this.AllCalculators.AllCalculator[id].ShowingNumberState.Backward();

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> AdditionOperation(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddOperator(new AdditionStrategy());

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> SubtractionOperation(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddOperator(new SubstractionStrategy());

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> TimesOperation(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddOperator(new MultiplicationStrategy());

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> DivisionOperation(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddOperator(new DivisionStrategy());

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> LeftParenthesis(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.AddParenthesis();

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> RightParenthesis(string id)
        {
            this.AllCalculators.AllCalculator[id].ParenthesisStrategyStack.Peek().CloseParenthesis();

            ResetShowingNumbers(id);
            SetResultText(id);
            return this.ResultText;
        }

        public ActionResult<ResultText> CalculateResult(string id)
        {
            this.AllCalculators.AllCalculator[id].ArithmeticState.CalculateResult();

            ResetShowingNumbers(id);

            SetResultText(id);
            return this.ResultText;
        }
    }
}
