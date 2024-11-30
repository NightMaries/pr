using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr9
{
    public partial class Form1 : Form
    {

        Point[] points = new Point[50];
        Pen pen = new Pen(Color.Black, 2);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Rectangle rect = new Rectangle(50,50,250,250);
            Graphics g = e.Graphics;

            //SolidBrush служит для того чтобы задать цвет
            //после него идут значения для позиции где (x)100,(y)130,(ширина)40,(высота)40

            //рисуется круг для черепа
            g.FillEllipse(new SolidBrush(Color.FromArgb(0, 0, 0)),rect);
            //рисование глаз

            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 255, 255)), 100, 130, 40, 40);
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 255, 255)), 200, 130, 40, 40);

            //рисование зубов
            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 265, 230, 60, 80);

            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 110, 230, 25, 80);

            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 160, 230, 25, 80);

            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 210, 230, 25, 80);

            g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 25, 230, 60, 80);
        }

    }
}
