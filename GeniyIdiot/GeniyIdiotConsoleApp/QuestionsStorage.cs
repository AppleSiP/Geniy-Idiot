using Newtonsoft.Json;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsStorage
    {
        public string Question;
        public double Answer;
        public void AddQuestion()
        {
            var newQuestion = new QuestionsStorage();
            Console.WriteLine("Введите вопрос");
            newQuestion.Question = Console.ReadLine();
            Console.WriteLine("Введите ответ");
            newQuestion.Answer = Check.InputNumber();
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            if (questionsAndAnswers == null)
            {questionsAndAnswers = new List<QuestionsStorage>();}
            questionsAndAnswers.Add(newQuestion);
            var newQuestionsAndAnswers = JsonConvert.SerializeObject(questionsAndAnswers, Formatting.Indented);
            DataFile.Write("QuestionsAndAnswers.json", newQuestionsAndAnswers, false);
            Console.WriteLine("Вопрос добавлен!");
        }
        public void RemoveQuestion()
        {
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            if (questionsAndAnswers != null)
            {
                for (int i = 0; i < questionsAndAnswers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {questionsAndAnswers[i].Question}");
                }
                Console.WriteLine("Введите номер вопроса для удаления");
                var indexLine = Choise.GetNumberQuestion(questionsAndAnswers);
                if (indexLine > 0)
                {
                    questionsAndAnswers.RemoveAt(indexLine);
                    var newQuestionsAndAnswers = JsonConvert.SerializeObject(questionsAndAnswers);
                    DataFile.Write("QuestionsAndAnswers.json", newQuestionsAndAnswers, false);
                    Console.WriteLine("Вопрос удалён!");
                }
            }
            else
            {
                Console.WriteLine("Список вопросов пуст.");
            }
        }
    }
}
