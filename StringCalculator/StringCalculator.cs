using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class StringCalculator
    {
        private char[] _delimiters;
        private const int Result = 0;
        private string[] _givenNumbers;

        public static void Main(string[] args)
        {
        }

        public int Add(string numbers)
        {
            _givenNumbers = SplitNumbers(numbers);

            if (numbers == string.Empty)
                return Result;

            return sumNumbers(_givenNumbers, Result);
        }

        private int sumNumbers(string[] givenNumbers, int result)
        {
            foreach (var num in givenNumbers)
            {
                result += int.Parse(num);
            }

            return result;
        }

        private string[] SplitNumbers(string numbers)
        {
            _delimiters = new char[] {',', '\n'};
            return numbers.Split(_delimiters);
        }
    }
}
