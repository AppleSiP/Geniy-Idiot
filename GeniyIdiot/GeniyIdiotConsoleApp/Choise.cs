namespace GeniyIdiotConsoleApp
{
    public static class Choise
    {
        public static int GetNumberQuestion(List<QuestionsStorage> list)
        {
            
            while (true)
            {
                int correctNumber;
                var userAnswer = Console.ReadLine().Replace('.', ',');
                bool statusAnswer = int.TryParse(userAnswer, out correctNumber);
                if (statusAnswer && correctNumber <= list.Count && correctNumber > 0)
                {
                    return correctNumber - 1;
                }
                if (userAnswer.ToLower() == "отмена" || userAnswer.ToLower() == "jnvtyf")
                {
                    return -1;
                }
                else
                {
                    Console.WriteLine("Пожалуйстa введите номер строки (число)! или <отмена>");
                }
            }
        }
        public static bool GetDichotomousAnswer(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} Введите Да или Нет");
                var escapeCommand = Console.ReadLine().ToLower();
                if (escapeCommand == "да" || escapeCommand == "lf")
                {
                    return true;
                }
                if (escapeCommand == "нет" || escapeCommand == "ytn")
                {
                    return false;
                }
            }
        }
    }
}
