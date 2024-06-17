
namespace GeniyIdiotWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameTextBox.Text))
            {
                ErrorMessageManager.Show("Введите имя пользователя!");
                userNameTextBox.Select();
            }
            else if (userNameTextBox.Text.Length > 32)
            {
                ErrorMessageManager.Show("Введенное имя слишком длинное!\n\nМаксимальная длина 32 символа. ");
                userNameTextBox.Select();
            }
            else
            {
                Close();
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Select();
        }
        void WelcomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startButton_Click(startButton, null);
                e.SuppressKeyPress = true;
            }
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (String.IsNullOrEmpty(userNameTextBox.Text))
            {
                Application.Exit();
            }
        }
    }
}
