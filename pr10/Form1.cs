using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зк10
{
    public partial class Form1 : Form
    {
        public int leafSpeed = 2;
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer animationTimer = new Timer
            {
                Interval = 20 // Скорость обновления (мс)
            };
            animationTimer.Tick +=timer1_Tick;
            animationTimer.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            var newLocation = pictureBox2.Location;
            newLocation.Y += leafSpeed;
            newLocation.X += random.Next(-2, 3);
            pictureBox2.PointToScreen(new Point(100,200));
            
        }

    }
}
