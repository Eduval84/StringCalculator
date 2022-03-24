using System;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using FluentAssertions;
using Xunit;

namespace TestStringCalculator
{
    public class StringCalculatorSpecs
    {

        private readonly StringCalculator.StringCalculator _stringCalculator = new();
        private string _givenInput;
        private int _result;

        [Fact]
        public void string_empty_input_should_be_0()
        {
            _givenInput = string.Empty;

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(0);
        }

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("3,5", 8)]
        [InlineData("1,2,3", 6)]
        public void given_positive_strings_numbers_separate_by_comas_get_a_int_result_with_the_sum_of_all_of_them(string givenNumbers, int expectedResutl)
        {
            _result = _stringCalculator.Add(givenNumbers);

            _result.Should().Be(expectedResutl);
        }

        [Theory]
        [InlineData("1\n2,4",7)]
        [InlineData("2\n2,3\n2", 9)]
        public void given_positive_strings_numbers_separate_by_comas_or_scape_secuence_get_a_int_result_with_the_sum_of_all_of_them(string givenNumbers, int expectedResult)
        {
            _result = _stringCalculator.Add(givenNumbers);

            _result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("//;\n1;2",3)]
        [InlineData("//@\n3@3",6)]
        public void allow_a_custom_delimiter_when_given_input_starts_with_double_bar(string givenInput, int expectedResult)
        {
          
            _result = _stringCalculator.Add(givenInput);

            _result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("1,4,-1","-1")]
        [InlineData("-2,6,-3", "-2,-3")]
        public void throw_negative_not_allowed_exception_with_a_message_with_the_negative_numbers_recibed_in_the_given_input(string givenInput, string expectedExceptionMessage)
        {
            Action whenAct = () => _stringCalculator.Add(givenInput);

            whenAct.Should().Throw<NegativeNotAllowed>().Where(x => x.Message == expectedExceptionMessage);
        }

        [Theory]
        [InlineData("1,1000,3",1004)]
        [InlineData("1,1001,3",4)]
        [InlineData("1,50001,3", 4)]

        public void numbers_greater_than_1000_must_be_ignored(string givenInput, int expectedResult)
        {
            _result = _stringCalculator.Add(givenInput);

            _result.Should().Be(expectedResult);
        }

    }
}
