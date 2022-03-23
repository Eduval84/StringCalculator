namespace StringCalculator
{
    public class StringCalculator
    {
        private string[] _givenNumbers;
        public readonly Numbers _numbers = new Numbers();
        private readonly Delimiter _delimiter;

        public StringCalculator()
        {
            _delimiter = new Delimiter(this);
        }

        public static void Main(string[] args)
        {
        }

        public int Add(string givenInput)
        {
            _numbers.givenNumbers = givenInput;
            _delimiter.GetCustomDelimiters(_numbers.givenNumbers);
            _givenNumbers = _delimiter.SplitNumbers(_numbers.givenNumbers);

            if (_numbers.givenNumbers == string.Empty)
                return 0;

            return _numbers.sumNumbers(_givenNumbers);
        }
    }
}
