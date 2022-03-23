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

            CheckForNegativeNumbers(givenNumbers);

            foreach (var num in givenNumbers)
            {
                if (int.Parse(num) <= 1000)
                    result += int.Parse(num);
            }
            return result;
        }

        private void CheckForNegativeNumbers(string[] givenNumbers)
        {
            _negativeNumbers = givenNumbers.Where(n => int.Parse(n) < 0).ToList();

            if (_negativeNumbers.Any())
                throw new NegativeNotAllowed(string.Join(",", _negativeNumbers));
        }
    }
}