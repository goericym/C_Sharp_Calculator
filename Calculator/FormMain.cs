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

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
