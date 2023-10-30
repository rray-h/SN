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
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true) label1.Visible = false;
            else label1.Visible = true;
        }

        private void Ex7_Load(object sender, EventArgs e)
        {
            this.Text = "Wisdom";
            label1.Text = "Visible";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Text = "Push me";
            toolTip1.SetToolTip(button1, "Switch" + "\n" + "visible");
            toolTip1.IsBalloon = true;
        }
    }
}
