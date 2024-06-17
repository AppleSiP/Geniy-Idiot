using Newtonsoft.Json;

namespace GeniyIdiotConsoleApp
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;
        public User()
        {
            CountRightAnswers = 0;
        }
        public User (string name)
        {
            Name = name;
            CountRightAnswers = 0;
        }
        public string GetName()
        {
            string userName;
            while (true)
            {
                Console.WriteLine("Введите имя пользователя");
                userName = Console.ReadLine().ToLower();
                if (userName.Length != 0)
                {
                    return userName;
                }
            }
        }
        public void Diagnostic()
        {
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            var diagnosis = JsonConvert.DeserializeObject<List<string>>(DataFile.ReadAll("Diagnosis.json"));
            double resultRatio = (CountRightAnswers * (diagnosis.Count - 1) / questionsAndAnswers.Count);
            var indexDiagnose = Convert.ToInt32(Math.Floor(resultRatio));
            Diagnose = diagnosis[indexDiagnose];
        }
        public void ResetCountRightAnswers()
        { 
            CountRightAnswers = 0;
        }
        public static void ShowResult(User user)
        {
            user.Diagnostic();
            Console.WriteLine($"Количество правильных ответов: {user.CountRightAnswers}");
            Console.WriteLine($"{user.Name}! Ваш диагноз: {user.Diagnose}");
        }
    }
}
