using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CaptureSave
{

    public partial class CaptureSave : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1;

        private int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
        private int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);

        public CaptureSave()
        {
            InitializeComponent();
            LoadResolution();
            LoadHotkey();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 3, (int)Keys.S);
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

                    string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\img\\";

                    System.IO.FileInfo file = new System.IO.FileInfo(filePath);
                    file.Directory.Create();

                    string name = DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + ".png";
                    bitmap.Save(filePath + name, ImageFormat.Png);
                }
            }
            base.WndProc(ref m);
        }
    }
}
