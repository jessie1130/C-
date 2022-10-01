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
    public partial class Form4 : Form
    {
        public void GetData(out string name, out string container, out double tbase, out double height)
        {
            name = textBox1.Text;
            container = textBox2.Text;
            tbase = Convert.ToDouble(textBox3.Text);
            height = Convert.ToDouble(textBox4.Text);
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
