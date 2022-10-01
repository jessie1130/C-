using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw10
{
    public partial class Form1 : Form
    {
        static node root = new node(0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            node ptr1 = root;
            node ptr2 = root.getLeft();
            node x = new node(n);
            if(ptr2 == null)
            {
                root.setLeft(x);
                inorder(root.getLeft());
                return;
            }
            while(ptr2 != null)
            {
                if(ptr2.getData() == n)
                {
                    MessageBox.Show("資料" + n + "已存在", "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inorder(root.getLeft());
                    return;
                }
                ptr1 = ptr2;
                if(n < ptr2.getData())
                {
                    ptr2 = ptr2.getLeft();
                }
                else
                {
                    ptr2 = ptr2.getRight();
                }
            }
            if(n < ptr1.getData())
            {
                ptr1.setLeft(x);
            }
            else
            {
                ptr1.setRight(x);
            }
            inorder(root.getLeft());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Delete(n);
            textBox1.Text = "";
            textBox2.Text = "";
            inorder(root.getLeft());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            preorder(root.getLeft());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            inorder(root.getLeft());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            postorder(root.getLeft());
        }
        void inorder(node ptr)
        {
            if(ptr != null)
            {
                inorder(ptr.getLeft());
                textBox2.Text += " " + ptr.getData();
                inorder(ptr.getRight());
            }
        }
        void preorder(node ptr)
        {
            if (ptr != null)
            {
                textBox2.Text += " " + ptr.getData();
                preorder(ptr.getLeft());
                preorder(ptr.getRight());
            }
        }
        void postorder(node ptr)
        {
            if (ptr != null)
            {
                postorder(ptr.getLeft());
                postorder(ptr.getRight());
                textBox2.Text += " " + ptr.getData();
            }
        }

        void Delete(int n)
        {
            node Ptr1 = root;
            node Ptr2 = root.getLeft();
            node Ptr3;
            while (Ptr2 != null)
            {
                if (n == Ptr2.getData())
                    break;
                if (n < Ptr2.getData())
                {
                    Ptr1 = Ptr2;
                    Ptr2 = Ptr2.getLeft();
                }
                else
                {
                    Ptr1 = Ptr2;
                    Ptr2 = Ptr2.getRight();
                }
            }
            if (Ptr2 == null)
            {
                MessageBox.Show("資料" + n + "不存在", "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Ptr2.getLeft() == null && Ptr2.getRight() == null)
                {
                    if (Ptr1.getLeft() == Ptr2)
                    {
                        Ptr1.setLeft(null);
                        return;
                    }
                    else
                    {
                        Ptr1.setRight(null);
                        return;
                    }
                }
                else if (Ptr2.getLeft() == null && Ptr2.getRight() != null)
                {
                    if (Ptr1.getLeft() == Ptr2)
                    {
                        Ptr1.setLeft(Ptr2.getRight());
                        return;
                    }
                    else
                    {
                        Ptr1.setRight(Ptr2.getRight());
                        return;
                    }
                }
                else if (Ptr2.getLeft() != null && Ptr2.getRight() == null)
                {
                    if (Ptr1.getLeft() == Ptr2)
                    {
                        Ptr1.setLeft(Ptr2.getLeft());
                        return;
                    }
                    else
                    {
                        Ptr1.setRight(Ptr2.getLeft());
                        return;
                    }
                }
                else if (Ptr2.getLeft() != null && Ptr2.getRight() != null)
                {
                    Ptr3 = Ptr2.getLeft();
                    while (Ptr3.getRight() != null)
                        Ptr3 = Ptr3.getRight();
                    Delete(Ptr3.getData());
                    Ptr2.setData(Ptr3.getData());
                }
            }
        }

    }
}
