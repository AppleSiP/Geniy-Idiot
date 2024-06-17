using GeniyIdiotConsoleApp;
using Newtonsoft.Json;

namespace GeniyIdiotWinFormsApp
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            var statistics = JsonConvert.DeserializeObject<List<User>>(DataFile.ReadAll("Statistics.json"));
            if (statistics == null)
            {
                statistics = new List<User>();
            }
            foreach (var user in statistics)
            {
                statisticDataGridView.Rows.Add(user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }
    }
}
