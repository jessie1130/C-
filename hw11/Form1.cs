using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw11
{
    public partial class Form1 : Form
    {
        List<int> heap = new List<int>();
        TextBox[] arr = new TextBox[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
            arr[0] = textBox3;
            arr[1] = textBox4;
            arr[2] = textBox5;
            arr[3] = textBox6;
            arr[4] = textBox7;
            arr[5] = textBox8;
            arr[6] = textBox9;
            arr[7] = textBox10;
            arr[8] = textBox11;
            arr[9] = textBox12;
            arr[10] = textBox13;
            arr[11] = textBox14;
            arr[12] = textBox15;
            arr[13] = textBox16;
            arr[14] = textBox17;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen grayPen = new Pen(Color.Gray, 1);
            g.DrawLine(grayPen, new Point(arr[0].Location.X, arr[0].Location.Y + 20), new Point(arr[1].Location.X + 20, arr[1].Location.Y));
            g.DrawLine(grayPen, new Point(arr[0].Location.X + 40, arr[0].Location.Y + 20), new Point(arr[2].Location.X + 20, arr[2].Location.Y));
            g.DrawLine(grayPen, new Point(arr[1].Location.X, arr[1].Location.Y + 20), new Point(arr[3].Location.X + 20, arr[3].Location.Y));
            g.DrawLine(grayPen, new Point(arr[1].Location.X + 40, arr[1].Location.Y + 20), new Point(arr[4].Location.X + 20, arr[4].Location.Y));
            g.DrawLine(grayPen, new Point(arr[2].Location.X, arr[2].Location.Y + 20), new Point(arr[5].Location.X + 20, arr[5].Location.Y));
            g.DrawLine(grayPen, new Point(arr[2].Location.X + 40, arr[2].Location.Y + 20), new Point(arr[6].Location.X + 20, arr[6].Location.Y));
            g.DrawLine(grayPen, new Point(arr[3].Location.X, arr[3].Location.Y + 20), new Point(arr[7].Location.X + 20, arr[7].Location.Y));
            g.DrawLine(grayPen, new Point(arr[3].Location.X + 40, arr[3].Location.Y + 20), new Point(arr[8].Location.X + 20, arr[8].Location.Y));
            g.DrawLine(grayPen, new Point(arr[4].Location.X, arr[4].Location.Y + 20), new Point(arr[9].Location.X + 20, arr[9].Location.Y));
            g.DrawLine(grayPen, new Point(arr[4].Location.X + 40, arr[4].Location.Y + 20), new Point(arr[10].Location.X + 20, arr[10].Location.Y));
            g.DrawLine(grayPen, new Point(arr[5].Location.X, arr[5].Location.Y + 20), new Point(arr[11].Location.X + 20, arr[11].Location.Y));
            g.DrawLine(grayPen, new Point(arr[5].Location.X + 40, arr[5].Location.Y + 20), new Point(arr[12].Location.X + 20, arr[12].Location.Y));
            g.DrawLine(grayPen, new Point(arr[6].Location.X, arr[6].Location.Y + 20), new Point(arr[13].Location.X + 20, arr[13].Location.Y));
            g.DrawLine(grayPen, new Point(arr[6].Location.X + 40, arr[6].Location.Y + 20), new Point(arr[14].Location.X + 20, arr[14].Location.Y));
        }
        public void printHeap()
        {
            int i;
            for(i = 0;i <= 14; i++)
            {
                arr[i].Text = "";
            }
            for(i = 0;i < heap.Count; i++)
            {
                arr[i].Text += heap[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            heap.Add(n);
            int index = heap.IndexOf(n);
            while (index > 0)
            {
                int parent = (index + 1) / 2 - 1;
                if (n > heap[parent])
                {
                    heap[index] = heap[parent];
                    heap[parent] = n;
                }
                else break;
                index = heap.IndexOf(n);
            }
            textBox1.Text = "";
            printHeap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(arr[0].Text);
            int index = heap.Count - 1;
            heap[0] = heap[index];
            heap.RemoveAt(index);
            index = 0;
            int childen = (index + 1) * 2 - 1;
            int i = 0;
            while(true)
            {
                int t;
                if (childen < heap.Count)
                {
                    if (childen + 1 < heap.Count)
                    {
                        if ((heap[index] < heap[childen] || heap[index] < heap[childen + 1]))
                        {
                            if (heap[childen + 1] < heap[childen])
                            {
                                t = heap[index];
                                heap[index] = heap[childen];
                                heap[childen] = t;
                                index = childen;
                            }
                            else
                            {
                                t = heap[index];
                                heap[index] = heap[childen + 1];
                                heap[childen + 1] = t;
                                index = childen + 1;
                            }
                        }
                        else break;
                    }
                    else
                    {
                        if (heap[index] < heap[childen])
                        {
                            t = heap[index];
                            heap[index] = heap[childen];
                            heap[childen] = t;
                            index = childen;
                        }
                        else break;
                    }
                }
                else break;
                childen = (index + 1) * 2 - 1;
                Console.WriteLine(i+" "+index + " " + childen);
                i++;
            }
            textBox2.Text = "" + n;
            printHeap();
        }
    }
}
