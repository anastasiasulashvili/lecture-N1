using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture_N1
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        double number1, number2;
        string Symbol;
        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text="1";
            }
            else
            {
                textBox1.Text+= "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void pliusi(object sender, EventArgs e)
        {
            Symbol = "pliusi";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void wertili(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void n3_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void n4_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void n5_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void n6_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void n7_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void n8_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void n9_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void n0_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void gamravleba(object sender, EventArgs e)
        {
            Symbol = "gamravleba";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void gayofa(object sender, EventArgs e)
        {
            Symbol = "gayofa";
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void gamotvla(object sender, EventArgs e)
        {
            
        }

        private void c(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void toloba(object sender, EventArgs e)
        {
            number2=Convert.ToDouble(textBox1.Text);
            if(Symbol=="pliusi")
            {
                textBox1.Text=Convert.ToString(number1+number2);
            }
            if (Symbol == "gamravleba")
            {
                textBox1.Text = Convert.ToString(number1*number2);
            }
            if (Symbol == "gayofa")
            {
                textBox1.Text = Convert.ToString(number1/number2);
            }
           
        }
    }
}
