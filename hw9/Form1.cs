using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw9
{
    public partial class Form1 : Form
    {
        static node head = new node(0);
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "head->null";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                node x = new node(n);
                node ptr1 = head;
                node ptr2 = head.getNext();
                while(ptr2 != null)
                {
                    if (ptr2.getData() == n)
                    {
                        MessageBox.Show("資料" + n + "重複", "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        write();
                        return;
                    }
                    if (ptr2.getData() > n)
                    {
                        ptr1.setNext(x);
                        x.setNext(ptr2);
                        write();
                        return;
                    }
                    ptr1 = ptr2;
                    ptr2 = ptr2.getNext();
                }
                ptr1.setNext(x);
                x.setNext(null);
                write();
                return;
            }
            catch
            {
                textBox1.Text = "";
                write();
                MessageBox.Show("輸入字串格是不正確", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                node ptr1 = head;
                node ptr2 = head.getNext();
                while (ptr2 != null)
                {
                    if(ptr2.getData() == n)
                    {
                        ptr1.setNext(ptr2.getNext());
                        write();
                        return;
                    }
                    if(ptr2.getData() > n)
                    {
                        MessageBox.Show("串列中沒有" + n, "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        write();
                        return;
                    }
                    ptr1 = ptr2;
                    ptr2 = ptr2.getNext();
                }
                write();
                MessageBox.Show("串列中沒有" + n, "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                write();
                MessageBox.Show("輸入字串格是不正確", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void write()
        {
            textBox2.Text = "head->";
            node ptr1 = head.getNext();
            while (ptr1 != null)
            {
                textBox2.Text = textBox2.Text + ptr1.getData() + "->";
                ptr1 = ptr1.getNext();
            }
            textBox2.Text = textBox2.Text + "null";
        }
    }
}
