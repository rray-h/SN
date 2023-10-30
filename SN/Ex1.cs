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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void Ex1_Load(object sender, EventArgs e)
        {
            this.Text = "Hello";
            label1.Text = "Hover on me";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            button1.TextAlign = ContentAlignment.MiddleCenter;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello everyone");
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello everyone");
        }
    }
}
