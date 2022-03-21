using System;
using FluentAssertions;
using Xunit;

namespace TestStringCalculator
{
    public class StringCalculatorSpecs
    {

        private readonly StringCalculator.StringCalculator _stringCalculator = new();
        private string _givenInput;

        [Fact]
        public void StringEmptyShouldBe0()
        {
            _givenInput = string.Empty;

            var result = _stringCalculator.Add(_givenInput);

            result.Should().Be(0);
        }

        [Fact]
        public void String1ComaString2ShouldBe3()
        {
            var givenInput = "1,2";

            var result = _stringCalculator.Add(givenInput);

            result.Should().Be(3);
        }
    }
}
