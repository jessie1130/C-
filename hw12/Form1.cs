using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw12
{
    public partial class Form1 : Form
    {
        int[,] Initial = new int[10, 10];
        int[,] ShortTest = new int[10, 10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen GrayPen = new Pen(Color.Gray, 1);
            g.DrawLine(GrayPen, new Point(label1.Location.X + 7, label1.Location.Y + 5), new Point(label2.Location.X + 7, label2.Location.Y));
            g.DrawLine(GrayPen, new Point(label1.Location.X, label1.Location.Y + 10), new Point(label3.Location.X, label3.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label1.Location.X, label1.Location.Y + 5), new Point(label4.Location.X, label4.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label2.Location.X, label2.Location.Y + 10), new Point(label4.Location.X, label4.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label2.Location.X, label2.Location.Y + 5), new Point(label5.Location.X, label5.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label3.Location.X + 7, label3.Location.Y + 5), new Point(label4.Location.X + 7, label4.Location.Y));
            g.DrawLine(GrayPen, new Point(label3.Location.X, label3.Location.Y + 5), new Point(label6.Location.X, label6.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label4.Location.X, label4.Location.Y + 10), new Point(label6.Location.X, label6.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label4.Location.X + 7, label4.Location.Y + 5), new Point(label5.Location.X + 7, label5.Location.Y));
            g.DrawLine(GrayPen, new Point(label4.Location.X, label4.Location.Y + 5), new Point(label7.Location.X, label7.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label5.Location.X, label5.Location.Y + 10), new Point(label7.Location.X, label7.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label6.Location.X + 7, label6.Location.Y + 5), new Point(label7.Location.X + 7, label7.Location.Y));
            g.DrawLine(GrayPen, new Point(label6.Location.X, label6.Location.Y + 10), new Point(label8.Location.X, label8.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label6.Location.X, label6.Location.Y + 5), new Point(label9.Location.X, label9.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label7.Location.X, label7.Location.Y + 10), new Point(label9.Location.X, label9.Location.Y + 10));
            g.DrawLine(GrayPen, new Point(label7.Location.X, label7.Location.Y + 5), new Point(label10.Location.X, label10.Location.Y + 5));
            g.DrawLine(GrayPen, new Point(label8.Location.X + 7, label8.Location.Y + 5), new Point(label9.Location.X + 7, label9.Location.Y));
            g.DrawLine(GrayPen, new Point(label9.Location.X + 7, label9.Location.Y + 5), new Point(label10.Location.X + 7, label10.Location.Y));
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start ,end;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    Initial[i, j] = 10000;
            try
            {
                Initial[0, 1] = Convert.ToInt32(AB.Text);
                Initial[1, 0] = Convert.ToInt32(AB.Text);
                Initial[0, 2] = Convert.ToInt32(AC.Text);
                Initial[2, 0] = Convert.ToInt32(AC.Text);
                Initial[0, 3] = Convert.ToInt32(AD.Text);
                Initial[3, 0] = Convert.ToInt32(AD.Text);
                Initial[1, 3] = Convert.ToInt32(BD.Text);
                Initial[3, 1] = Convert.ToInt32(BD.Text);
                Initial[1, 4] = Convert.ToInt32(BE.Text);
                Initial[4, 1] = Convert.ToInt32(BE.Text);
                Initial[2, 3] = Convert.ToInt32(CD.Text);
                Initial[3, 2] = Convert.ToInt32(CD.Text);
                Initial[2, 5] = Convert.ToInt32(CF.Text);
                Initial[5, 2] = Convert.ToInt32(CF.Text);
                Initial[3, 4] = Convert.ToInt32(DE.Text);
                Initial[4, 3] = Convert.ToInt32(DE.Text);
                Initial[3, 5] = Convert.ToInt32(DF.Text);
                Initial[5, 3] = Convert.ToInt32(DF.Text);
                Initial[3, 6] = Convert.ToInt32(DG.Text);
                Initial[6, 3] = Convert.ToInt32(DG.Text);
                Initial[4, 6] = Convert.ToInt32(EG.Text);
                Initial[6, 4] = Convert.ToInt32(EG.Text);
                Initial[5, 6] = Convert.ToInt32(FG.Text);
                Initial[6, 5] = Convert.ToInt32(FG.Text);
                Initial[5, 7] = Convert.ToInt32(FH.Text);
                Initial[7, 5] = Convert.ToInt32(FH.Text);
                Initial[5, 8] = Convert.ToInt32(FI.Text);
                Initial[8, 5] = Convert.ToInt32(FI.Text);
                Initial[6, 8] = Convert.ToInt32(GI.Text);
                Initial[8, 6] = Convert.ToInt32(GI.Text);
                Initial[6, 9] = Convert.ToInt32(GJ.Text);
                Initial[9, 6] = Convert.ToInt32(GJ.Text);
                Initial[7, 8] = Convert.ToInt32(HI.Text);
                Initial[8, 7] = Convert.ToInt32(HI.Text);
                Initial[8, 9] = Convert.ToInt32(IJ.Text);
                Initial[9, 8] = Convert.ToInt32(IJ.Text);
                start = (int)textBox19.Text[0] - (int)'A';
                end = (int)textBox20.Text[0] - (int)'A';
            }
            catch
            {
                MessageBox.Show("路徑公里數必須輸入數字!", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for(int i =0;i < 10; i++)
            {
                for(int j = 0; j< 10; j++)
                {
                    ShortTest[i, j] = Initial[i, j];
                }
            }
            for(int k = 0; k < 10; k++)
            {
                for(int i = 0; i < 10; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        ShortTest[i, j] = Math.Min(ShortTest[i, j], ShortTest[i, k] + ShortTest[k, j]);
                    }
                }
            }
            textBox22.Text = "" + ShortTest[start, end];
            textBox21.Text = "" + textBox19.Text[0];
            path(start, end);
            textBox21.Text += " --> " + textBox20.Text[0];
        }
        void path(int s, int e)
        {
            for(int i = 0; i < 10; i++)
            {
                if(ShortTest[s,e] == Initial[s,i] + ShortTest[i, e])
                {
                    textBox21.Text += " --> " + (char)((int)'A' + i);
                    path(i, e);
                }
            }
        }
    }
}
