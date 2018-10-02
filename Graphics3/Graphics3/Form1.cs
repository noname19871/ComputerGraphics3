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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            Task2 t = new Task2();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1A t = new Task1A();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task1B t = new Task1B();
            t.Show();
        }
    }
}
