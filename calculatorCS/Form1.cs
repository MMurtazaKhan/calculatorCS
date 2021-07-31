using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNumber, secondnumber;
        string operation;


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "/";
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "exp";
        }

        private void buttonSq_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = firstNumber * firstNumber;
            textBox1.Text = ans.ToString();
        }

        private void buttonCb_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = firstNumber * firstNumber * firstNumber;
            textBox1.Text = ans.ToString();
        }

        private void buttonRt_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Sqrt(firstNumber);
            textBox1.Text = ans.ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Log10(firstNumber);
            textBox1.Text = ans.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double result;

            secondnumber = Convert.ToDouble(textBox1.Text);
            if(operation == "+")
            {
                result = firstNumber + secondnumber;
                textBox1.Text = result.ToString();
            }
            if (operation == "-")
            {
                result = firstNumber - secondnumber;
                textBox1.Text = result.ToString();
            }
            if (operation == "*")
            {
                result = firstNumber * secondnumber;
                textBox1.Text = result.ToString();
            }
            if (operation == "/")
            {
                result = firstNumber / secondnumber;
                textBox1.Text = result.ToString();
            }
            if (operation == "exp")
            {
                result = Math.Pow(firstNumber, secondnumber);
                textBox1.Text = result.ToString();
            }
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Sin(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Cos(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Tan(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Sinh(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonCosh_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Cosh(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Tanh(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text);
            result = 1 / result;
            textBox1.Text = result.ToString();
        }

        private void buttonfloor_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Floor(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonCeil_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            double ans = Math.Ceiling(firstNumber);
            textBox1.Text = ans.ToString();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {

            double result = Math.PI;
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
