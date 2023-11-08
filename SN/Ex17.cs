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
    public partial class Ex17 : Form
    {
        public Ex17()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Transparent") 
            {
                return;
            }
            this.BackColor = Color.FromName(listBox1.Text);
            this.Text = "Color: " + listBox1.Text;

        }

        private void Ex17_Load(object sender, EventArgs e)
        {
            var all_colors = Enum.GetNames(typeof(KnownColor));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(all_colors);
            listBox1.Sorted = true; 
        }
    }
}
