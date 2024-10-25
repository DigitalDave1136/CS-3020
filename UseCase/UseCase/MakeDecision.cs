using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCase
{
    public class MakeDecision:Student
    {
        public string option;
        public void DecisionMaker()
        {
            if (timeElapsed % 2400 == 0)
            {
                decision = option;
            }
        }
    }
}