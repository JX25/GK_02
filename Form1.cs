using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GK_02
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Red, 1);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Teal, 1);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Figura  1.2a
        {
            pictureBox1.Refresh();
            PointF srodek = new PointF(250, 250);
            PointF punkt = new PointF(250, 250);
            PointF punkt2 = new PointF();

            float kat = 0;
            float dkat = (float)(Math.PI * 2 / 100);
            for (int n=0; n<=100; n++)
            {
                punkt2.X = 150 * (float)Math.Cos(kat) + srodek.X;
                punkt2.Y = 150 * (float)Math.Sin(kat) + srodek.Y;
                if(n!=0)g.DrawLine(pen1, punkt, punkt2);
                punkt = punkt2;
                kat += dkat;
            }


        }

        private void button2_Click(object sender, EventArgs e) // Figura 1.2b
        {
            pictureBox1.Refresh();
            PointF srodek = new PointF(250, 250);
            PointF punkt = new PointF(250, 250);
            PointF punkt2 = new PointF();

            float kat = 0;
            float dkat = (float)(360 / 120);
            for (int n = 0; n <= 120; n++)
            {
                punkt2.X = 150 * (float)Math.Cos(kat) + srodek.X;
                punkt2.Y = 150 * (float)Math.Sin(kat) + srodek.Y;
                if (n != 0) g.DrawLine(pen1, punkt, punkt2);
                punkt = punkt2;
                kat += dkat;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Figura 1.3
        {
            pictureBox1.Refresh();
            float d = 50;
            float third = 500;
            float fourth = 500;
            g.DrawEllipse(pen1, 0, 0, third, fourth);

            for(int i=1; i<5; i++)
            {
                third -= 100;
                g.DrawEllipse(pen1, d*(i-1), d*i, fourth, third );
                g.DrawEllipse(pen1, d*i, d*(i -1), third, fourth);
                fourth = third;
            }

        }

        private void button4_Click(object sender, EventArgs e) // 1.4
        {
            pictureBox1.Refresh();
            float kat = (float)Math.PI / 48;
            float dkat = (float)(2 * Math.PI / 100);
            float r = 50;//(float)(kat/(Math.PI*2));
            float dr = r / 100;
            PointF srodek = new PointF(250, 250);
            PointF punkt = new PointF(250, 250);
            PointF punkt2 = new PointF();
            PointF punkt3 = new PointF();

            for (int n=0; n<400; n++)
            {
                kat += dkat;
                float rr = dr * n;
                punkt2.X = rr * (float)Math.Cos(kat) + srodek.X;
                punkt2.Y = rr * (float)Math.Sin(kat) + srodek.Y;
                g.DrawLine(pen1, punkt, punkt2);
                punkt = punkt2;
            }
        }

        private void button5_Click(object sender, EventArgs e) // 1.5
        {
            pictureBox1.Refresh();
            float kat = (float)Math.PI / 48;
            float kat3 = -kat;
            float kat2 = (float)Math.PI / 48;
            float kat4 = -kat2;
            float dkat = (float)(2 * Math.PI / 100);
            float ddkat = -dkat;
            //float dkat2 = (float)(2 * Math.PI / 100);
            float r = 50;//(float)(kat/(Math.PI*2));
            float r2 = 65;
            float dr = r / 100;
            float dr2 = r2 / 100;
            PointF srodek = new PointF(250, 250);

            PointF punkt1 = srodek;
            PointF punkt2 = new PointF();

            PointF punkt3 = srodek;
            PointF punkt4 = new PointF();

            PointF punkt5 = srodek;
            PointF punkt6 = new PointF();

            PointF punkt7 = srodek;
            PointF punkt8 = new PointF();

            for (int n = 0; n < 300; n++)
            {
                kat += dkat;
                kat2 += dkat;
                kat3 += ddkat;
                kat4 += ddkat;

                float rr = dr * n;
                float rr2 = dr2 * n;

                punkt2.X = rr * (float)Math.Cos(kat) + srodek.X;
                punkt2.Y = rr * (float)Math.Sin(kat) + srodek.Y;

                punkt4.X = rr2 * (float)Math.Cos(kat2) + srodek.X;
                punkt4.Y = rr2 * (float)Math.Sin(kat2) + srodek.Y;

                punkt6.X = -rr * (float)Math.Cos(kat3) + srodek.X;
                punkt6.Y = rr * (float)Math.Sin(kat3) + srodek.Y;

                punkt8.X = -rr2 * (float)Math.Cos(kat4) + srodek.X;
                punkt8.Y = rr2 * (float)Math.Sin(kat4) + srodek.Y;

              g.DrawLine(pen1, punkt1, punkt2);
              g.DrawLine(pen1, punkt3, punkt4);
              g.DrawLine(pen1, punkt5, punkt6);
              g.DrawLine(pen1, punkt7, punkt8);

                punkt1 = punkt2;
                punkt3 = punkt4;
                punkt5 = punkt6;
                punkt7 = punkt8;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            int N = (int)Double.Parse(textBox1.Text);
            PointF[] tablicaPunktow = new PointF[N];
            for(int i =1; i<=N; i++)
            {
                tablicaPunktow[i-1].X = (float) (6*Math.Cos(2*Math.PI*(i-1)/N))*30+250;
                tablicaPunktow[i-1].Y = (float)(6 * Math.Sin(2 * Math.PI * (i - 1) / N)) * 30 + 250;
            }

            for(int i=0; i<N; i++)
            {
                for (int j = i; j < N; j++) g.DrawLine(pen1, tablicaPunktow[j], tablicaPunktow[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // brak
        }

        private void button8_Click(object sender, EventArgs e)
        {
           //spirograf
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            // kwadraty w kwadratach
            const float mi = (float)0.2;
            float dx = 25;
            float dy = 25;
            //g.DrawRectangle(pen1, 25, 25, 450, 450);

            PointF point1 = new PointF();
            point1.X = 25;
            point1.Y = 25;
            PointF point2 = new PointF();
            point2.X = 475;
            point2.Y = 25;
            PointF point3 = new PointF();
            point3.X = 475;
            point3.Y = 475;
            PointF point4 = new PointF();
            point4.X = 25;
            point4.Y = 475;

            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point4);
            g.DrawLine(pen1, point4, point1);

            for (int i = 0; i < 30; i++)
            {
                PointF nowyPunkt1 = new PointF();
                nowyPunkt1.X = (9 * point1.X + point2.X) / 10;
                nowyPunkt1.Y = (9 * point1.Y + point2.Y) / 10;

                PointF nowyPunkt2 = new PointF();
                nowyPunkt2.X = (9 * point2.X + point3.X) / 10;
                nowyPunkt2.Y = (9 * point2.Y + point3.Y) / 10;

                PointF nowyPunkt3 = new PointF();
                nowyPunkt3.X = (9 * point3.X + point4.X) / 10;
                nowyPunkt3.Y = (9 * point3.Y + point4.Y) / 10;

                PointF nowyPunkt4 = new PointF();
                nowyPunkt4.X = (9 * point4.X + point1.X) / 10;
                nowyPunkt4.Y = (9 * point4.Y + point1.Y) / 10;


                g.DrawLine(pen1, nowyPunkt1, nowyPunkt2);
                g.DrawLine(pen1, nowyPunkt2, nowyPunkt3);
                g.DrawLine(pen1, nowyPunkt3, nowyPunkt4);
                g.DrawLine(pen1, nowyPunkt4, nowyPunkt1);

                point1 = nowyPunkt1;
                point2 = nowyPunkt2;
                point3 = nowyPunkt3;
                point4 = nowyPunkt4;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            // kwadraty w kwadratach
            // mi = tg[t* pi/4n] / tg[t* pi/4n]+1 n=20,t=3 mi ok 0.08
            float mi = (float)(Math.Tan(3*(Math.PI/80))/(Math.Tan(3 * (Math.PI / 80)) + 1) );
            //g.DrawRectangle(pen1, 25, 25, 450, 450);

            PointF point1 = new PointF();
            point1.X = 25;
            point1.Y = 25;
            PointF point2 = new PointF();
            point2.X = 475;
            point2.Y = 25;
            PointF point3 = new PointF();
            point3.X = 475;
            point3.Y = 475;
            PointF point4 = new PointF();
            point4.X = 25;
            point4.Y = 475;

            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point4);
            g.DrawLine(pen1, point4, point1);

            for (int i = 0; i < 10; i++)
            {
                PointF nowyPunkt1 = new PointF();
                nowyPunkt1.X = (1-mi)*point1.X+mi*point2.X;
                nowyPunkt1.Y = (1 - mi) * point1.Y + mi * point2.Y;

                PointF nowyPunkt2 = new PointF();
                nowyPunkt2.X = (1 - mi) * point2.X + mi * point3.X;
                nowyPunkt2.Y = (1 - mi) * point2.Y + mi * point3.Y;

                PointF nowyPunkt3 = new PointF();
                nowyPunkt3.X = (1 - mi) * point3.X + mi * point4.X;
                nowyPunkt3.Y = (1 - mi) * point3.Y + mi * point4.Y;

                PointF nowyPunkt4 = new PointF();
                nowyPunkt4.X = (1 - mi) * point4.X + mi * point1.X;
                nowyPunkt4.Y = (1 - mi) * point4.Y + mi * point1.Y;


                g.DrawLine(pen1, nowyPunkt1, nowyPunkt2);
                g.DrawLine(pen1, nowyPunkt2, nowyPunkt3);
                g.DrawLine(pen1, nowyPunkt3, nowyPunkt4);
                g.DrawLine(pen1, nowyPunkt4, nowyPunkt1);

                point1 = nowyPunkt1;
                point2 = nowyPunkt2;
                point3 = nowyPunkt3;
                point4 = nowyPunkt4;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // przerywana
            int dx = 5;
            int dy = 25;

            PointF punktStartowy = new PointF(0, 0);
            PointF nextPunkt = new PointF(dx, dy);
            for(int i=0; i<20; i++)
            {
                if(i%2==0)
                {
                    g.DrawLine(pen1, punktStartowy, nextPunkt);
                    punktStartowy = nextPunkt;
                    nextPunkt.X += dx;
                    nextPunkt.Y += dy;
                }
                else
                {
                    punktStartowy = nextPunkt;
                    nextPunkt.X += dx;
                    nextPunkt.Y += dy;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        private bool isFibonacci(int n)
        {
            // n is Fibinacci if one of 5*n*n + 4 or 5*n*n - 4 or both
            // is a perferct square
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }

        private int nwd(int a, int b)
        {

            int x = a, y = b;

            while (x != y)
            {

                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            int nd = x;
            return nd;
        }
    }
}
