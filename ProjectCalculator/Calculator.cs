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
        public Calculator()
        {
            InitializeComponent();
        }

        Double value = 0;
        String operation = "";

        private void numbutton_Click(object sender, EventArgs e)
        {
            if (result_box.Text == "0")
            {
                result_box.Text = "";
            }

            Button b = (Button)sender;
            result_box.Text = result_box.Text + b.Text;

        }
        
        private void operator_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result_box.Text);

        }

        private void division_button_Click(object sender, EventArgs e)
        {

        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {

        }

        private void subtraction_button_Click(object sender, EventArgs e)
        {

        }

        private void addition_button_Click(object sender, EventArgs e)
        {

        }

        private void equals_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

    }
}
