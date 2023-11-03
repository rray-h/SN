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
    public partial class Ex13 : Form
    {
        public Ex13()
        {
            InitializeComponent();
            this.Text = "Which button pressed";
        }
        private void Ex13_Load(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            label2.Text = String.Empty;

        }

        private void Ex13_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Button pressed is: " + e.KeyChar;
        }

        private void Ex13_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = String.Empty;
            
            if(e.Alt == true)
            {
                label2.Text += "Alt: Yes\n";
            }
            else
            {
                label2.Text += "Alt: No\n";
            }
            if (e.Shift == true)
            {
                label2.Text += "Shift: Yes\n";
            }
            else
            {
                label2.Text += "Shift: No\n";
            }
            if (e.Control == true)
            {
                label2.Text += "Ctrl: Yes\n";
            }
            else
            {
                label2.Text += "Ctrl: No\n";
            }

            label2.Text += String.Format("Key: {0} \nKeyData: {1} \nKeyValue: {2}", e.KeyCode, e.KeyData, e.KeyValue);
        }

        private void Ex13_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = String.Empty;
            label2.Text = String.Empty;
        }
    }
}
