using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics3
{
    public partial class Task1B : Form
    {
        Bitmap back;
        Bitmap bmp;
        Graphics g;
        List<Point> points = new List<Point>();
        private Point start;
        private bool drawing = false;
        private Image orig;

        public Task1B()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = (Bitmap)pictureBox1.Image;
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(bmp);
            Clear(); 

        }

        private void find_borders(Point our_p, ref Point left_b, ref Point right_b, Bitmap b, Color c)
        {
            while (left_b.X > 0 && equalColors(b.GetPixel(left_b.X, left_b.Y), c))
            {
                left_b.X -= 1;
            }

            while (right_b.X < b.Width && equalColors(b.GetPixel(right_b.X, right_b.Y), c))
                right_b.X += 1;
        }

        private bool equalColors(Color c1, Color c2)
        {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }

        private void fill(Point p, Color c)
        {
            Bitmap b = (Bitmap)pictureBox1.Image;

            if (0 < p.X && p.X < b.Width && 0 < p.Y && p.Y < b.Height && equalColors(b.GetPixel(p.X, p.Y), c))
            {
                var g = Graphics.FromImage(b);
                Point left_b = p, right_b = p;
                find_borders(p, ref left_b, ref right_b, b, c); 
                Rectangle r = new Rectangle(left_b.X + 1, p.Y, right_b.X - left_b.X - 1, 1);
                Bitmap line = back.Clone(r, back.PixelFormat); 

                g.DrawImage(line, r);
                pictureBox1.Image = b;

                for (int i = left_b.X + 1; i < right_b.X; ++i)
                    fill(new Point(i, p.Y + 1), c);

                for (int i = left_b.X + 1; i < right_b.X; ++i)
                    fill(new Point(i, p.Y - 1), c);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            if (fill_button.Enabled) 
            {
                orig = pictureBox1.Image;
                points.Add(e.Location);
                drawing = true;
            }
            else
            {
                fill(e.Location, pictureBox1.BackColor); 
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            points.Add(e.Location);
            var pen = new Pen(Color.Black, trackBar1.Value);
            var g = Graphics.FromImage(pictureBox1.Image);
            g.DrawLines(pen, points.ToArray());
            pen.Dispose();
            g.Dispose();
            pictureBox1.Image = pictureBox1.Image;
            pictureBox2.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            points.Clear();
            drawing = false;
        }

        private void Clear()
        {
            var g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void picture_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap b = new Bitmap(ofd.FileName);
                    back = new Bitmap(b, pictureBox1.Size);
                    pictureBox2.Image = new Bitmap(b, pictureBox2.Size);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fill_button_Click(object sender, EventArgs e)
        {
            draw_button.Enabled = true;
            fill_button.Enabled = false;
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            draw_button.Enabled = false;
            fill_button.Enabled = true;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

