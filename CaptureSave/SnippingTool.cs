using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaptureSave
{
    public partial class SnippingTool : Form
    {
        public Image Image { get; set; }

        private Rectangle rectangleSelect = new Rectangle();
        private Point pointStart;

        public static Image Snip()
        {
            var rectangle = Screen.PrimaryScreen.Bounds;
            using (Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

                using (var snipper = new SnippingTool(bitmap))
                {
                    if (snipper.ShowDialog() == DialogResult.OK)
                    {
                        return snipper.Image;
                    }
                }
                return null;
            }
        }

        public SnippingTool(Image screenShot)
        {
            InitializeComponent();
            this.BackgroundImage = screenShot;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            pointStart = e.Location;
            rectangleSelect = new Rectangle(e.Location, new Size(0, 0));
            this.Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int x1 = Math.Min(e.X, pointStart.X);
            int y1 = Math.Min(e.Y, pointStart.Y);
            int x2 = Math.Max(e.X, pointStart.X);
            int y2 = Math.Max(e.Y, pointStart.Y);
            rectangleSelect = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (rectangleSelect.Width <= 0 || rectangleSelect.Height <= 0) return;
            Image = new Bitmap(rectangleSelect.Width, rectangleSelect.Height);
            using (Graphics graphics = Graphics.FromImage(Image))
            {
                graphics.DrawImage(this.BackgroundImage, new Rectangle(0, 0, Image.Width, Image.Height),
                    rectangleSelect, GraphicsUnit.Pixel);
            }
            DialogResult = DialogResult.OK;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(Color.FromArgb(120, Color.White)))
            {
                int x1 = rectangleSelect.X; int x2 = rectangleSelect.X + rectangleSelect.Width;
                int y1 = rectangleSelect.Y; int y2 = rectangleSelect.Y + rectangleSelect.Height;
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, x1, this.Height));
                e.Graphics.FillRectangle(brush, new Rectangle(x2, 0, this.Width - x2, this.Height));
                e.Graphics.FillRectangle(brush, new Rectangle(x1, 0, x2 - x1, y1));
                e.Graphics.FillRectangle(brush, new Rectangle(x1, y2, x2 - x1, this.Height - y2));
            }
            using (Pen pen = new Pen(Color.Red, 1))
            {
                e.Graphics.DrawRectangle(pen, rectangleSelect);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.DialogResult = DialogResult.Cancel;
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
