using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        String Value1;
        String Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            Value1 = this.txtCalculator.Text + btn1.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn2.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn3.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn4.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn5.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn6.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn7.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn8.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn9.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + btn0.Text;
            this.txtCalculator.Text = Value1;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + "/";
            this.txtCalculator.Text = Value1;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + "*";
            this.txtCalculator.Text = Value1;
        }

        private void btnSud_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + "-";
            this.txtCalculator.Text = Value1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Value1 = this.txtCalculator.Text + "+";
            this.txtCalculator.Text = Value1;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];

            if (Value1.Contains("+"))
            {
                arr = this.txtCalculator.Text.Split(new char[]{'+'});
                this.Operator = "+";
            }

            else if (Value1.Contains("-"))
            {
                arr = this.txtCalculator.Text.Split(new char[] { '-' });
                this.Operator = "-";
            }

            else if (Value1.Contains("*"))
            {
                arr = this.txtCalculator.Text.Split(new char[] { '*' });
                this.Operator = "*";
            }

            else if (Value1.Contains("/"))
            {
                arr = this.txtCalculator.Text.Split(new char[] { '/' });
                this.Operator = "/";
            }
            else
                this.txtCalculator.Text = "Invalid Input!";

            if (Operator == "+")
            {
                this.txtCalculator.Text = "" + (int.Parse(arr[0]) + int.Parse(arr[1]));
            }

            else if (Operator == "-")
            {
                this.txtCalculator.Text = "" + (int.Parse(arr[0]) - (int.Parse(arr[1])));
            }

            else if (Operator == "*")
            {
                this.txtCalculator.Text = "" + (int.Parse(arr[0]) * (int.Parse(arr[1])));
            }

            else if (Operator == "/")
            {
                this.txtCalculator.Text = "" + (float.Parse(arr[0]) / (int.Parse(arr[1])));
            }

            else
                this.txtCalculator.Text = "Invalid Input!";
            
       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCalculator.Text = null;
        }
    }
}
