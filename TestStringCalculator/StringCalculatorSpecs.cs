using System;
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

        //Para cambiar de separador el comienzo de la cadena deberá contener una línea separada con este formato "//[delimiter]\n[numbers...]"
        [Fact]
        public void CanSupoortDiferentSplitsStrings()
        {
            _givenInput = "//;\n1;2";

            _result = _stringCalculator.Add(_givenInput);

            _result.Should().Be(3);
        }
    }
}
