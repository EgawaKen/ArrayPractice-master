using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);
        int vxx = rand.Next(-20, 21);
        int vyy = rand.Next(-20, 21);
        int vxxx = rand.Next(-20, 21);
        int vyyy = rand.Next(-20, 21);
        int score = 100;

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Height - label1.Height);
            label3.Left = rand.Next(ClientSize.Width - label1.Width);
            label3.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score--;
            scoreLabel.Text = $"Score {score:000}";

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            Point fpos = PointToClient(MousePosition);

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                label1.Visible = false;
            }

            label2.Left += vxx;
            label2.Top += vyy;

            if (label2.Left < 0)
            {
                vxx = Math.Abs(vxx);
            }
            if (label2.Top < 0)
            {
                vyy = Math.Abs(vyy);
            }
            if (label2.Right > ClientSize.Width)
            {
                vxx = -Math.Abs(vxx);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vyy = -Math.Abs(vyy);
            }

            if ((fpos.X >= label2.Left)
                && (fpos.X < label2.Right)
                && (fpos.Y >= label2.Top)
                && (fpos.Y < label2.Bottom))
            {
                label2.Visible = false;
            }

            label3.Left += vxxx;
            label3.Top += vyyy;

            if (label3.Left < 0)
            {
                vxxx = Math.Abs(vxxx);
            }
            if (label3.Top < 0)
            {
                vyyy = Math.Abs(vyyy);
            }
            if (label3.Right > ClientSize.Width)
            {
                vxxx = -Math.Abs(vxxx);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vyyy = -Math.Abs(vyyy);
            }

            if ((fpos.X >= label3.Left)
                && (fpos.X < label3.Right)
                && (fpos.Y >= label3.Top)
                && (fpos.Y < label3.Bottom))
            {
                label3.Visible = false;
            }

            if ((label1.Visible == false) && (label2.Visible == false) && (label3.Visible == false))
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}