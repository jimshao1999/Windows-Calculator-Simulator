using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class AllCalculators
    {
        public Dictionary<string, Calculator> AllCalculator;
        
        public AllCalculators()
        {
            AllCalculator = new Dictionary<string, Calculator>();
        }


    }
}
