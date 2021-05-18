using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpilepticniNapad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool down;
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Enabled = !timer1.Enabled;

        }
        Random r = new Random();
        int x, y;
        private void timer1_Tick(object sender, EventArgs e)

        {
            if (down)
            {
                Graphics g = CreateGraphics();
                Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), r.Next(1, 6));

                int x1 = r.Next(ClientRectangle.Width);
                int y1 = r.Next(ClientRectangle.Height);
                g.DrawLine(olovka, x, y, x1, y1);
            }


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }
    }
}

