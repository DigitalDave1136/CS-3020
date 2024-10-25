using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCase
{
    public class Timer:Student
    {
        public void Update()
        {
            timeElapsed += 1;
        }
    }
}