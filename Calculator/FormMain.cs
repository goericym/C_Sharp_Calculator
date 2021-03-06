﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormMain : Form
    {
        double V1 = 0;
        double V2 = 0;
        string Oper = "";
        bool bEqu = false;
        public FormMain()
        {
            InitializeComponent();
        }



        private void button1_9_Click(object sender, EventArgs e)
        {
            Button btnSelf = (Button)sender;
            string sValue1 = btnSelf.Text;
            string sValue2 = this.textBox1.Text;
            if (sValue1 == "0" && sValue2.StartsWith("0"))
            {
                return;
            }

            if (sValue1 != "0" && sValue2.StartsWith("0") && !sValue2.StartsWith("0."))
            {

                sValue2 = sValue2.Remove(0);
            }

            this.textBox1.Text = sValue2 + sValue1;

        }


        private void buttonOper_Click(object sender, EventArgs e)
        {
            Button btnSelf = (Button)sender;
            string sValue1 = btnSelf.Text;
            this.Oper = sValue1;
            bool bRes = double.TryParse(this.textBox1.Text, out V1);
            if (bRes) this.textBox1.Text = "";
            bEqu = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.Oper == "" || this.textBox1.Text == "")
            {
                return;
            }
            if (!bEqu)
            {
                bool bRes = double.TryParse(this.textBox1.Text, out V2);
                if (!bRes)
                {
                    return;
                }
            }

            ClassEqu CE = new ClassEqu(V1,V2, Oper);
            this.V1 = CE.dResult;
            this.textBox1.Text = this.V1.ToString();
            bEqu = true;
        }



        private void buttonClr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            V1 = 0;
            V2 = 0;
            Oper = "";
            bEqu = false;
        }

        private void buttonNP_Click(object sender, EventArgs e)
        {
            ClassNP NP = new ClassNP();
            double dTemp = 0;
            bool bRes = double.TryParse(this.textBox1.Text, out dTemp);
            if (bRes)
            {
                dTemp = NP.Result(dTemp);
                this.textBox1.Text = dTemp.ToString();
            }

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            ClassDot CD = new ClassDot();
             
           string bbb = CD.Result(this.textBox1.Text);
            textBox1.Text = bbb.ToString();
        }
    }
}
