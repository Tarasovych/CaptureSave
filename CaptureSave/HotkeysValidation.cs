using System.Windows.Forms;

namespace CaptureSave
{
    public class HotkeysValidation
    {
        public bool Validate(KeyEventArgs e)
        {
            bool shiftMod = ((e.Modifiers & Keys.Shift) != 0);
            bool altMod = ((e.Modifiers & Keys.Alt) != 0);
            bool ctrlMod = ((e.Modifiers & Keys.Control) != 0);
            bool modifiers = false;
            bool letterNumber = false;

            if ((shiftMod & altMod) || (shiftMod & ctrlMod) || (altMod & ctrlMod) || shiftMod || altMod || ctrlMod)
                modifiers = true;

            if ((e.KeyCode >= Keys.A & e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 & e.KeyCode <= Keys.D9))
                letterNumber = true;

            if (modifiers && letterNumber && e.KeyCode != Keys.Back)
                return true;
            else
                return false;
        }
    }
}
