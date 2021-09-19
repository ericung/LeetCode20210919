using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Problem01
{
    public class NumberSwapper
    {
        public void Swap(ref int numberA, ref int numberB)
        {
            numberA = numberA + numberB;
            numberB = numberA - numberB;
            numberA = numberA - numberB;
        }
    }
}
