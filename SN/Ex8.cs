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
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }

        private void Ex8_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
            Choose.Text = "Choose option";
            comboBox1.Text = "Choose option";
            String[] options = { "+", "-", "*", "/", "clear" };
            comboBox1.Items.AddRange(options);
            comboBox1.TabIndex = 2;
            textBox1.Clear();
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Equal: ";
            Single X, Y, Z;
            Z = 0;

            var is_num_1 = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number, System.Globalization.NumberFormatInfo.CurrentInfo, out X);
            var is_num_2 = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number, System.Globalization.NumberFormatInfo.CurrentInfo, out Y);

            if (is_num_1 = false || is_num_2 == false)
            {
                MessageBox.Show("Enter the numbers", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0: Z = X + Y; break;
                case 1: Z = X - Y; break;
                case 2: Z = X * Y; break;
                case 3: Z = X / Y; break;
                case 4: textBox1.Clear(); textBox2.Clear(); label1.Text = "Equal: "; return;
            }

            label1.Text = String.Format("Equal: {0:F5}", Z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
