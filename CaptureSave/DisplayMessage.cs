using System.Windows.Forms;

namespace CaptureSave
{
    public class DisplayMessage
    {
        public DialogResult Error(string text, TextBox textBox = null)
        {
            if (textBox != null)
                textBox.Select();
            return MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult Notification(string text)
        {
            return MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
