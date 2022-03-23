using System;

namespace TestStringCalculator
{
    public class NegativeNotAllowed : Exception
    {
        public NegativeNotAllowed(string message)
            : base(message) { }
    }
}