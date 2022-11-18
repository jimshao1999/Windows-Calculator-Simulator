using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator
{
    [Route("api/")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public ICalculatorServices CalculatorServices;

        public CalculatorController(ICalculatorServices CalculatorServices)
        {
            this.CalculatorServices = CalculatorServices;
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult<string> Register(string id)
        {
            return CalculatorServices.RegisterUser(id);
        }

        [HttpPost]
        [Route("AddNumbers")]
        public ActionResult<ResultText> AddNumbers(string id, string number)
        {
            return CalculatorServices.AddNumbers(id, number);
        }

        [HttpPost]
        [Route("AddDot")]
        public ActionResult<ResultText> AddDot(string id)
        {
            return CalculatorServices.AddDot(id);
        }

        [HttpPost]
        [Route("AddZero")]
        public ActionResult<ResultText> AddZero(string id)
        {
            return CalculatorServices.AddZero(id);
        }

        [HttpPost]
        [Route("ChangeNP")]
        public ActionResult<ResultText> ChangeNP(string id)
        {
            return CalculatorServices.ChangeNP(id);
        }

        [HttpPost]
        [Route("DoSqrt")]
        public ActionResult<ResultText> DoSqrt(string id)
        {
            return CalculatorServices.DoSqrt(id);
        }

        [HttpPost]
        [Route("RemoveAllState")]
        public ActionResult<ResultText> RemoveAllState(string id)
        {
            return CalculatorServices.RemoveAllState(id);
        }

        [HttpPost]
        [Route("RemoveCurrentNumber")]
        public ActionResult<ResultText> RemoveCurrentNumber(string id)
        {
            return CalculatorServices.RemoveCurrentNumber(id);
        }

        [HttpPost]
        [Route("RemoveLastWord")]
        public ActionResult<ResultText> RemoveLastWord(string id)
        {
            return CalculatorServices.RemoveLastWord(id);
        }

        [HttpPost]
        [Route("AdditionOperation")]
        public ActionResult<ResultText> AdditionOperation(string id)
        {
            return CalculatorServices.AdditionOperation(id);
        }

        [HttpPost]
        [Route("SubtractionOperation")]
        public ActionResult<ResultText> SubtractionOperation(string id)
        {
            return CalculatorServices.SubtractionOperation(id);
        }

        [HttpPost]
        [Route("TimesOperation")]
        public ActionResult<ResultText> TimesOperation(string id)
        {
            return CalculatorServices.TimesOperation(id);
        }

        [HttpPost]
        [Route("DivisionOperation")]
        public ActionResult<ResultText> DivisionOperation(string id)
        {
            return CalculatorServices.DivisionOperation(id);
        }

        [HttpPost]
        [Route("LeftParenthesis")]
        public ActionResult<ResultText> LeftParenthesis(string id)
        {
            return CalculatorServices.LeftParenthesis(id);
        }

        [HttpPost]
        [Route("RightParenthesis")]
        public ActionResult<ResultText> RightParenthesis(string id)
        {
            return CalculatorServices.RightParenthesis(id);
        }

        [HttpPost]
        [Route("CalculateResult")]
        public ActionResult<ResultText> CalculateResult(string id)
        {
            return CalculatorServices.CalculateResult(id);
        }
    }
}