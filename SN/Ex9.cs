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
    public partial class Ex9 : Form
    {
        public Ex9()
        {
            InitializeComponent();
            this.Text = "Calculate of β";
        }

        private void Ex9_Load(object sender, EventArgs e)
        {
            label1.Text = "Find the length of the circle: \n";
            label2.Text = "β = 2πR\n";
            label3.Text = "Where π = 3.14159265";
            label4.Text = "Inter the Radius: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single R;

            var is_num = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number, System.Globalization.NumberFormatInfo.CurrentInfo, out R);

            if(is_num == false)
            {
                MessageBox.Show("Enter the numbers", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var beta = 2 * Math.PI * R;

            MessageBox.Show(String.Format("Length of the circle {0} = {1}", Convert.ToChar(0x3B2), beta));
        }
    }
}
