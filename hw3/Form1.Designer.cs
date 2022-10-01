namespace hw3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttoncard = new System.Windows.Forms.Button();
            this.buttonnocard = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(46, 103);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(41, 87);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(113, 103);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 87);
            this.button12.TabIndex = 1;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(181, 103);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 87);
            this.button13.TabIndex = 2;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(255, 103);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 87);
            this.button14.TabIndex = 3;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "莊家";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "玩家";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "玩家籌碼";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(559, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "下注籌碼";
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(486, 238);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(179, 38);
            this.buttonstart.TabIndex = 10;
            this.buttonstart.Text = "開始玩";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttoncard
            // 
            this.buttoncard.Location = new System.Drawing.Point(486, 301);
            this.buttoncard.Name = "buttoncard";
            this.buttoncard.Size = new System.Drawing.Size(179, 36);
            this.buttoncard.TabIndex = 11;
            this.buttoncard.Text = "要牌";
            this.buttoncard.UseVisualStyleBackColor = true;
            this.buttoncard.Click += new System.EventHandler(this.buttoncard_Click);
            // 
            // buttonnocard
            // 
            this.buttonnocard.Location = new System.Drawing.Point(486, 360);
            this.buttonnocard.Name = "buttonnocard";
            this.buttonnocard.Size = new System.Drawing.Size(179, 36);
            this.buttonnocard.TabIndex = 12;
            this.buttonnocard.Text = "不再要牌";
            this.buttonnocard.UseVisualStyleBackColor = true;
            this.buttonnocard.Click += new System.EventHandler(this.buttonnocard_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(328, 103);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 87);
            this.button15.TabIndex = 13;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Visible = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button21.Location = new System.Drawing.Point(49, 309);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(39, 87);
            this.button21.TabIndex = 14;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button22.Location = new System.Drawing.Point(113, 309);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(39, 87);
            this.button22.TabIndex = 15;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button23.Location = new System.Drawing.Point(181, 309);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(49, 87);
            this.button23.TabIndex = 16;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Visible = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button24.Location = new System.Drawing.Point(255, 309);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(47, 87);
            this.button24.TabIndex = 17;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Visible = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button25.Location = new System.Drawing.Point(328, 309);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 87);
            this.button25.TabIndex = 18;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.buttonnocard);
            this.Controls.Add(this.buttoncard);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttoncard;
        private System.Windows.Forms.Button buttonnocard;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
    }
}

