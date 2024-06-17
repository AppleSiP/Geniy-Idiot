
using Newtonsoft.Json;

namespace GeniyIdiotConsoleApp
{
    public static class Statistic
    {
        public static void Save(User user)
        {
            var statistics = JsonConvert.DeserializeObject<List<User>>(DataFile.ReadAll("Statistics.json"));
            if (statistics == null)
            {
                statistics = new List<User>();
            }
            statistics.Add(user);
            DataFile.Write("Statistics.json", JsonConvert.SerializeObject(statistics), false);
        }
        public static void Show()
        {
            var statistics = JsonConvert.DeserializeObject<List<User>>(DataFile.ReadAll("Statistics.json"));
            Console.WriteLine("===================================================================");
            Console.WriteLine("| {0,-20} | {1,-27} | {2,-10} |", "Имя:", "Кол-во правильных ответов:", "Диагноз:");
            Console.WriteLine("===================================================================");
            for (int i = 0; i < statistics.Count; i++)
            {;
                Console.WriteLine("| {0,-20} | {1,-27} | {2,-10} |", statistics[i].Name, statistics[i].CountRightAnswers, statistics[i].Diagnose);
                Console.WriteLine("===================================================================");
            }
        }
    }
}