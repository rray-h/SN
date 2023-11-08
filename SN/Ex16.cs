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
    public partial class Ex16 : Form
    {
        public Ex16()
        {
            InitializeComponent();
            this.Text = "WTF";
        }

        private void Ex16_Load(object sender, EventArgs e)
        {
            var Collection = new Object[] { "Circle", "Section", "Reactangle", "Sector", "Text", "Ellipse", "Fill sector" };
            listBox1.Items.AddRange(Collection);
            Font = new Font("Times New Roman", 12);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Graphic = CreateGraphics();
            var pen = new Pen(Color.Red);
            var stylus = new SolidBrush(Color.Red);

            Graphic.Clear(SystemColors.Control);

            switch (listBox1.SelectedIndex)
            {
                case 0: Graphic.DrawEllipse(pen, 50, 50, 150, 150); break;
                case 1: Graphic.DrawLine(pen, 50, 50, 200, 200); break;
                case 2: Graphic.DrawRectangle(pen, 50, 30, 150, 180); break;
                case 3: Graphic.DrawPie(pen, 40, 50, 200, 200, 180, 225); break;
                case 4: Graphic.DrawString("Something bla-bla-bla", Font, stylus, 10, 100); break;
                case 5: Graphic.DrawEllipse(pen, 30, 30, 150, 200); break;
                case 6: Graphic.FillPie(stylus, 20, 50, 150, 150, 0, 45); break;
            }
            Graphic.Dispose();
        }
    }
}
