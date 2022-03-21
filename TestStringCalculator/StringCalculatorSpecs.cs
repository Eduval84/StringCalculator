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
    }
}
