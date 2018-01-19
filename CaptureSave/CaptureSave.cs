using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace CaptureSave
{
    public partial class CaptureSave : Form
    {     
        const int SCREENSHOT_HOTKEY_ID = 1;
        const int SNIPPET_HOTKEY_ID = 2;

        private string ScreenshotHotkeySettings {
            get { return Properties.Settings.Default.ScreenshotHotkey; }
            set { Properties.Settings.Default.ScreenshotHotkey = value; }
        }
        private string SnippetHotkeySettings {
            get { return Properties.Settings.Default.SnippetHotkey; }
            set { Properties.Settings.Default.SnippetHotkey = value; }
        }
        private bool saveToClipboardOption
        {
            get { return Properties.Settings.Default.SaveToClipboard; }
        }
        private int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
        private int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);
        private string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Images_CaptureSave\\";
        private DisplayMessage _displayMessage;
        private HotkeysValidation _hotkeysValidation;

        protected bool AllowScreenshots {
            get
            {
                if (textScreenshotHotkey.Enabled == false && textSnippetHotkey.Enabled == false)
                    return true;
                else
                    return false;
            }
        }

        protected int GetModifiers(string settings)
        {
            string[] keys;
            int fsModifier = 0;
            keys = settings.Split('+');

            if (keys.Contains("Alt"))
                fsModifier = 1;

            if (keys.Contains("Ctrl"))
                fsModifier = fsModifier + 2;

            if (keys.Contains("Shift"))
                fsModifier = fsModifier + 4;

            return fsModifier;
        }

        protected Keys GetKey(string settings)
        {
            Keys key;
            string[] keys;
            keys = settings.Split('+');

            Enum.TryParse(keys.Last(), out key);

            return key;
        }

        public CaptureSave(DisplayMessage displayMessage, HotkeysValidation hotkeysValidation)
        {
            InitializeComponent();
            LoadHotkeys();
            LoadSettings();
            _displayMessage = displayMessage;
            _hotkeysValidation = hotkeysValidation;
        }

        public void LoadSettings()
        {
            textScreenshotHotkey.Text = ScreenshotHotkeySettings;
            textSnippetHotkey.Text = SnippetHotkeySettings;
        }

        public void LoadHotkeys()
        {
            RegisterHotKey(this.Handle, SCREENSHOT_HOTKEY_ID, GetModifiers(ScreenshotHotkeySettings), (int)GetKey(ScreenshotHotkeySettings));
            RegisterHotKey(this.Handle, SNIPPET_HOTKEY_ID, GetModifiers(SnippetHotkeySettings), (int)GetKey(SnippetHotkeySettings));
        }

        protected void SaveImage(string imageType, Bitmap bitmap)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            if (!Directory.Exists(filePath))
                file.Directory.Create();

            string name;

            if (imageType == "screenshot" && imageType != null)
                name = DateTime.Now.ToFileTime() + "_screenshot.png";
            else
                name = DateTime.Now.ToFileTime() + "_snippet.png";

            bitmap.Save(filePath + name, ImageFormat.Png);

            if (saveToClipboardOption)
                Clipboard.SetImage(bitmap);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == SCREENSHOT_HOTKEY_ID && AllowScreenshots == true)
            {
                using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                        g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

                    SaveImage("screenshot", bitmap);
                }
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == SNIPPET_HOTKEY_ID && AllowScreenshots == true)
            {
                if ((Application.OpenForms["SnippingTool"] as SnippingTool) == null)
                {
                    var bitmap = SnippingTool.Snip();
                    if (bitmap != null)
                    {
                        SaveImage("snippet", new Bitmap(bitmap));
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filePath))
                System.Diagnostics.Process.Start(filePath);
            else
                MessageBox.Show("Try to make screenshots first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CaptureSave_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Show();
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonEditScreenshotHotkey_Click(object sender, EventArgs e)
        {
            EditHotkeysButton(textScreenshotHotkey, buttonSaveScreenshotHotkey, buttonEditScreenshotHotkey, SCREENSHOT_HOTKEY_ID);
        }

        private void buttonEditSnippetHotkey_Click(object sender, EventArgs e)
        {
            EditHotkeysButton(textSnippetHotkey, buttonSaveSnippetHotkey, buttonEditSnippetHotkey, SNIPPET_HOTKEY_ID);
        }

        private void EditHotkeysButton(TextBox textBox, Button buttonSave, Button buttonEdit, int id)
        {
            UnregisterHotKey(this.Handle, id);
            textBox.Enabled = true;
            textBox.Select();
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
        }

        private void buttonSaveScreenshotHotkey_Click(object sender, EventArgs e)
        {
            SaveHotkeysButton(textScreenshotHotkey, SnippetHotkeySettings, "ScreenshotHotkey", buttonSaveScreenshotHotkey, buttonEditScreenshotHotkey);
        }

        private void buttonSaveSnippetHotkey_Click(object sender, EventArgs e)
        {
            SaveHotkeysButton(textSnippetHotkey, ScreenshotHotkeySettings, "SnippetHotkey", buttonSaveSnippetHotkey, buttonEditSnippetHotkey);
        }

        private void SaveHotkeysButton(TextBox textBox, string settingsExists, string settingsRewrite, Button buttonSave, Button buttonEdit)
        {
            PropertyDescriptor pd = TypeDescriptor.GetProperties(Properties.Settings.Default)[settingsRewrite];
            if (textBox.Text != settingsExists && textBox.Text != "")
            {
                pd.SetValue(Properties.Settings.Default, textBox.Text);
                Properties.Settings.Default.Save();
                LoadHotkeys();
                buttonSave.Visible = false;
                textBox.Enabled = false;
                buttonEdit.Visible = true;
            }
            else if (textBox.Text == "")
            {
                _displayMessage.ShowEmptyStringError(textBox);
            }
            else
            {
                _displayMessage.ShowHotkeyInUseError(textBox);
            }
        }

        private void textHotkeys_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textHotkeys = (TextBox)sender;
            e.Handled = true;
            e.SuppressKeyPress = true;
            textHotkeys.Text = "";

            if (_hotkeysValidation.Validate(e))
                textHotkeys.Text = (new KeysConverter()).ConvertToString(e.KeyData);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(new DisplayMessage());
            settingsForm.ShowDialog();
        }

        #region WindowsAPI
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
    }
}
