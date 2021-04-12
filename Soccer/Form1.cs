using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Soccer
{
    public partial class Form1 : Form
    {
        static public int index = 0;
        public Entity ball;
        public static Form1 SelfRef { get; set; }
        public Form1()
        {
            SelfRef = this;
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            ball = new Entity(new Size(50, 50));

            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            ball.myPhysics.ApplyPhysics();
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ball.DrawSprite(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball.myPhysics.AddForceQuickly(0.2f);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Update1()
        {
            textBox1.Text = "Счёт:"+ index.ToString();
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
