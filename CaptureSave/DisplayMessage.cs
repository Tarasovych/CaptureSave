using System.Windows.Forms;

namespace CaptureSave
{
    public class DisplayMessage
    {
        public DialogResult ShowHotkeyInUseError(TextBox textBox)
        {
            textBox.Select();
            return MessageBox.Show(textBox.Text + " hotkey is already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowEmptyStringError(TextBox textBox)
        {
            textBox.Select();
            return MessageBox.Show("Enter hotkey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult MustContainCmdKeysError()
        {
            return MessageBox.Show("Ctrl, Alt or Shift is required in hotkey combination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult DefaultError()
        {
            return MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult RegistryError()
        {
            return MessageBox.Show("Registry error! Try to reinstall your programm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult CustomNotification(string text)
        {
            return MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
