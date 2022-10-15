using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNIST.IO
{
    public partial class imageViewer : UserControl
    {
        public imageViewer()
        {
            InitializeComponent();
        }
        Graphics g;
        System.Drawing.SolidBrush b1 = new SolidBrush(Color.White);
        System.Drawing.SolidBrush b2 = new SolidBrush(Color.Black);

        struct Matrix
        {
            public int w, h;
            public Rectangle[] recf;
            public void generate(int H,int W,int bw,int bh)
            {
                this.w = W;
                this.h = H;
                this.recf = new Rectangle[this.w * this.h];
                int k = 0;
                for (int i = 0; i < this.w; i++)
                {
                    for (int j = 0; j < this.h; j++)
                    {
                        this.recf[k] = new Rectangle();
                        this.recf[k].Location = new System.Drawing.Point
                            (i * bw + 1, j * bh + 1);
                        this.recf[k].Size = new System.Drawing.Size(bw, bh);
                        k++;
                    }
                }
            }
        }
        Matrix m;
        double[] image;
        public void Clear()
        {
            m.generate(28, 28, 5, 5);
            image = new double[28 * 28]; ;
            g = panel1.CreateGraphics(); this.DoubleBuffered = true;
            for (int i = 0; i < m.h; i++)
            {
                for (int j = 0; j < m.w; j++)
                {
                    image[i + m.h * j] = -1.0d;
                    b1 = new SolidBrush(Color.FromArgb((int)((image[i + m.h * j] + 1) * 127 + 1), (int)((image[i + m.h * j] + 1) * 127 + 1), (int)((image[i + m.h * j] + 1) * 127 + 1)));
                    g.FillRectangle(b1, m.recf[i + m.h * j]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[i + m.h * j]);
                }
            }
            this.Paint += new PaintEventHandler(UserControl1_Paint);
            panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
        }
        public void inti(double[] Image, int H, int W, int bw, int bh)
        {
            m.generate(H, W, bw, bh);
            image = Image;
            g = panel1.CreateGraphics(); this.DoubleBuffered = true;
            for (int i = 0; i < m.h; i++)
            {
                for (int j = 0; j < m.w; j++)
                {
                    b1 = new SolidBrush(Color.FromArgb((int)((image[i + m.h * j] + 1) * 127 + 1), (int)((image[i + m.h * j] + 1) * 127 + 1), (int)((image[i + m.h * j] + 1) * 127 + 1)));
                    g.FillRectangle(b1, m.recf[i + m.h * j]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[i + m.h * j]);
                }
            }
            this.Paint += new PaintEventHandler(UserControl1_Paint);
            panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
        }
        public double[] Image
        {
            get { return image; }
        }
        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int mouseX = e.X;
                int mouseY = e.Y;
                Point RecLoc = new Point((e.X - 1) / 5, (e.Y - 1) / 5);
                //MessageBox.Show(e.X + "   " + e.Y);
                try
                {
                    if (image[RecLoc.Y + m.h * RecLoc.X] == -1) image[RecLoc.Y + m.h * RecLoc.X] = 1;
                    if (image[RecLoc.Y + m.h * RecLoc.X + 1] == -1) image[RecLoc.Y + m.h * RecLoc.X + 1] = 1;
                    if (image[RecLoc.Y + m.h * RecLoc.X - 1] == -1) image[RecLoc.Y + m.h * RecLoc.X - 1] = 1;
                    
                    b1 = new SolidBrush(Color.FromArgb(((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1, ((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1, ((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1));
                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X +  RecLoc.Y]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[ m.h * RecLoc.X +RecLoc.Y]);

                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X + RecLoc.Y + 1]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[m.h * RecLoc.X + RecLoc.Y + 1]);

                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X + RecLoc.Y - 1]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[m.h * RecLoc.X + RecLoc.Y - 1]);
                }
                catch (Exception ex)
                {
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int mouseX = e.X;
                int mouseY = e.Y;
                Point RecLoc = new Point((e.X - 1) / 5, (e.Y - 1) / 5);
                //label2.Text = RecLoc.X + "  :  " + RecLoc.Y;
                try
                {
                    if (image[RecLoc.Y + m.h * RecLoc.X] == 1) image[RecLoc.Y + m.h * RecLoc.X] = -1;
                    if (image[RecLoc.Y + m.h * RecLoc.X + 1] == 1) image[RecLoc.Y + m.h * RecLoc.X + 1] = -1;
                    if (image[RecLoc.Y + m.h * RecLoc.X - 1] == 1) image[RecLoc.Y + m.h * RecLoc.X - 1] = -1;

                    b1 = new SolidBrush(Color.FromArgb(((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1, ((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1, ((int)image[RecLoc.Y + m.h * RecLoc.X] + 1) * 127 + 1));
                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X + RecLoc.Y]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[m.h * RecLoc.X + RecLoc.Y]);

                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X + RecLoc.Y + 1]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[m.h * RecLoc.X + RecLoc.Y + 1]);

                    g.FillRectangle(b1, m.recf[m.h * RecLoc.X + RecLoc.Y - 1]);
                    g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[m.h * RecLoc.X + RecLoc.Y - 1]);
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void imageViewer_Load(object sender, EventArgs e)
        {
           
        }
        private void UserControl1_Paint(object o, PaintEventArgs e)
        {
            //panel1.Width = m.w * 10 + 10;
            //panel1.Height = m.h * 10 + 10;
            //this.Width = m.w * 10 + 10;
            //this.Height = m.w * 10 + 10;
            for (int i = 0; i < m.h; i++)
            {
                for (int j = 0; j < m.w; j++)
                {
                    b1 = new SolidBrush(Color.FromArgb(((int)(image[i + m.h * j])), (int)((image[i + m.h * j])), (int)((image[i + m.h * j]))));
                        g.FillRectangle(b1, m.recf[i + m.h * j]);
                        g.DrawRectangle(new Pen(b2.Color, 0.1f), m.recf[i + m.h * j]);                   
                }
            }         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
