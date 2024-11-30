using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operand1;
        int operand2;

        public string operandText = "";
        public string expression = "";
        public string operatorText = "";

        private void button1_Click(object sender, EventArgs e)
        {
            operandText += button1.Text;
            textBox1.Text = operandText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operandText += button2.Text;

            textBox1.Text = operandText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operandText += button3.Text;
            textBox1.Text = operandText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operandText += button4.Text;
            textBox1.Text = operandText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operandText += button5.Text;
            textBox1.Text = operandText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operandText += button6.Text;
            textBox1.Text = operandText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operandText += button7.Text;
            textBox1.Text = operandText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operandText += button8.Text;
            textBox1.Text = operandText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operandText += button9.Text;
            textBox1.Text = operandText;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operatorText = button12.Text;
            operand1 = Convert.ToInt32(operandText);
            operandText = "";
            textBox1.Text = operatorText;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operatorText = button11.Text;
            operand1 = Convert.ToInt32(operandText);
            operandText = "";

            textBox1.Text = operatorText;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            operatorText = button10.Text;
            operand1 = Convert.ToInt32(operandText);
            operandText = "";

            textBox1.Text = operatorText;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operatorText = button13.Text;
            operand1 = Convert.ToInt32(operandText);
            operandText = "";
            textBox1.Text = operatorText;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operandText = "";
            textBox1.Text = operandText;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            operandText += button1.Text;

            textBox1.Text = operandText;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToInt32(operandText);

            double Sum= 0;
            switch (operatorText) 
            {
                case "-":
                    Sum = operand1 - operand2;
                    break;

                case "+":
                    Sum = operand1 + operand2;

                    break;

                case "*":
                    Sum = operand1 * operand2;

                    break;

                case "/":
                    Sum = operand1 / operand2;

                    break;
            }
            textBox1.Text = Sum.ToString();
        }

       
    }
}
