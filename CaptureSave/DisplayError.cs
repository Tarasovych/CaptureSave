using System.Windows.Forms;

namespace CaptureSave
{
    public class DisplayError
    {
        public DialogResult ShowHotkeyInUseError(TextBox textBox)
        {
            textBox.Select();
            return MessageBox.Show(textBox.Text + " hotkey is already in use", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowEmptyStringError(TextBox textBox)
        {
            textBox.Select();
            return MessageBox.Show("Enter hotkey!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult MustContainCmdKeysError()
        {
            return MessageBox.Show("Ctrl, Alt or Shift is required in hotkey combination!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
