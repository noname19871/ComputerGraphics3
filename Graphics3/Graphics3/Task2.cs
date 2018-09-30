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
    public partial class Task2 : Form
    {

        public Task2()
        {
            InitializeComponent();
        }

        //Open the file
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //looking for the next point in a counter-clockwise direction
        Point find_new_point(int current_direction, Point p)
        {
            switch(current_direction)
            {
                case 7:
                    return new Point(p.X + 1, p.Y + 1);
                case 6:
                    return new Point(p.X, p.Y + 1);
                case 5:
                    return new Point(p.X - 1, p.Y + 1);
                case 4:
                    return new Point(p.X - 1, p.Y);
                case 3:
                    return new Point(p.X - 1, p.Y - 1);
                case 2:
                    return new Point(p.X, p.Y - 1);
                case 1:
                    return new Point(p.X + 1, p.Y - 1);
                case 0:
                    return new Point(p.X + 1, p.Y);
                default:
                    return p;
            }
        }

        //Returns list of points in outdoor border of the area
        List<Point> find_outdoor_border(int x, int y, Image img)
        {
            List<Point> points = new List<Point>();
            Bitmap bmp = new Bitmap(img);

            Color start_color = bmp.GetPixel(x, y);
            int border_x = bmp.Width - 1;

            Color outdoor_color = bmp.GetPixel(border_x, y);
            Color layout = start_color;

            while (start_color != outdoor_color)
            {
                border_x = border_x - 1;
                outdoor_color = bmp.GetPixel(border_x, y);
            }

            int current_direction = 8;
            int previous_direction = 8;

            Point start_point = new Point(border_x + 1, y);
            Point next_point = start_point;

            while (true)
            {
                if (current_direction - 2 < 0)
                    current_direction = 6;
                else
                    current_direction -= 2;

                while (true)
                {
                    next_point = find_new_point(current_direction, start_point);
                    if (bmp.GetPixel(next_point.X, next_point.Y) == layout)
                    {
                        start_point = next_point;
                        break;
                    }
                    else
                        current_direction += 1;
                    current_direction = current_direction % 8;
                }

                bool found = false;
                foreach (Point p in points)
                    if (p.X == start_point.X && p.Y == start_point.Y)
                    {
                        found = true;
                        break;
                    }
                if (found)
                    break;
                else
                {
                    points.Add(start_point);
                    previous_direction = current_direction;
                }
            }
            return points;
        }

        //Returns maximum X value in the area
        int find_x_range(List<Point> points)
        {
            int max_x = 0;
            foreach(Point p in points)
            {
                if (p.X > max_x)
                    max_x = p.X;
            }
            return max_x;
        }

        bool find_first_inner_point(List<Point> points, Image img, Color start_color, ref Point start_point)
        {
            var tmp = points.OrderByDescending(p => p.Y);
            Bitmap bmp = new Bitmap(img);
            int max_x = find_x_range(points);
            Color layout = bmp.GetPixel(0, 0);

            foreach (Point p in tmp)
            {
                bool found_layout = false;
                bool found_start_color = false;
                Point res = new Point();

                int cur_x = p.X + 1;
                while (true)
                {
                    if (cur_x >= max_x)
                        break;
                    Color cur = bmp.GetPixel(cur_x, p.Y);

                    if (found_layout && cur == start_color)
                    {
                        found_start_color = true;
                        break;
                    }

                    if (cur == layout)
                    {
                        res = new Point(cur_x, p.Y);
                        found_layout = true;
                    }
                    cur_x++;
                }

                if (found_start_color)
                {
                    start_point = res;
                    return true;
                }
            }
            return false;
        }

        List<Point> find_inner_border(int x, int y, Image img, Point start_point)
        {
            List<Point> points = new List<Point>();
            Bitmap bmp = new Bitmap(img);
            Color layout = bmp.GetPixel(0, 0);
            Point next_point = start_point;

            int current_direction = 8;
            int previous_direction = 8;

            while (true)
            {
                if (current_direction - 2 < 0)
                    current_direction = 6;
                else
                    current_direction -= 2;

                while (true)
                {
                    next_point = find_new_point(current_direction, start_point);
                    if (bmp.GetPixel(next_point.X, next_point.Y) == layout)
                    {
                        start_point = next_point;
                        break;
                    }
                    else
                        current_direction += 1;
                    current_direction = current_direction % 8;
                }

                bool found = false;
                foreach (Point p in points)
                {
                    if (p.X == start_point.X && p.Y == start_point.Y)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
                else
                {
                    points.Add(start_point);
                    previous_direction = current_direction;
                }
            }
            return points;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Не удалось получить картинку", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var location = e.Location;
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            List<Point> outdoor_points = find_outdoor_border(location.X, location.Y, pictureBox1.Image);
            Point start_point = new Point(0,0);
            if (find_first_inner_point(outdoor_points, pictureBox1.Image, bmp.GetPixel(location.X,location.Y), ref start_point))
            {
                List<Point> inner_points = find_inner_border(location.X, location.Y, pictureBox1.Image, start_point);
                foreach (Point pt in inner_points)
                    bmp.SetPixel(pt.X, pt.Y, Color.Red);
            }
            foreach (Point pt in outdoor_points)
                bmp.SetPixel(pt.X, pt.Y, Color.Red);

            pictureBox1.Image = bmp;
        }
    }
}
