using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgrNejakaVec
{
    public partial class Form1 : Form
    {
        private Point newPoint;
        private int time = 100;
        private int t = 0;
        private float movingX = 0.0f;
        private float movingY = 0.0f;

        private float x = 0.0f;
        private float y = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.newPoint = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
            //MessageBox.Show(this.newPoint.ToString());
            this.x = this.panel1.Location.X;
            this.y = this.panel1.Location.Y;

            this.movingX = (float)(newPoint.X - this.panel1.Location.X) / time;
            this.movingY = (float)(newPoint.Y - this.panel1.Location.Y) / time;
          
            //MessageBox.Show(movingX.ToString() + Environment.NewLine + movingY.ToString());
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.x += this.movingX;
            this.y += this.movingY;
            this.panel1.Location = new Point((int)x,
                                             (int)y);
            //MessageBox.Show(this.panel1.Location.ToString());
            if (this.panel1.Location.X == newPoint.X)
            {
                
                timer1.Enabled = false;
            }
        }
    }
}
