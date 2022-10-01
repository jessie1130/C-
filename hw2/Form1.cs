using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace real_hw2
{
    public partial class Form1 : Form
    {
        double n1 = 0, n2 = 0;
        char op = ' ';
        bool num = true;
        bool point = false;
        bool pre = false;
        bool equ = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            n1 = 0;
            n2 = 0;
            op = ' ';
            num = true;
            point = false;
            pre = false;
            equ = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
            num = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
            num = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
            num = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
            num = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
            num = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
            num = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
            num = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
            num = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
            num = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (num == true || textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
            num = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!point)
            {
                if (num == true || textBox1.Text == "0")
                    textBox1.Text = "0.";
                else
                    textBox1.Text += ".";
            }
            num = false;
            point = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pre)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                display(n1, n2, op);
            }
            n1 = Convert.ToDouble(textBox1.Text);
            op = '+';
            num = true;
            pre = true;
            point = false;
            equ = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (pre)
                {
                    n2 = Convert.ToDouble(textBox1.Text);
                    display(n1, n2, op);
                }
                n1 = Convert.ToDouble(textBox1.Text);
                op = '-';
                num = true;
                pre = true;
                point = false;
                equ = false;  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pre)
                {
                    n2 = Convert.ToDouble(textBox1.Text);
                    display(n1, n2, op);
                }
                n1 = Convert.ToDouble(textBox1.Text);
                op = '*';
                num = true;
                pre = true;
                point = false;
                equ = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (pre)
                {
                    n2 = Convert.ToDouble(textBox1.Text);
                    display(n1, n2, op);
                }
                n1 = Convert.ToDouble(textBox1.Text);
                op = '/';
                num = true;
                pre = true;
                point = false;
                equ = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (equ)
            {
                n1 = Convert.ToDouble(textBox1.Text);
                display(n1, n2, op);
            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                display(n1, n2, op);
            }
            equ = true;
            point = false;
            num = true;
            pre = false;
        }

        public void display(double x, double y, char o)
        {
            if (o == '+')
                textBox1.Text = "" + (x + y);
            else if (o == '-')
                textBox1.Text = "" + (x - y);
            else if (o == '/')
                textBox1.Text = "" + (x / y);
            else
                textBox1.Text = "" + (x * y);
        }

    }
}
