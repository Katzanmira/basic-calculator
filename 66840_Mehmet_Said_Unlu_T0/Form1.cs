using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _66840_Mehmet_Said_Unlu_T0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int sum = number1 * number2;
            label2.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);   
            int sum = number1 + number2;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text) ;
            int number2 = Convert.ToInt32(textBox2.Text) ;
            int sum = number1 - number2;
            label2.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int sum = number1 % number2;
            label2.Text = sum.ToString();
        }
    }
}
