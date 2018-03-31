using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizika
{
    public partial class Form2 : Form
    {

        double c1, c3, res;
        string c2;

        public Form2()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "3,14";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "+";
            c2 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "-";
            c2 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "*";
            c2 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "/";
            c2 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c3 = Convert.ToDouble(textBox1.Text);
            if (c2 == "+")
            {
                res = c1 + c3;
                textBox1.Text = Convert.ToString(res);
            }
            if (c2 == "*")
            {
                res = c1 * c3;
                textBox1.Text = Convert.ToString(res);
            }
            if (c2 == "/")
            {
                res = c1 / c3;
                textBox1.Text = Convert.ToString(res);
            }
            if (c2 == "-")
            {
                res = c1 - c3;
                textBox1.Text = Convert.ToString(res);
            }
            if (c2 == "^")
            {
                for (int i = 0; i < c3; i++)
                {
                    res = c1 * c1;
                }
                textBox1.Text = Convert.ToString(res);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c1 = 0;
            c2 = "";
            c3 = 0;
            res = 0;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "^";
            c2 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(a);
            textBox1.Text = Convert.ToString(res);
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int n = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    n++;
                }
            }

            if (n < 1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}
