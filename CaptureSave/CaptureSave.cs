using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CaptureSave
{

    public partial class CaptureSave : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int ALLSCREEN_HOTKEY_ID = 1;
        const int CROP_HOTKEY_ID = 2;

        private int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
        private int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);

        private string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Images_CaptureSave\\";

        public CaptureSave()
        {
            InitializeComponent();
            LoadResolution();
            LoadHotkeys();
            RegisterHotKey(this.Handle, ALLSCREEN_HOTKEY_ID, 5, (int)Keys.S);
            RegisterHotKey(this.Handle, CROP_HOTKEY_ID, 5, (int)Keys.C);
        }

        public void LoadResolution()
        {
            textScreenWidth.Text = screenWidth.ToString();
            textScreenHeight.Text = screenHeight.ToString();
        }

        public void LoadHotkeys()
        {
            textHotkeyAllScreen.Text = Keys.Alt.ToString() + "+" + Keys.Shift.ToString() + "+" + Keys.S.ToString();
            textHotkeySnippet.Text = Keys.Alt.ToString() + "+" + Keys.Shift.ToString() + "+" + Keys.C.ToString();
        }

        protected void SaveImage(string imageType, Bitmap bitmap)
        {
            string name;

            if (imageType == "screenshot" && imageType != null)
                name = DateTime.Now.ToFileTime() + "_screenshot.png";
            else
                name = DateTime.Now.ToFileTime() + "_snippet.png";

            bitmap.Save(filePath + name, ImageFormat.Png);

            if (checkBoxSaveClipboard.Checked)
                Clipboard.SetImage(bitmap);
        }

        protected override void WndProc(ref Message m)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            if (!Directory.Exists(filePath))
                file.Directory.Create();

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ALLSCREEN_HOTKEY_ID)
            {
                using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                        g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

                    SaveImage("screenshot", bitmap);
                }
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == CROP_HOTKEY_ID)
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
    }
}
