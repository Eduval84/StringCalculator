using System;
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
        public void StringEmptyShouldBe0()
        {
            _givenInput = string.Empty;

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(0);
        }

        [Fact]
        public void String1ComaString2ShouldBe3()
        {
            _givenInput = "1,2";

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(3);
        }

        [Fact]
        public void AddCanReciveMultipleNumbers()
        {
            _givenInput = "1,2,3";

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(6);
        }

        [Fact]
        public void EscapeSecuenceCanSplitNumbers()
        {
            _givenInput = "1\n2,3";

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(6);
        }

        [Fact]
        public void CanSupoortDiferentSplitsStrings()
        {
            _givenInput = "//;\n1;2";

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(3);
        }

        [Fact]
        public void throw_negative_not_allowed_exception_when_add_a_negative_number_in_input()
        {
            _givenInput = "1,4,-1";

            Action whenAct = () => _stringCalculator.Add(_givenInput);

            whenAct.Should().Throw<NegativeNotAllowed>().Where(x => x.Message == "-1");
        }
    }
}
