using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ResultText
    {
        public string ShowingNumber;
        public string ShowingFormula;
        public string ShowingPreOrder;
        public string ShowingInOrder;
        public string ShowingPostOrder;

        public ResultText()
        {
            this.ShowingNumber = "0";
            this.ShowingFormula = "";
            this.ShowingPreOrder = "";
            this.ShowingInOrder = "";
            this.ShowingPostOrder = "";
        }

        public ResultText(ResultText resultText)
        {
            this.ShowingNumber = resultText.ShowingNumber;
            this.ShowingFormula = resultText.ShowingFormula;
            this.ShowingPreOrder = resultText.ShowingPreOrder;
            this.ShowingInOrder = resultText.ShowingInOrder;
            this.ShowingPostOrder = resultText.ShowingPostOrder;
        }
    }
}
