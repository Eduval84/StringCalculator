namespace StringCalculator
{
    public class StringCalculator
    {
        public static void Main(string[] args)
        {
        }

        public int Add(string numbers)
        {
            var givenNumbers = numbers.Split(',');
            int result = 0;

            if (numbers == string.Empty)
                return result;

            foreach (var num in givenNumbers )
            {
                result += int.Parse(num);
            }

            return result;
        }
    }
}
