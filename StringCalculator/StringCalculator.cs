using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private char[] _defaultDelimiters = new char[] { ',', '\n' };
        private List<char> _customDelimiters = new List<char>();
        private const int Result = 0;
        private string _numbers;
        private string[] _givenNumbers;

        public static void Main(string[] args)
        {
        }

        public int Add(string givenInput)
        {
            _numbers = givenInput;
            GetCustomDelimiters(_numbers);
            _givenNumbers = SplitNumbers(_numbers);

            if (_numbers == string.Empty)
                return Result;

            return sumNumbers(_givenNumbers, Result);
        }

        private void GetCustomDelimiters(string numbers)
        {
            _customDelimiters = _defaultDelimiters.ToList();
            if (numbers.Contains("//"))
            {
                _numbers = numbers.Replace("//", string.Empty);
                var customDelimiters = _numbers.Split('\n').First();
                _numbers = ReplaceFirstOccurrance(_numbers, customDelimiters);
                _numbers = _numbers.Replace("\n", string.Empty);
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

        private string[] SplitNumbers(string numbers)
        {
            return numbers.Split(_defaultDelimiters);
        }

        private int sumNumbers(string[] givenNumbers, int result)
        {
            foreach (var num in givenNumbers)
            {
                result += int.Parse(num);
            }

            return result;
        }

    }
}
