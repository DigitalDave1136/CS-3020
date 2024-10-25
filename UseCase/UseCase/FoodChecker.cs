using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCase
{
    public class FoodChecker : Student
    {
        public void Food_Checker()
        {
            if (foodLevel < minFoodLevel)
            {
                Eat();
            }
        }
        public void Eat()
        {
            foodLevel = maxFoodLevel;
        }
    }
}