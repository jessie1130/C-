using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8
{
   
    public partial class Form1 : Form
    {
        Queue q = new Queue();
        TextBox[] board = new TextBox[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board[0] = textBox3;
            board[1] = textBox4;
            board[2] = textBox5;
            board[3] = textBox6;
            board[4] = textBox7;
            board[5] = textBox8;
            board[6] = textBox9;
            board[7] = textBox10;
            textBox11.Text = "" + q.front;
            textBox12.Text = "" + q.rear;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                num = Convert.ToInt32(textBox1.Text);
                q.enqueue(num);
                board[q.rear].Text = "" + num;
            }
            catch
            {
                MessageBox.Show("輸入字串格是不正確", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox11.Text = "" + q.front;
            textBox12.Text = "" + q.rear;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int num = q.dequeue();
            board[q.front].Text = "";
            textBox2.Text = "" + num;
            textBox11.Text = "" + q.front;
            textBox12.Text = "" + q.rear;
        }
    }
}
