using GeniyIdiotConsoleApp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionsManagerForm : Form
    {
        public QuestionsManagerForm()
        {
            InitializeComponent();
        }

        private void QuestionsManagerForm_Load(object sender, EventArgs e)
        {
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            if (questionsAndAnswers == null)
            {
                questionsManagerDeleteButton.Visible = false;
            }
            FillQuestionManagerDataGridView();

        }

        private void QuestionsManagerExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuestionsManagerAddButton_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(newQuestionTextBox.Text)) && !(String.IsNullOrEmpty(newAnswerTextBox.Text)))
            {
                var newAnswer = Check.InputNumber(newAnswerTextBox.Text);
                if (newAnswer == double.MaxValue)
                {
                    ErrorMessageManager.Show("Введите число!");
                    newAnswerTextBox.Text = "";
                    newAnswerTextBox.Select();
                }
                else
                {
                    var newQuestion = new QuestionsStorage();
                    newQuestion.Question = newQuestionTextBox.Text;
                    newQuestion.Answer = Math.Round(Convert.ToDouble(newAnswerTextBox.Text), 2);
                    var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
                    questionsAndAnswers.Add(newQuestion);
                    var newQuestionsAndAnswers = JsonConvert.SerializeObject(questionsAndAnswers, Formatting.Indented);
                    DataFile.Write("QuestionsAndAnswers.json", newQuestionsAndAnswers, false);
                    MessageBox.Show("Вопрос добавлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    newQuestionTextBox.Text = string.Empty;
                    newAnswerTextBox.Text = string.Empty;
                    questionsManagerDataGridView.Rows.Clear();
                    FillQuestionManagerDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Введите вопрос и ответ!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void QuestionsManagerDeleteButton_Click(object sender, EventArgs e)
        {
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            //var questions = DataFile.ReadLines("Questions.txt");
            var rowIndex = questionsManagerDataGridView.CurrentCell.RowIndex;
            var message = $"Подтвердите удаление вопроса: \"{questionsAndAnswers[rowIndex].Question}\"?";
            DialogResult verificationResult = MessageBox.Show(message, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (verificationResult == DialogResult.Yes)
            {
                questionsAndAnswers.RemoveAt(rowIndex);
                var newQuestionsAndAnswers = JsonConvert.SerializeObject(questionsAndAnswers, Formatting.Indented);
                DataFile.Write("QuestionsAndAnswers.json", newQuestionsAndAnswers, false);
                MessageBox.Show("Вопрос удалён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                questionsManagerDataGridView.Rows.Clear();
                FillQuestionManagerDataGridView();
            }
        }
        private void FillQuestionManagerDataGridView()
        {
            var questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            if (questionsAndAnswers != null)
            {
                var numberQuestion = 1;
                foreach (var question in questionsAndAnswers)
                {
                    questionsManagerDataGridView.Rows.Add(numberQuestion, question.Question);
                    numberQuestion++;
                }
            }
        }
        private void QuestionsManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
