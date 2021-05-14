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
    public partial class Form1 : Form
    {
        double firstN;
        string sign = "";
        double result;
        bool signUsed = false;
        bool equalUsed = false;

        List<double> numbersM = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn1.Text;
                txtTo.Text = "";
                equalUsed = false;
            }

            else if (signUsed)
            {
                txtEntry.Text = btn1.Text;
            }

            else
            {
                txtEntry.Text += btn1.Text;

            }
            signUsed = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn2.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
            
            else if (signUsed)
            {
                txtEntry.Text = btn2.Text;
            }
           
            else
            {
                txtEntry.Text += btn2.Text;

            }
            signUsed = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn3.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
           
            else if (signUsed)
            {
                txtEntry.Text = btn3.Text;
            }
            
            else
            {
                txtEntry.Text += btn3.Text;

            }
            signUsed = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn4.Text;
                txtTo.Text = "";
                equalUsed = false;
            }

            else if (signUsed)
            {
                txtEntry.Text = btn4.Text;
            }

            else
            {
                txtEntry.Text += btn4.Text;

            }
            signUsed = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }
          
            if (equalUsed == true)
            {

                txtEntry.Text = btn5.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
           
            else if (signUsed)
            {
                txtEntry.Text = btn5.Text;
            }
           
            else
            {
                txtEntry.Text += btn5.Text;

            }
            signUsed = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }


            if (equalUsed == true)
            {

                txtEntry.Text = btn6.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
            
            else if (signUsed)
            {
                txtEntry.Text = btn6.Text;
            }
            
            else
            {
                txtEntry.Text += btn6.Text;

            }
            signUsed = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn7.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
            
            else if (signUsed)
            {
                txtEntry.Text = btn7.Text;
            }
            
            else
            {
                txtEntry.Text += btn7.Text;

            }
            signUsed = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn8.Text;
                txtTo.Text = "";
                equalUsed = false;
            }

            else if (signUsed)
            {
                txtEntry.Text = btn8.Text;
            }

            else
            {
                txtEntry.Text += btn8.Text;

            }
            signUsed = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "0")
            {
                txtEntry.Clear();
            }

            if (equalUsed == true)
            {

                txtEntry.Text = btn9.Text;
                txtTo.Text = "";
                equalUsed = false;
            }
            
            else if (signUsed)
            {
                txtEntry.Text = btn9.Text;
            }
           
            else
            {
                txtEntry.Text += btn9.Text;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!signUsed)
            {
                double secondN = double.Parse(txtEntry.Text);
                txtTo.Text += secondN.ToString();
                txtTo.Text += btnEquals.Text;
                equalUsed = true;

                switch (sign)
                {
                    case "+":
                        result = (double)(firstN + secondN);
                        txtEntry.Text = result.ToString();
                        break;

                    case "÷":
                        result = (double)(firstN / secondN);
                        txtEntry.Text = result.ToString();
                        break;

                    case "−":
                        result = (double)(firstN - secondN);
                        txtEntry.Text = result.ToString();
                        break;

                    case "×":
                        result = (double)(firstN * secondN);
                        txtEntry.Text = result.ToString();
                        break;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!signUsed)
            {
                if (equalUsed)
                {
                    txtTo.Text = txtEntry.Text;
                    txtTo.Text += btnPlus.Text;
                    equalUsed = false;
                }

                else
                {
                    txtTo.Text += txtEntry.Text;
                    txtTo.Text += btnPlus.Text;
                }

                signUsed = true;
                firstN = double.Parse(txtEntry.Text);
                sign = btnPlus.Text;
            }         
        }    

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!signUsed)
            {
                if (equalUsed)
                {
                    txtTo.Text = txtEntry.Text;
                    txtTo.Text += btnDivide.Text;
                    signUsed = true;
                    equalUsed = false;
                }

                else
                {
                    txtTo.Text += txtEntry.Text;
                    txtTo.Text += btnDivide.Text;
                    signUsed = true;
                }

                firstN = double.Parse(txtEntry.Text);
                sign = btnDivide.Text;
            }           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!signUsed)
            {
                if (equalUsed)
                {
                    txtTo.Text = txtEntry.Text;
                    txtTo.Text += btnMultiply.Text;
                    signUsed = true;
                    equalUsed = false;
                }

                else
                {
                    txtTo.Text += txtEntry.Text;
                    txtTo.Text += btnMultiply.Text;
                    signUsed = true;
                }

                firstN = double.Parse(txtEntry.Text);
                sign = btnMultiply.Text;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!signUsed)
            {
                if (equalUsed)
                {
                    txtTo.Text = txtEntry.Text;
                    txtTo.Text += btnMinus.Text;
                    signUsed = true;
                    equalUsed = false;
                }

                else
                {
                    txtTo.Text += txtEntry.Text;
                    txtTo.Text += btnMinus.Text;
                    signUsed = true;
                }

                firstN = double.Parse(txtEntry.Text);
                sign = btnMinus.Text;
            }
            else
            {

            }
        }       

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            numbersM.Add(double.Parse(txtEntry.Text));
            cbMemory.Items.Add(txtEntry.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            numbersM.Clear();
            cbMemory.Items.Clear();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (numbersM.Count > 0)
            {
                txtEntry.Text = numbersM.Last<double>().ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtEntry.Text);

            if (txtEntry.Text.Length > 0)
            {
                number = (double)(firstN * (number / 100));
                txtEntry.Text = number.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string entry = txtEntry.Text;

            if (entry.Length != 0)
            {
                if (double.Parse(entry) > 0)
                {
                    string entryMinus;
                    if (entry.ElementAt(0) == '+')
                    {
                         entryMinus = entry.Replace('+', '-');  
                    }
                    else
                    {
                         entryMinus = entry.Insert(0, "-");
                    }
                    txtEntry.Text = entryMinus;
                }

                else if (double.Parse(entry) < 0)
                {
                    string entryPlus = entry.Replace('-', '+');
                    txtEntry.Text = entryPlus;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstN = 0;
            sign = "";
            result = 0;
            signUsed = false;
            equalUsed = false;
            txtEntry.Text = "0";
            txtTo.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtEntry.Text = "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            string entry = txtEntry.Text.Insert(txtEntry.Text.Length, btnComma.Text);
            txtEntry.Text = entry;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text.Length > 0)
            {
                string entryPlus = txtEntry.Text.Remove(txtEntry.Text.Length - 1);
                txtEntry.Text = entryPlus;
                if (txtEntry.Text == "")
                {
                    txtEntry.Text = "0";
                }
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtEntry.Text);

            if (txtEntry.Text.Length > 0)
            {
                number = Math.Pow(number, 2);
                txtEntry.Text = number.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtEntry.Text);

            if (txtEntry.Text.Length > 0)
            {
                number = 1 / number;
                txtEntry.Text = number.ToString();
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtEntry.Text);

            if (txtEntry.Text.Length > 0)
            {
                number = Math.Sqrt(number);
                txtEntry.Text = number.ToString();
            }
        }

        private void cbMemory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEntry.Text = cbMemory.SelectedItem.ToString();
        }
    }
}
