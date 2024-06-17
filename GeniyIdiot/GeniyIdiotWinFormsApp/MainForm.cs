using GeniyIdiotConsoleApp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<QuestionsStorage> questionsAndAnswers;
        private int[] randoms;
        User user;
        private int currentQuestionIndex = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            user = new User(welcomeForm.userNameTextBox.Text);
            MessageBox.Show("На ответ даётся 10 секунд, нажмите \"OK\" чтобы начать!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            questionsAndAnswers = JsonConvert.DeserializeObject<List<QuestionsStorage>>(DataFile.ReadAll("QuestionsAndAnswers.json"));
            if (questionsAndAnswers == null)
            {
                questionsAndAnswers = new List<QuestionsStorage>();
                DialogResult verificationResult = MessageBox.Show("Список вопросов пуст, хотите добавить вопрос?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (verificationResult == DialogResult.Yes)
                {
                    var questionManager = new QuestionsManagerForm();
                    questionManager.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Приложение будет закрыто!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
            }
            else
            {
                mainFormTimer.Start();
                randoms = Helper.Shuffle(questionsAndAnswers.Count);
                user.ResetCountRightAnswers();
                questionNumberLabel.Text = $"Вопрос №{currentQuestionIndex + 1}";
                ShowQuestion(currentQuestionIndex);
                userAnswerTextBox.Select();
            }
        }
        private void ShowQuestion(int index)
        {
            questionTextLabel.Text = questionsAndAnswers[randoms[index]].Question;
        }
        void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Check.InputNumber(userAnswerTextBox.Text);
            if (userAnswer == double.MaxValue)
            {
                ErrorMessageManager.Show("Введите число!");
                userAnswerTextBox.Text = "";
                userAnswerTextBox.Select();
            }
            else
            {
                if (userAnswer == Math.Round(Convert.ToDouble(questionsAndAnswers[randoms[currentQuestionIndex]].Answer), 2))
                {
                    user.CountRightAnswers++;
                }
                currentQuestionIndex++;
                userAnswerTextBox.Text = "";
                userAnswerTextBox.Select();
                if (currentQuestionIndex < randoms.Length)
                {
                    ShowQuestion(currentQuestionIndex);
                    questionNumberLabel.Text = $"Вопрос №{currentQuestionIndex + 1}";
                    time = 10;
                    mainFormTimerLabel.ForeColor = Color.Black;
                }
                else
                {
                    user.Diagnostic();
                    var message = $"Количество правильных ответов: {user.CountRightAnswers}\n\n{user.Name}!\n\nВаш диагноз: {user.Diagnose}";
                    Statistic.Save(user);
                    var resultForm = new ResultForm();
                    resultForm.resultTextLabel.Text = message;
                    resultForm.ShowDialog();
                    questionNumberLabel.Text = "Конец";
                    questionTextLabel.Text = "Вы прошли тестирование Гений-Идиот";
                    mainFormTimer.Stop();
                    userAnswerTextBox.Visible = false;
                    sendAnswerButton.Visible = false;
                    mainFormTimerLabel.Visible = false;
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void StatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var statisticForm = new StatisticForm();
            statisticForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextButton_Click(sendAnswerButton, null);
                e.SuppressKeyPress = true;
            }
        }

        private void ManagerQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionManager = new QuestionsManagerForm();
            questionManager.ShowDialog();
        }
        double time = 10;
        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            double stepTime = 0.1;
            time -= stepTime;
            if (time <= 3)
            {
                mainFormTimerLabel.ForeColor = Color.Red;
            }
            mainFormTimerLabel.Text = Math.Round(time, 2).ToString();
            if (time <= 0)
            {
                currentQuestionIndex++;
                time = 10;
                mainFormTimerLabel.ForeColor = Color.Black;
                if (currentQuestionIndex < randoms.Length)
                {
                    questionNumberLabel.Text = $"Вопрос №{currentQuestionIndex + 1}";
                    ShowQuestion(currentQuestionIndex);
                }
                else
                {
                    user.Diagnostic();
                    var message = $"Количество правильных ответов: {user.CountRightAnswers}\n\n{user.Name}!\n\nВаш диагноз: {user.Diagnose}";
                    Statistic.Save(user);
                    var resultForm = new ResultForm();
                    resultForm.resultTextLabel.Text = message;
                    resultForm.ShowDialog();
                    questionNumberLabel.Text = "Конец";
                    questionTextLabel.Text = "Вы прошли тестирование Гений-Идиот";
                    mainFormTimer.Stop();
                    userAnswerTextBox.Visible = false;
                    sendAnswerButton.Visible = false;
                    mainFormTimerLabel.Visible = false;
                }
            }
        }
    }
}
