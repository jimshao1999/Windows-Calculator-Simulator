using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculator
{
    public interface ICalculatorServices
    {
        string RegisterUser(string id);
        ActionResult<ResultText> AddNumbers(string id, string number);
        ActionResult<ResultText> AddDot(string id);
        ActionResult<ResultText> AddZero(string id);
        ActionResult<ResultText> ChangeNP(string id);
        ActionResult<ResultText> DoSqrt(string id);
        ActionResult<ResultText> RemoveAllState(string id);
        ActionResult<ResultText> RemoveCurrentNumber(string id);
        ActionResult<ResultText> RemoveLastWord(string id);
        ActionResult<ResultText> AdditionOperation(string id);
        ActionResult<ResultText> SubtractionOperation(string id);
        ActionResult<ResultText> TimesOperation(string id);
        ActionResult<ResultText> DivisionOperation(string id);
        ActionResult<ResultText> LeftParenthesis(string id);
        ActionResult<ResultText> RightParenthesis(string id);
        ActionResult<ResultText> CalculateResult(string id);
    }
}
