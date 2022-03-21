using FluentAssertions;
using Xunit;

namespace TestStringCalculator
{
    public class StringCalculatorSpecs
    {
        [Fact]
        public void StringEmptyShouldBe0()
        {
            var stringCalculator = new StringCalculator.StringCalculator();

            var result = stringCalculator.Add("");

            result.Should().Be(0);
        }

        [Fact]
        public void String1ComaString2ShoudBe3()
        {
            var stringCalculator = new StringCalculator.StringCalculator();

            var result = stringCalculator.Add("1,2");

            result.Should().Be(3);
        }
    }
}
