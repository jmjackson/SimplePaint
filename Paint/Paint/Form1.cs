using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Paint
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints;
        bool pencilDown;
        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            pencilDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            listOfPoints.Add(point);
            pencilDown = true;
            this.statusStrip1.Items[0].Text = "Mouse Down";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point p = new Point(e.X, e.Y);
            Pen pencil = new Pen(Color.Blue);
            if (pencilDown)
            {
                this.statusStrip1.Items[0].Text = "Mouse MOve";
                if (listOfPoints.Count>1)
                {
                    g.DrawLine(pencil, (Point)listOfPoints[listOfPoints.Count - 1], p);
                }
                listOfPoints.Add(p);
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pencilDown = false;
            this.statusStrip1.Items[0].Text = "Mouse Up";
        }
    }
}
