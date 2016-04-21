namespace Calculator 
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonNP = new System.Windows.Forms.Button();
            this.buttonEqu = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonClr = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 144);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(59, 111);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(43, 23);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // buttonNP
            // 
            this.buttonNP.Location = new System.Drawing.Point(3, 111);
            this.buttonNP.Name = "buttonNP";
            this.buttonNP.Size = new System.Drawing.Size(43, 23);
            this.buttonNP.TabIndex = 14;
            this.buttonNP.Text = "+-";
            this.buttonNP.UseVisualStyleBackColor = true;
            // 
            // buttonEqu
            // 
            this.buttonEqu.Location = new System.Drawing.Point(171, 111);
            this.buttonEqu.Name = "buttonEqu";
            this.buttonEqu.Size = new System.Drawing.Size(43, 23);
            this.buttonEqu.TabIndex = 13;
            this.buttonEqu.Text = "/";
            this.buttonEqu.UseVisualStyleBackColor = true;
            this.buttonEqu.Click += new System.EventHandler(this.buttonOper_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(115, 111);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(43, 23);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(171, 75);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonOper_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(115, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(59, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(171, 39);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(43, 23);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOper_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(115, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(171, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(43, 23);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOper_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(198, 209);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonClr
            // 
            this.buttonClr.Location = new System.Drawing.Point(142, 209);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(50, 23);
            this.buttonClr.TabIndex = 4;
            this.buttonClr.Text = "C";
            this.buttonClr.UseVisualStyleBackColor = true;
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
             
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonNP;
        private System.Windows.Forms.Button buttonEqu;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonClr;
    }
}

