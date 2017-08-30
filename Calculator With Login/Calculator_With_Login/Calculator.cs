using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_With_Login
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        string operation;
        double newNum = 0;
        double num1 = 0;
        double num2 = 0;
        bool isClick = false;

        private void Btn_Number(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void Btn_Arithmetic(object sender, EventArgs e)
        {
            double currentNum = Convert.ToDouble(textBox1.Text);

            Button function = (Button)sender;
            switch (function.Name)
            {
                case "BtnDot":
                    if (!textBox1.Text.Contains("."))
                    {
                        textBox1.Text += ".";
                    }
                    break;
                case "BtnClear":
                    textBox1.Text = "0";
                    break;
                case "BtnSign":
                    newNum = -currentNum;
                    textBox1.Text = newNum.ToString();
                    break;
                case "BtnSqrRoot":
                    newNum = Math.Sqrt(currentNum);
                    textBox1.Text = newNum.ToString();
                    break;
                case "BtnInverse":
                    newNum = 1 / currentNum;
                    textBox1.Text = newNum.ToString();
                    break;
                case "BtnSqr":
                    newNum = currentNum * currentNum;
                    textBox1.Text = newNum.ToString();
                    break;
            }
        }
        private void Btn_Operation(object sender, EventArgs e)
        {
            isClick = true;
            Button btn = (Button)sender;
            operation = btn.Name;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }
        private void Btn_Equal(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case "BtnPlus":
                    if (isClick)
                    {
                        newNum = num1 + num2;
                        num1 = num2;
                        isClick = false;
                    }
                    else
                    {
                        newNum = num1 + num2;
                    }
                    break;
                case "BtnMinus":
                    if (isClick)
                    {
                        newNum = num1 - num2;
                        num1 = num2;
                        isClick = false;
                    }
                    else
                    {
                        newNum = num2 - num1;
                    }
                    break;
                case "BtnMultiplite":
                    if (isClick)
                    {
                        newNum = num1 * num2;
                        num1 = num2;
                        isClick = false;
                    }
                    else
                    {
                        newNum = num1 * num2;
                    }
                    break;
                case "BtnDivide":
                    if (isClick)
                    {
                        newNum = num1 / num2;
                        num1 = num2;
                        isClick = false;
                    }
                    else
                    {
                        newNum = num2 / num1;
                    }
                    break;
                case "BtnResidual":
                    if (isClick)
                    {
                        newNum = num1 % num2;
                        num1 = num2;
                        isClick = false;
                    }
                    else
                    {
                        newNum = num2 % num1;
                    }
                    break;
            }
            textBox1.Text = newNum.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnSqr.Visible = true;
            BtnSqrRoot.Visible = true;
            BtnInverse.Visible = true;
            textBox1.Location = new Point(37,37);
            standardToolStripMenuItem.Checked = false;
            scientificToolStripMenuItem.Checked = true;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnSqr.Visible = false;
            BtnSqrRoot.Visible = false;
            BtnInverse.Visible = false;
            textBox1.Location = new Point(37, 70);
            standardToolStripMenuItem.Checked = true;
            scientificToolStripMenuItem.Checked = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is written by Yayun (Kim) Yang!", "About", MessageBoxButtons.OK);
        }
    }
}
