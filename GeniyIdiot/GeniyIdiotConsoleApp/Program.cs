using Newtonsoft.Json;
using System.Xml.Linq;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            var user = new User();
            user.Name = user.GetName();
            while (true)
            {
                user.ResetCountRightAnswers();
                var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
                if (questionsAndAnswers != null)
                {
                    var randoms = Helper.Shuffle(questionsAndAnswers.Count);
                    for (int i = 0; i < questionsAndAnswers.Count; i++)
                    {
                        Console.WriteLine($"Вопрос №{i + 1}");
                        Console.WriteLine(questionsAndAnswers[randoms[i]].Question);
                        if (Check.InputNumber() == Math.Round(Convert.ToDouble(questionsAndAnswers[randoms[i]].Answer), 2))
                        {
                            user.CountRightAnswers++;
                        }
                    }
                    User.ShowResult(user);
                    Statistic.Save(user);
                }
                else
                {
                    if (Choise.GetDichotomousAnswer("Список вопросов пуст, хотите добавить свой вопрос?"))
                    {
                        new QuestionsStorage().AddQuestion();
                    } 
                }
                if (Choise.GetDichotomousAnswer("Хотите начать сначала?"))
                {
                    Console.Clear();
                }
                else
                {
                    if (Choise.GetDichotomousAnswer("Хотите посмотреть статистику игр?"))
                    {
                        Statistic.Show();
                    }
                    if (Choise.GetDichotomousAnswer("Хотите добавить или удалить вопрос?"))
                    {
                        while (true)
                        {
                            Console.WriteLine($"Введите <добавить> или <удалить>, или введите <отмена>");
                            var choise = Console.ReadLine().ToLower();
                            if (choise == "добавить" || choise == "lj,fdbnm")
                            {
                                new QuestionsStorage().AddQuestion();
                                break;
                            }
                            if (choise == "удалить" || choise == "elfkbnm")
                            {
                                if (questionsAndAnswers.Count > 0)
                                {
                                    new QuestionsStorage().RemoveQuestion();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Список вопросов пуст");
                                }
                            }
                            if (choise == "отмена" || choise == "jnvtyf")
                            {
                                break;
                            }
                        }
                    }
                    break;
                }
            }
        }
    }
}