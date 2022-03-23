using System.Collections.Generic;
using System.Linq;
using TestStringCalculator;

namespace StringCalculator
{
    public class Numbers
    {
        private string _numbers;
        private List<string> _negativeNumbers= new List<string>();

        public string givenNumbers
        {
            set { _numbers = value; }
            get { return _numbers; }
        }

        public int sumNumbers(string[] givenNumbers)
        {
            int result= 0;

            foreach (var num in givenNumbers)
            {
                if (int.Parse(num) <= 0)
                {
                    _negativeNumbers.Add(num);
                }
                result += int.Parse(num);
            }

            if (_negativeNumbers.Any())
                throw new NegativeNotAllowed(string.Join(",",_negativeNumbers));

            return result;
        }
    }
}