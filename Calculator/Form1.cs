using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public Calculator Calculator;

        /// For Debug
        private string s = "";

        public CalculatorForm()
        {
            InitializeComponent();

            Calculator = new Calculator();
            RegisterButtons();

            ResultText.Text = Calculator.ResultText.ShowingNumber;
            FormulaText.Text = Calculator.ResultText.ShowingFormula;

            PreOrderText.Text = Calculator.ResultText.ShowingPreOrder;
            InOrderText.Text = Calculator.ResultText.ShowingInOrder;
            PostOrderText.Text = Calculator.ResultText.ShowingPostOrder;
        }

        private void RegisterButtons()
        {
            Console.WriteLine(this.Calculator.UserID);
            ButtonOne.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=1";
            ButtonTwo.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=2";
            ButtonThree.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=3";
            ButtonFour.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=4";
            ButtonFive.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=5";
            ButtonSix.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=6";
            ButtonSeven.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=7";
            ButtonEight.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=8";
            ButtonNine.Tag = this.Calculator.URLBase + "AddNumbers?id=" + this.Calculator.UserID + "&number=9";
            ButtonZero.Tag = this.Calculator.URLBase + "AddZero?id=" + this.Calculator.UserID;
            ButtonC.Tag = this.Calculator.URLBase + "RemoveAllState?id=" + this.Calculator.UserID;
            ButtonCE.Tag = this.Calculator.URLBase + "RemoveCurrentNumber?id=" + this.Calculator.UserID;
            ButtonBackward.Tag = this.Calculator.URLBase + "RemoveLastWord?id=" + this.Calculator.UserID;
            ButtonDot.Tag = this.Calculator.URLBase + "AddDot?id=" + this.Calculator.UserID;
            ButtonNP.Tag = this.Calculator.URLBase + "ChangeNP?id=" + this.Calculator.UserID;
            ButtonAdd.Tag = this.Calculator.URLBase + "AdditionOperation?id=" + this.Calculator.UserID;
            ButtonMinus.Tag = this.Calculator.URLBase + "SubtractionOperation?id=" + this.Calculator.UserID;
            ButtonTimes.Tag = this.Calculator.URLBase + "TimesOperation?id=" + this.Calculator.UserID;
            ButtonDiv.Tag = this.Calculator.URLBase + "DivisionOperation?id=" + this.Calculator.UserID;
            ButtonEq.Tag = this.Calculator.URLBase + "CalculateResult?id=" + this.Calculator.UserID;
            ButtonSqrt.Tag = this.Calculator.URLBase + "DoSqrt?id=" + this.Calculator.UserID;
            LeftParenthesis.Tag = this.Calculator.URLBase + "LeftParenthesis?id=" + this.Calculator.UserID;
            RightParenthesis.Tag = this.Calculator.URLBase + "RightParenthesis?id=" + this.Calculator.UserID;
        }

        public async void ButtonOnclick(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // debug
            s += btn.Text;
            Console.WriteLine(s);

            string callingAPI = (string) btn.Tag;

            HttpResponseMessage res = await this.Calculator.Client.PostAsync(callingAPI, null);
            string resString = await res.Content.ReadAsStringAsync();
            this.Calculator.ResultText = JsonConvert.DeserializeObject<ResultText>(resString);

            ResultText.Text = Calculator.ResultText.ShowingNumber;
            FormulaText.Text = Calculator.ResultText.ShowingFormula;
            PreOrderText.Text = Calculator.ResultText.ShowingPreOrder;
            InOrderText.Text = Calculator.ResultText.ShowingInOrder;
            PostOrderText.Text = Calculator.ResultText.ShowingPostOrder;
        }
    }
}
