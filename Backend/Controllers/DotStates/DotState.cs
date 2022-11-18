using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DotStates
{
    public interface DotState
    {
        /// <summary>
        /// Press C, CE, +, -, *, / will all set Num back to zero.
        /// </summary>
        void NullifyNum();

        /// <summary>
        /// Press Backward: delete single decimal.
        /// </summary>
        void Backward();

        /// <summary>
        /// Press Dot.
        /// </summary>
        void PressDot();
    }
}
