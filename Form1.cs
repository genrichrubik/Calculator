using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string one = 1.ToString();
            textBox1.Text += one;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string two = 2.ToString();
            textBox1.Text += two;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
    }
}
