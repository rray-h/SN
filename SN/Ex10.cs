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
    public partial class Ex10 : Form
    {
        public Ex10()
        {
            InitializeComponent();
            this.Text = "Mouse movement monitoring";
        }

        private void listBox1_MouseEnter_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cursor of the mouse has entered to the field of the ListBox");
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cursor of the mouse came out to the field of the ListBox");

        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = String.Format("x = {0} or {1}", Control.MousePosition.X, e.X);
            textBox2.Text = String.Format("x = {0} or {1}", Control.MousePosition.Y, e.Y);
        }
    }
}
