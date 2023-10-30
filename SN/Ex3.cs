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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void Ex3_Load(object sender, EventArgs e)
        {
            this.Text = "Extraction sqrt";
            button1.Text = "SQRT";
            label1.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single X = 0;
            bool is_num = Single.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number, System.Globalization.NumberFormatInfo.CurrentInfo, out X);

            if (is_num == false)
            {
                label1.Text = "Следует вводить числа";
                label1.ForeColor = Color.Red;
                return;
            }
            Single Y = (Single)Math.Sqrt(X);
            label1.ForeColor = Color.Black;
            label1.Text = String.Format("Корень из {0} равен {1:F5}", X, Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Извлечение квадратного корня";
            button1.Text = "Извлечь корень";
            textBox1.Clear();
            label1.Text = String.Empty;


        }
    }
}
