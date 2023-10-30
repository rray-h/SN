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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ex5_Load(object sender, EventArgs e)
        {
            this.Text = "CheckBox";
            label1.Text = "Выберите стиль шрифта";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            label1.Font = new Font(FontFamily.GenericSansSerif, 8.0F, label1.Font.Style^FontStyle.Bold);



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(FontFamily.GenericSansSerif, 8.0F, label1.Font.Style ^ FontStyle.Italic);
            

        }
    }
}
