using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN
{
    public partial class Ex11 : Form
    {

        String sign = String.Empty;
        Boolean start_of_enter = true;
        Double num_1, num_2;

        public Ex11()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }


        private void Digit(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String Dig = btn.Text;

            if(start_of_enter == true)
            {
                textBox1.Text = Dig;
                start_of_enter = false;
                return;
            }

            if(start_of_enter == false)
            {
                textBox1.Text += Dig;
            }
        }

        private void Operation(object sender, EventArgs e)
        {
            num_1 = Double.Parse(textBox1.Text);
            Button btn = (Button)sender;
            sign = btn.Text;
            start_of_enter = true;
        }

        private void Equal(object sender, EventArgs e)
        {
            double result = 0;
            num_2 = Double.Parse(textBox1.Text);

            switch (sign)
            {
                case "+": result = num_1 + num_2; break;
                case "-": result = num_1 - num_2; break;
                case "/": result = num_1 / num_2; break;
                case "*": result = num_1 * num_2; break;
            }

            sign = null;
            textBox1.Text = result.ToString();
            num_1 = result;
            start_of_enter = true;
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Clear();
            sign = null;
            start_of_enter = true;
        }
    }
}
