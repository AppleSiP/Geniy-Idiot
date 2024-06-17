
namespace GeniyIdiotWinFormsApp
{
    public static class ErrorMessageManager
    {
        public static void Show(string message)
        {
            MessageBox.Show(message, "Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
    }
}
