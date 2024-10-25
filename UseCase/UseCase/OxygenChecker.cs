using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCase
{
    public class OxygenChecker:Student
    {
        public void Oxygen_Checker()
        {
            if (oxygenLevel < minOxygenLevel)
            {
                Breath();
            }
        }
        public void Breath()
        {
            oxygenLevel = maxOxygenLevel;
        }
    }
}