using System;
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
        string Oper = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_9_Click(object sender, EventArgs e)
        {
            Button btnSelf = (Button)sender;
            string sValue1 = btnSelf.Text;
            string sValue2 = this.textBox1.Text;
            this.textBox1.Text = sValue2 + sValue1;

        }


        private void buttonOper_Click(object sender, EventArgs e)
        {
            Button btnSelf = (Button)sender;
            string sValue1 = btnSelf.Text;
            this.Oper = sValue1;
            bool bRes = double.TryParse(this.textBox1.Text, out V1);
            if (bRes) this.textBox1.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.Oper == "")
            {
                return;
            }
            if (this.textBox1.Text == "")
            {
                return;
            }
            double V2;
            bool bRes = double.TryParse(this.textBox1.Text, out V2);
            if (!bRes)
            {
                return;
            }

            if (this.Oper == "+")
            {
                ClassPlus doubleRes = new ClassPlus();
                this.V1 = doubleRes.Result(V1, V2);
            }

            if (this.Oper == "-")
            {
                ClassMinus doubleRes = new ClassMinus();
                this.V1 = doubleRes.Result(V1, V2);
            }

            if (this.Oper == "*")
            {
                ClassMultiply doubleRes = new ClassMultiply();
                this.V1 = doubleRes.Result(V1, V2);
            }

            if (this.Oper == "/")
            {
                ClassDivid doubleRes = new ClassDivid();
                this.V1 = doubleRes.Result(V1, V2);
            }
            this.textBox1.Text = this.V1.ToString();

        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            V1 = 0;
            Oper = "";
        }
    }
}
