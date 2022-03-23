using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Delimiter
    {
        private StringCalculator _stringCalculator;
        private char[] _defaultDelimiters = new char[] { ',', '\n' };
        private List<char> _customDelimiters = new List<char>();

        public Delimiter(StringCalculator stringCalculator)
        {
            _stringCalculator = stringCalculator;
        }

        public void GetCustomDelimiters(string numbers)
        {
            _customDelimiters = _defaultDelimiters.ToList();
            if (numbers.Contains("//"))
            {
                _stringCalculator._numbers.givenNumbers = numbers.Replace("//", string.Empty);
                var customDelimiters = _stringCalculator._numbers.givenNumbers.Split('\n').First();
                _stringCalculator._numbers.givenNumbers = ReplaceFirstOccurrance(_stringCalculator._numbers.givenNumbers, customDelimiters);
                _stringCalculator._numbers.givenNumbers = _stringCalculator._numbers.givenNumbers.Replace("\n", string.Empty);
                _customDelimiters.Add(customDelimiters.First());
                _defaultDelimiters = _customDelimiters.ToArray();
            }
        }

        public static string ReplaceFirstOccurrance(string sourceString, string removeString)
        {
            int index = sourceString.IndexOf(removeString);
            string cleanPath = (index < 0)
                ? sourceString
                : sourceString.Remove(index, removeString.Length);
            return cleanPath;
        }

        public string[] SplitNumbers(string numbers)
        {
            return numbers.Split(_defaultDelimiters);
        }
    }
}