using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW5
{
    public partial class Form1 : Form
    {
        bool levelInput = true;
        bool dataInput = false;
        bool compute = false;
        int level, row, column;
        int[,] matrix = new int[10, 10];

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataInput)
                {
                    int input = Convert.ToInt32(textBox3.Text);
                    if (column == level - 1)
                        {
                            row++;
                            column = 0;
                            textBox1.Text = textBox1.Text + "\r\n";
                        }
                        else
                        {
                            column++;
                            if(row == level-1 && column == level - 1)
                            {
                                compute = true;
                                dataInput = false;
                            }
                        }
                        textBox1.Text = textBox1.Text + textBox3.Text + " ";
                        matrix[row, column] = input;
                        textBox3.Text = "";
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compute = true;
            openFileDialog1.Filter = "二元檔案(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                int t = br.ReadInt32();
                textBox2.Text = t+"";
                level = t;
                int c;
                for (int i = 0; i < t; i++)
                {
                    for (int j = 0; j < t; j++)
                    {
                        c = br.ReadInt32();
                        matrix[i, j] = c;
                        textBox1.Text = textBox1.Text + c + " ";
                    }
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                for (int i = 0; i < t; i++)
                {
                    for (int j = 0; j < t; j++)
                    {

                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine("");
                }

                br.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "二元檔案(*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(textBox2.Text);
                int t = Convert.ToInt32(textBox2.Text);
                bw.Write(textBox1.Text);
                bw.Flush();
                bw.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (compute)
            {
                int result = det(matrix, level);
                textBox4.Text = "" + result;
                //Console.WriteLine(level+"!");
            }
        }

        int det(int[,] arr, int n)
        {
            if (n == 1)
                return (arr[0, 0]);
            else
            {
                int sum = 0;
                for(int i = 0; i < n; i++)
                {
                    int[,] t = new int[n - 1, n - 1];
                    int x = 0;
                    int y = 0;
                    for(int j = 0; j < n; j++)
                    {
                        if (j == i) continue;
                        for(int k = 1; k < n; k++)
                        {
                            t[x, y] = arr[j, k];
                            y++;
                        }
                        y = 0;
                        x++;
                    }
                    /*Console.Write(arr[i,0]+"");
                    Console.WriteLine("!");
                    Console.Write(t + "");*/
                    if (i % 2 == 0)
                        sum += arr[i, 0] * det(t, n - 1);
                    else
                        sum -= arr[i, 0] * det(t, n - 1);
                } 
                return (sum);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (levelInput)
                {
                    level = Convert.ToInt32(textBox2.Text);
                    if (level > 10) throw new Exception("矩陣階數超過10");
                    else
                    {
                        row = 0;
                        column = -1;
                        dataInput = true;
                        levelInput = false;
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
