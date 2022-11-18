using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ShowingNumberStates
{
    /// <summary>
    /// State that controls Numbers to show on screen.
    /// </summary>
    public interface ShowingNumberState
    {
        void AddNumber(string number);
        void AddDot();
        void Backward();
        void NullifyNumber();
        void AddZero();
    }
}
