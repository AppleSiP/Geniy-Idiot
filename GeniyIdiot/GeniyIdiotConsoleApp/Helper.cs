namespace GeniyIdiotConsoleApp
{
    public static class Helper
    {
        public static int[] Shuffle(int countQuestions)
        {
            var randoms = new int[countQuestions];
            for (int j = 0; j < countQuestions; j++)
            {
                randoms[j] = j;
            }
            Random random = new Random();
            for (int i = 0; i < countQuestions * countQuestions; i++)
            {
                int rnd;
                rnd = randoms[countQuestions - 1];
                int intermediateRandom = random.Next(0, countQuestions - 1);
                randoms[countQuestions - 1] = randoms[intermediateRandom];
                randoms[intermediateRandom] = rnd;
            }
            return randoms;
        }
    }
}
