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
    public partial class Task1A : Form
    {
        Bitmap bmp;
        List<Point> points = new List<Point>();
        bool mouse_down = false;
        Graphics g;
        Pen needColor;

        public Task1A()
        {
            InitializeComponent();
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown1);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove1);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp1);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = (Bitmap)pictureBox1.Image;
            Clear();
            colorDialog1.Color = Color.Red;
            needColor = new Pen(colorDialog1.Color);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void Clear()
        {
            mouse_down = false;
            points.Clear();
            var g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void pictureBox1_MouseDown1(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            points.Add(e.Location);
        }

        private void pictureBox1_MouseMove1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mouse_down)
            {
                points.Add(e.Location);
                int val = trackBar1.Value;
                g.DrawLines(new Pen(Color.Black, val), points.ToArray());
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseUp1(object sender, MouseEventArgs e)
        {
            points.Clear();
            mouse_down = false;
        }

        private void pictureBox1_MouseDown2(object sender, MouseEventArgs e)
        {
            Point firstPoint = new Point(e.X, e.Y);
            fill(firstPoint);
        }

        private bool equalColors(Color c1, Color c2)
        {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }

        private void fill(Point p)
        {
            Color start_color = bmp.GetPixel(p.X, p.Y);
            if (0 <= p.X && p.X < bmp.Width && 0 <= p.Y && p.Y < bmp.Height - 1 && !equalColors(start_color, Color.Black) &&
                !equalColors(start_color, needColor.Color))
            {
                Point left_border = new Point(p.X, p.Y);
                Point right_border = new Point(p.X, p.Y);
                Color current_color = start_color;
                while (0 < left_border.X && !equalColors(current_color, Color.Black))
                {
                    left_border.X -= 1;
                    current_color = bmp.GetPixel(left_border.X, p.Y);
                }
                current_color = start_color;
                while (right_border.X < pictureBox1.Width - 1 && !equalColors(current_color, Color.Black))
                {
                    right_border.X += 1;
                    current_color = bmp.GetPixel (right_border.X, p.Y);
                }
                if (left_border.X != 0)
                    left_border.X += 1;
                right_border.X -= 1;
                g.DrawLine(needColor, left_border, right_border);
                pictureBox1.Image = bmp;

                for (int i = left_border.X; i < right_border.X + 1; ++i)
                    fill(new Point(i, p.Y + 1));

                for (int i = left_border.X; i < right_border.X + 1; ++i)
                    if (p.Y > 0)
                        fill(new Point(i, p.Y - 1));
            }
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            needColor.Color = c;
        }

        private void fill_button_Click(object sender, EventArgs e)
        {
            
            pictureBox1.MouseDown -= pictureBox1_MouseDown1;
            pictureBox1.MouseMove -= pictureBox1_MouseMove1;
            pictureBox1.MouseUp -= pictureBox1_MouseUp1;
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown2);

            points.Clear();
            draw_button.Enabled = true;
            fill_button.Enabled = false;
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown -= pictureBox1_MouseDown2;
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown1);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove1);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp1);
            draw_button.Enabled = false;
            fill_button.Enabled = true;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
