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
    public partial class Ex15 : Form
    {
        public Ex15()
        {
            InitializeComponent();
            this.Text = "Show picture";
        }


        private void Ex15_Load(object sender, EventArgs e)
        {
            button1.Text = "View picture";  
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            panel1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"E:\city_bear.jpg");
        }
    }
}
