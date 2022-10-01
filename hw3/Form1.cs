using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3
{
    public partial class Form1 : Form
    {
        bool start = false;
        bool[] card = new bool[52];
        int[] dealer = new int[5];
        int[] player = new int[5];
        Random ran = new Random();
        int N1, N2, d, p, dn, pn;

        private void buttoncard_Click(object sender, EventArgs e)
        {
           if (start == true && p < 5)
            {
                do { player[p] = ran.Next(52); } while (card[player[p]] == true);
                card[player[p]] = true;
                if(p == 2)
                {
                    button23.Text = GenerateColor(player[p]);
                    if (player[p] < 39 && player[p] > 12)
                        button23.ForeColor = System.Drawing.Color.Red;
                    else
                        button23.ForeColor = System.Drawing.Color.Black;
                    button23.Visible = true;
                }
                else if(p == 3)
                {
                    button24.Text = GenerateColor(player[p]);
                    if (player[p] < 39 && player[p] > 12)
                        button24.ForeColor = System.Drawing.Color.Red;
                    else
                        button24.ForeColor = System.Drawing.Color.Black;
                    button24.Visible = true;
                }
                else
                {
                    button25.Text = GenerateColor(player[p]);
                    if (player[p] < 39 && player[p] > 12)
                        button25.ForeColor = System.Drawing.Color.Red;
                    else
                        button25.ForeColor = System.Drawing.Color.Black;
                    button25.Visible = true;
                }
                    
                if (player[p] % 13 < 9)
                    pn += player[p] % 13 + 1;
                else
                    pn += 10;
                p++;
                if (pn > 21)
                {
                    button11.Text = GenerateColor(dealer[0]);
                    if (dealer[0] < 39 && dealer[0] > 12)
                        button11.ForeColor = System.Drawing.Color.Red;
                    else
                        button11.ForeColor = System.Drawing.Color.Black;
                    textBox1.Text = "" + (N1 - N2);
                    MessageBox.Show("玩家爆了你輸了" + N2 + "籌碼", "好可惜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start = false;
                    textBox2.ReadOnly = false;
                    button23.Visible = false;
                    button24.Visible = false;
                    button25.Visible = false;
                }
            }
            
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            try
            {
                if(start == false)
                {
                    d = 2; p = 2; dn = 0; pn = 0;
                    N1 = Convert.ToInt32(textBox1.Text);
                    N2 = Convert.ToInt32(textBox2.Text);
                    if (N2 > N1) throw new Exception("籌碼不足");
                    if (N2 == 0) throw new Exception("下注籌碼不可為0");
                    textBox2.ReadOnly = true;
                    int i;
                    for (i = 0; i < 52; i++) card[i] = false;
                    for (i = 0; i < 5; i++) { dealer[i] = -1; player[i] = -1; }
                    dealer[0] = ran.Next(52);
                    card[dealer[0]] = true;
                    button11.Text = "";
                    do { dealer[1] = ran.Next(52); } while (card[dealer[1]] == true);
                    card[dealer[1]] = true;
                    button12.Text = GenerateColor(dealer[1]);
                    if (dealer[1] < 39 && dealer[1] > 12)
                        button12.ForeColor = System.Drawing.Color.Red;
                    else
                        button12.ForeColor = System.Drawing.Color.Black;
                    do { player[0] = ran.Next(52); } while (card[player[0]] == true);
                    card[player[0]] = true;
                    button21.Text = GenerateColor(player[0]);
                    if (player[0] < 39 && player[0] > 12)
                        button21.ForeColor = System.Drawing.Color.Red;
                    else
                        button21.ForeColor = System.Drawing.Color.Black;
                    do { player[1] = ran.Next(52); } while (card[player[1]] == true);
                    card[player[1]] = true;
                    button22.Text = GenerateColor(player[1]);
                    if (player[1] < 39 && player[1] > 12)
                        button22.ForeColor = System.Drawing.Color.Red;
                    else
                        button22.ForeColor = System.Drawing.Color.Black;

                    if (dealer[0]%13 == 0 && dealer[1] %13 >= 9 || dealer[0]%13 >= 9 && dealer[1] % 13 == 0)
                    {
                        if(player[0] % 13 == 0 && player[1] % 13 >= 9 || player[0] % 13 >= 9 && player[1] % 13 == 0)
                        {
                            button11.Text = GenerateColor(dealer[0]);
                            if (dealer[0] < 39 && dealer[0] > 12)
                                button11.ForeColor = System.Drawing.Color.Red;
                            else
                                button11.ForeColor = System.Drawing.Color.Black;
                            MessageBox.Show("雙方都是Black Jack，平手", "和局", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox2.ReadOnly = false;
                            return;
                        }
                        else
                        {
                            button11.Text = GenerateColor(dealer[0]);
                            if (dealer[0] < 39 && dealer[0] > 12)
                                button11.ForeColor = System.Drawing.Color.Red;
                            else
                                button11.ForeColor = System.Drawing.Color.Black;
                            textBox1.Text = "" + (N1 - N2);
                            MessageBox.Show("莊家Black Jack， 你輸了" + N2 + "籌碼", "好可惜", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox2.ReadOnly = false;
                            return;
                        }
                    }
                    else if(player[0] % 13 == 0 && player[1]% 13 >= 9 || player[0] % 13 >= 9 && player[1] % 13 == 0)
                    {
                        button11.Text = GenerateColor(dealer[0]);
                        if (dealer[0] < 39 && dealer[0] > 12)
                            button11.ForeColor = System.Drawing.Color.Red;
                        else
                            button11.ForeColor = System.Drawing.Color.Black;
                        textBox1.Text = "" + (N1 + N2);
                        MessageBox.Show("玩家Black Jack， 你贏了" + N2 + "籌碼", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.ReadOnly = false;
                        return;
                    }
                    start = true;
                    if (dealer[0] % 13 < 9)
                        dn += dealer[0] % 13 + 1;
                    else
                        dn += 10;
                    if (dealer[1] % 13 < 9)
                        dn += dealer[1] % 13 + 1;
                    else
                        dn += 10;
                    if (player[0] % 13 < 9)
                        pn += player[0] % 13 + 1;
                    else
                        pn += 10;
                    if (player[1] % 13 < 9)
                        pn += player[1] % 13 + 1;
                    else
                        pn += 10;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
            

        

        private void buttonnocard_Click(object sender, EventArgs e)
        {
            if (start)
            {
                if (pn <= 11)
                {
                    for (int i = 0; i < p; i++)
                    {
                        if (player[i] % 13 == 0)
                        {
                            pn += 10;
                            break;
                        }
                    }
                }
                while (dn < 17 || dn < pn)
                {
                    do { dealer[d] = ran.Next(52); } while (card[dealer[d]] == true);
                    card[dealer[d]] = true;
                    if (dealer[d] % 13 < 9)
                        dn += dealer[d] % 13 + 1;
                    else
                        dn += 10;
                    if(dealer[d] % 13 == 0)
                    {
                        if(dn + 10 <= 21)
                        {
                            d++;
                            dn += 10;
                            break;
                        }
                    }
                    d++;
                } 
                
                if (dn <= 11)
                {
                    for (int i = 0; i < p; i++)
                    {
                        if (dealer[i] % 13 == 0)
                        {
                            dn += 10;
                            break;
                        }
                    }
                }
                button11.Text = GenerateColor(dealer[0]);
                if (dealer[0] < 39 && dealer[0] > 12)
                    button11.ForeColor = System.Drawing.Color.Red;
                else
                    button11.ForeColor = System.Drawing.Color.Black;
                for (int i = 0; i < d; i++)
                {
                    if (i == 2)
                    {
                        button13.Text = GenerateColor(dealer[i]);
                        if (dealer[i] < 39 && dealer[i] > 12)
                            button13.ForeColor = System.Drawing.Color.Red;
                        else
                            button13.ForeColor = System.Drawing.Color.Black;
                        button13.Visible = true;
                    }
                    else if (i == 3)
                    {
                        button14.Text = GenerateColor(dealer[i]);
                        if (dealer[i] < 39 && dealer[i] > 12)
                            button14.ForeColor = System.Drawing.Color.Red;
                        else
                            button14.ForeColor = System.Drawing.Color.Black;
                        button14.Visible = true;
                    }
                    else if(i == 4)
                    {
                        button15.Text = GenerateColor(dealer[i]);
                        if(dealer[i] < 39 && dealer[i] > 12)
                            button15.ForeColor = System.Drawing.Color.Red;
                        else
                            button15.ForeColor = System.Drawing.Color.Black;
                        button15.Visible = true;
                    }
                }
                if(pn > 21 && dn > 21)
                {
                    MessageBox.Show("雙方都爆了，平手", "和局", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(pn > 21)
                {
                    textBox1.Text = "" + (N1 - N2);
                    MessageBox.Show("玩家爆了，你輸了" + N2 + "籌碼", "可惜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(dn > 21)
                {
                    textBox1.Text = "" + (N1 + N2);
                    MessageBox.Show("莊家爆了，你贏了" + N2 + "籌碼", "和局", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(pn > dn)
                {
                    textBox1.Text = "" + (N1 + N2);
                    MessageBox.Show("玩家點數較大，你贏了" +N2 + "籌碼", "和局", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(dn > pn)
                {
                    textBox1.Text = "" + (N1 - N2);
                    MessageBox.Show("莊家點數較大，你輸了" + N2 + "籌碼", "可惜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("雙方點數相同，平手", "和局", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                start = false;
                textBox2.ReadOnly = false;
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
            }
        }

        string GenerateColor(int a)
        {
            string color;
            if (a <= 12)
                color = "\u2660\r\n";
            else if (a <= 25)
                color = "\u2665\r\n";
            else if (a <= 38)
                color = "\u2666\r\n";
            else
                color = "\u2663\r\n";

            if (a % 13 == 0)
                color += "A";
            else if (a % 13 == 12)
                color += "K";
            else if (a % 13 == 11)
                color += "Q";
            else if (a % 13 == 10)
                color += "J";
            else
                color += (a % 13 + 1);            
            return color;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = ("1000");
            textBox2.Text = ("0");
        }

    }
}
