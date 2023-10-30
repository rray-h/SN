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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void Ex6_Load(object sender, EventArgs e)
        {
            this.Text = "Smile";
            radioButton1.Text = " ";
            label1.Text = "Nice";
            radioButton2.Text = " ";
            label2.Text = "Not nice";
            tabControl1.TabPages[0].Text = "Текст";
            tabControl1.TabPages[1].Text = "Цвет";
            tabControl1.TabPages[2].Text = "Размер";
            label3.Text = " ";
            label3.Font = new Font(FontFamily.GenericMonospace, 16.0F, FontStyle.Regular);
            label3.ForeColor = Color.Gray;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {

                label3.Text = label1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Text = label2.Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(FontFamily.GenericMonospace, 32.0F, FontStyle.Regular);
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label3.Font = new Font(FontFamily.GenericMonospace, 8.0F, FontStyle.Regular);

        }


    }
}
