using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class Calculator : Form
    {
        Calculations calcmethod = new Calculations();
        public Calculator()
        {
            InitializeComponent();
        }

        private void numbutton_Click(object sender, EventArgs e)
        {
            if ((result_box.Text == "0")||(calcmethod.operation_clicked))
            {
                result_box.Text = "";
            }
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result_box.Text.Contains("."))
                {
                    result_box.Text = result_box.Text + b.Text;
                }
            }
            else
            {
                result_box.Text = result_box.Text + b.Text;
            }
            calcmethod.operation_clicked = false;
        }
        
        private void operator_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (calcmethod.value != 0)
            {
                calcmethod.value2 = result_box.Text;
                calcmethod.result();
                calcmethod.operation_clicked = true;
                calcmethod.operation = b.Text;
                result_label.Text = calcmethod.value + " " + calcmethod.operation;
            }
            else
            {
                calcmethod.operation = b.Text;
                calcmethod.value = Double.Parse(result_box.Text);
                calcmethod.operation_clicked = true;
                result_label.Text = calcmethod.value + " " + calcmethod.operation;
            }
        }

        private void equals_button_Click(object sender, EventArgs e)
        {
            calcmethod.value2 = result_box.Text;
            calcmethod.result();
            result_box.Text = calcmethod.value2;
            result_label.Text = "";
            calcmethod.operation_clicked = true;
        }

        private void sign_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Contains("-"))
            {
                result_box.Text = result_box.Text.Remove(0,1);
            }
            else
            {
                result_box.Text = "-" + result_box.Text;
            }
        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            result_box.Text = (Double.Parse(result_box.Text) / 100).ToString();
            calcmethod.operation_clicked = true;
        }

        private void memclear_button_Click(object sender, EventArgs e)
        {
            calcmethod.memorynum = 0;
            memnum_label.Text = "";
        }

        private void memrecall_button_Click(object sender, EventArgs e)
        {
            result_box.Text = calcmethod.memorynum.ToString();
        }

        private void memsave_button_Click(object sender, EventArgs e)
        {
            calcmethod.memorynum = Double.Parse(result_box.Text);
            memnum_label.Text = (calcmethod.memorynum).ToString();
        }

        private void memadd_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text != "")
            {
                calcmethod.memorynum += Double.Parse(result_box.Text);
            }
            memnum_label.Text = (calcmethod.memorynum).ToString();
        }

        private void memsubt_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text != "")
            {
                calcmethod.memorynum -= Double.Parse(result_box.Text);
            }
            memnum_label.Text = (calcmethod.memorynum).ToString();
        }

        private void backspace_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text.Length > 0)
            {
                result_box.Text = result_box.Text.Substring(0, result_box.Text.Length - 1);
            }
        }

        private void sqrt_button_Click(object sender, EventArgs e)
        {
            result_box.Text = (Math.Sqrt(Double.Parse(result_box.Text))).ToString();
            calcmethod.operation_clicked = true;
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            result_box.Text = ((Double.Parse(result_box.Text) * Double.Parse(result_box.Text))).ToString();
            calcmethod.operation_clicked = true;
        }

        private void reciprocal_button_Click(object sender, EventArgs e)
        {
            if (result_box.Text == "0")
            {
                result_box.Text = "0";
            }
            else
            {
                result_box.Text = (1 / Double.Parse(result_box.Text)).ToString();
            }
            calcmethod.operation_clicked = true;
        }

        private void clear_entry_button_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            result_box.Clear();
            calcmethod.value = 0;
            result_box.Text = "0";
            result_label.Text = "";
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    number_0.PerformClick();
                    break;

                case "1":
                    number_1.PerformClick();
                    break;

                case "2":
                    number_2.PerformClick();
                    break;

                case "3":
                    number_3.PerformClick();
                    break;

                case "4":
                    number_4.PerformClick();
                    break;

                case "5":
                    number_5.PerformClick();
                    break;

                case "6":
                    number_6.PerformClick();
                    break;

                case "7":
                    number_7.PerformClick();
                    break;

                case "8":
                    number_8.PerformClick();
                    break;

                case "9":
                    number_9.PerformClick();
                    break;

                case ".":
                    decimal_button.PerformClick();
                    break;

                case "+":
                    addition_button.PerformClick();
                    break;

                case "-":
                    subtraction_button.PerformClick();
                    break;

                case "*":
                    multiplication_button.PerformClick();
                    break;

                case "/":
                    division_button.PerformClick();
                    break;

                case "=":
                    equals_button.PerformClick();
                    break;

                case "%":
                    percent_button.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void memory_button_Click(object sender, EventArgs e)
        {
            if (mempanel.Height != 0)
            {
                mempanel.Height = 0;
            }
            else
            {
                mempanel.Height = 100;
            }
        }

        private void more_button_Click(object sender, EventArgs e)
        {
            if (more_panel.Width != 0)
            {
                more_panel.Width = 0;
            }
            else
            {
                more_panel.Width = 225;
            }
        }
    }
}