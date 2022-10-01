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
    public partial class Form5 : Form
    {
        public void GetData(out string name, out string container, out double radius)
        {
            name = textBox1.Text;
            container = textBox2.Text;
            radius = Convert.ToDouble(textBox4.Text);
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
