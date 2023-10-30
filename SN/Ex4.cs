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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void Ex4_Load(object sender, EventArgs e)
        {
            this.Text = "Enter the password";

            button1.Text = "Show the pass";
            label1.Text = "He doesn't see";
            textBox1.Text = String.Empty;
            textBox1.TabIndex = 0;
            textBox1.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
