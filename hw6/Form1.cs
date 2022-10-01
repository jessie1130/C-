using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6
{
    public partial class Form1 : Form
    {
        Picture graph = new Picture("Graph");
        List<Picture> allPicture = new List<Picture>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            string newname;
            string container;
            if (f2.DialogResult == DialogResult.OK)
            {
                f2.GetData(out newname, out container);
                int i;
                for(i = 0; i < allPicture.Count; i++)
                {
                    if (container == allPicture[i].getName())
                    {
                        Picture x = new Picture(newname);
                        allPicture.Add(x);
                        allPicture[i].addComponent(x);
                        textBox1.Text = graph.show();
                        break;
                    }
                }
                if (i >= allPicture.Count)
                {
                    MessageBox.Show("不存在的Picture容器:" + container,"錯誤訊息",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            string newname;
            string container;
            double length;
            double width;
            if(f3.DialogResult == DialogResult.OK)
            {
                f3.GetData(out newname, out container, out length, out width);
                int i;
                for (i = 0; i < allPicture.Count; i++)
                {
                    if (container == allPicture[i].getName())
                    {
                        Rectangle x = new Rectangle(newname, length, width);
                        allPicture[i].addComponent(x);
                        textBox1.Text = graph.show();
                        break;
                    }
                }
                if (i >= allPicture.Count)
                {
                    MessageBox.Show("不存在的Picture容器:" + container, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "{Pictere Graph:}";
            allPicture.Add(graph);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            string newname;
            string container;
            double tbase;
            double height;
            if (f4.DialogResult == DialogResult.OK)
            {
                f4.GetData(out newname, out container, out tbase, out height);
                int i;
                for (i = 0; i < allPicture.Count; i++)
                {
                    if (container == allPicture[i].getName())
                    {
                        Triangle x = new Triangle(newname, tbase, height);
                        allPicture[i].addComponent(x);
                        textBox1.Text = graph.show();
                        break;
                    }
                }
                if (i >= allPicture.Count)
                {
                    MessageBox.Show("不存在的Picture容器:" + container, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            string newname;
            string container;
            double radius;
            if (f5.DialogResult == DialogResult.OK)
            {
                f5.GetData(out newname, out container, out radius);
                int i;
                for (i = 0; i < allPicture.Count; i++)
                {
                    if (container == allPicture[i].getName())
                    {
                        Circle x = new Circle(newname, radius);
                        allPicture[i].addComponent(x);
                        textBox1.Text = graph.show();
                        break;
                    }
                }
                if (i >= allPicture.Count)
                {
                    MessageBox.Show("不存在的Picture容器:" + container, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text=""+graph.area();
        }
    }
    abstract class Component
    {
        protected string name;
        public abstract double area();
        public abstract string show();
        public string getName()
        {
            return name;
        }
    }
    abstract class Shape : Component { }
    class Picture : Component
    {
        private List<Component> coms = new List<Component>();

        public Picture(string n)
        {
            name = n;
        }

        public void addComponent(Component c)
        {
            coms.Add(c);
        }

        public override double area()
        {
            double total = 0.0;
            for(int i = 0; i < coms.Count; i++)
            {
                total = total + coms[i].area();
            }
            return total;
        }

        public override string show()
        {
            string str = "{Picture" + name + ":";
            for(int i = 0; i < coms.Count; i++)
            {
                str = str + "" + coms[i].show();
            }
            str = str + "}";
            return str;
        }

    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(string n, double l, double w)
        {
            name = n;
            length = l;
            width = w;
        }
        public override double area()
        {
            return length * width;
        }
        public override string show()
        {
            return "Rectangle" + name + "(" + length + "," + width + ")";
        }   
    }
    class Triangle : Shape
    {
        private double tbase;
        private double height;
        public Triangle(string n, double b, double h)
        {
            name = n;
            tbase = b;
            height = h;
        }
        public override double area()
        {
            return tbase * height / 2;
        }
        public override string show()
        {
            return "Triangle" + name + "(" + tbase + "," + height + ")";
        }
    }
    class Circle : Component
    {
        private double radius;
        public Circle(string n, double r)
        {
            name = n;
            radius = r;
        }
        public override double area()
        {
            return radius * radius * 3.14;
        }
        public override string show()
        {
            return "Circle" + name + "(" + radius + ")";
        }
    }
    
}
