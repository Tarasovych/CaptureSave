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

        const int MYACTION_HOTKEY_ID = 1;

        private int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
        private int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);

        private string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\img\\";

        public CaptureSave()
        {
            InitializeComponent();
            LoadResolution();
            LoadHotkey();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 5, (int)Keys.S);
        }

        public void LoadResolution()
        {
            textScreenWidth.Text = screenWidth.ToString();
            textScreenHeight.Text = screenHeight.ToString();
        }

        public void LoadHotkey()
        {
            textHotkey.Text = Keys.Alt.ToString() + "+" + Keys.Shift.ToString() + "+" + Keys.S.ToString();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                    }

                    System.IO.FileInfo file = new System.IO.FileInfo(filePath);
                    file.Directory.Create();

                    string name = DateTime.Now.ToFileTime() + ".png";
                    bitmap.Save(filePath + name, ImageFormat.Png);
                }
            }
            base.WndProc(ref m);
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            } else
            {
                MessageBox.Show("Try to make screenshots first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
