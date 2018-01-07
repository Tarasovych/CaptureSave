using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CaptureSave
{
    public partial class CaptureSave : Form
    {
        private int screenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width);
        private int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height);

        public CaptureSave()
        {
            InitializeComponent();
            LoadResolution();
        }

        public void LoadResolution()
        {
            textScreenWidth.Text = screenWidth.ToString();
            textScreenHeight.Text = screenHeight.ToString();
        }

        private void CaptureSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.S)
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
            e.SuppressKeyPress = true;
        }
    }
}
