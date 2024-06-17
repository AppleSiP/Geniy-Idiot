
namespace GeniyIdiotWinFormsApp
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            resultButton.Select();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CloseFormButton_Click(resultButton, null);
                e.SuppressKeyPress = true;
            }
        }
    }
}
