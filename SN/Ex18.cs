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
    public partial class Ex18 : Form
    {

        bool is_draw;
        public Ex18()
        {
            InitializeComponent();
            this.Text = "mini Paint";
        }

        private void Ex18_Load(object sender, EventArgs e)
        {
            button1.Text = "Clear";
            is_draw = false;


        }

        private void Ex18_MouseDown(object sender, MouseEventArgs e)
        {
            is_draw = true;
        }

        private void Ex18_MouseUp(object sender, MouseEventArgs e)
        {
            is_draw = false;
        }

        private void Ex18_MouseMove(object sender, MouseEventArgs e)
        {
            if(is_draw == true)
            {
                var Graphic = CreateGraphics();
                Graphic.FillRectangle(new SolidBrush(Color.Red), e.X, e.Y, 5, 5);
                Graphic.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Graphic = CreateGraphics();
            Graphic.Clear(this.BackColor);

            Graphic.Clear(SystemColors.Control);
            
        }
    }
}
