using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCase
{
    public class WaterChecker:Student
    {
        public void Water_Checker()
        {
            if (waterLevel < minWaterLevel)
            {
                Drink();
            }
        }
        public void Drink()
        {
            waterLevel = maxWaterLevel;
        }
    }
}