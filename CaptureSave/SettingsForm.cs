using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace CaptureSave
{
    public partial class SettingsForm : Form
    {
        private DisplayMessage _displayMessage;
        private RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private bool SettingsLoaded;
        private bool saveToClipboardOption
        {
            get { return Properties.Settings.Default.SaveToClipboard; }
            set { Properties.Settings.Default.SaveToClipboard = value; }
        }
        private bool runOnStartupOption
        {
            get { return Properties.Settings.Default.RunOnStartup; }
            set { Properties.Settings.Default.RunOnStartup = value; }
        }

        public SettingsForm(DisplayMessage displayMessage)
        {
            InitializeComponent();
            _displayMessage = displayMessage;
            LoadSettings();
        }

        private void LoadSettings()
        {
            checkBoxSaveClipboard.Checked = saveToClipboardOption;

            if (key.GetValue(ProductName) == null)
            {
                _displayMessage.RegistryError();
                Application.Exit();
            }
            else
                checkBoxRunAtStartup.Checked = runOnStartupOption;

            SettingsLoaded = true;
        }

        private void checkBoxSaveClipboard_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveToClipboard = checkBoxSaveClipboard.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxRunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (key != null & SettingsLoaded == true)
            {
                ChangeStartup();
                Properties.Settings.Default.RunOnStartup = checkBoxRunAtStartup.Checked;
                Properties.Settings.Default.Save();
            }
            else if (key == null)
            {
                _displayMessage.RegistryError();
                Application.Exit();
            }
        }

        private void ChangeStartup()
        {
            if (checkBoxRunAtStartup.Checked)
            {
                key.SetValue(ProductName, Application.ExecutablePath);
                _displayMessage.CustomNotification("Startup enabled!");
            }
            else
            {
                key.SetValue(ProductName, String.Empty);
                _displayMessage.CustomNotification("Startup disabled!");
            }
        }
    }
}
