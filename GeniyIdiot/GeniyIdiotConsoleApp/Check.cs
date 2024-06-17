namespace GeniyIdiotConsoleApp
{
    public static class Check
    {
        public static double InputNumber()
        {
            while (true)
            {
                var input = Console.ReadLine().Replace('.', ',');
                var maxLengthAnswer = Convert.ToString(double.MaxValue).Length - 1;
                if (input.Length > maxLengthAnswer)
                {
                    input = input.Remove(maxLengthAnswer - 1);
                }
                double correctInput;
                bool statusAnswer = double.TryParse(input, out correctInput);
                if (statusAnswer)
                {
                    return Math.Round(correctInput, 2);
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
        }
        public static double InputNumber(string input)
        {
            while (true)
            {
                input = input.Replace('.', ',');
                var maxLengthAnswer = Convert.ToString(double.MaxValue).Length - 1;
                if (input.Length > maxLengthAnswer)
                {
                    input = input.Remove(maxLengthAnswer - 1);
                }
                double correctInput;
                bool statusAnswer = double.TryParse(input, out correctInput);
                if (statusAnswer)
                {
                    return Math.Round(correctInput, 2);
                }
                else
                {
                    return double.MaxValue;
                }
            }
        }
    }
}
