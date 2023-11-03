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
    public partial class Ex12 : Form
    {
        public Ex12()
        {
            InitializeComponent();
            this.Text = "LinkLabel";
        }

        private void Ex12_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "www.mail.ru";
            linkLabel2.Text = @"Folder C:\Windows\";
            linkLabel3.Text = "Call \"Блокнот\"";

            linkLabel1.LinkVisited = true;
            linkLabel2.LinkVisited = true;
            linkLabel3.LinkVisited = true;
        }

        private void Link(object sender, EventArgs e)
        {
            var link = (LinkLabel)sender;

            switch (link.Name)
            {
                case "linkLabel1": System.Diagnostics.Process.Start("IExplore.exe", "http://www.nail.ru"); break;
                case "linkLabel2": System.Diagnostics.Process.Start("C:\\windows\\"); break;
                case "linkLabel3": System.Diagnostics.Process.Start("Notepad", "text.txt"); break;

            }
        }

    }
}
