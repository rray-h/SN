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
    public partial class Ex14 : Form
    {

        String name_of_file;

        public Ex14()
        {
            InitializeComponent();
            this.Text = "Editor";
        }

        private void Ex14_Load(object sender, EventArgs e)
        {

            openFileDialog1.FileName = @"E:\Text1.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt) |*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt) |*.txt|All files (*.*)|*.*";


        }

        private void Record()
        {
            try
            {
                var Writer = new System.IO.StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding(1251));
                Writer.Write(textBox1.Text);
                Writer.Close();
            }
            catch (Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == String.Empty)
            {
                return;
            }

            try
            {
                var Reader = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            catch (System.IO.FileNotFoundException Situation)
            {
                MessageBox.Show(Situation.Message, "No file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Record();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex14_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false)
            {
                return;
            }
            var MBox = MessageBox.Show("Text was changed." + "Save changes?", "Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (MBox == DialogResult.No) return;
            if (MBox == DialogResult.Cancel) e.Cancel = true;
            if (MBox == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Record();
                    return;

                }
                else
                {
                    e.Cancel = true;
                }

            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var Reader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251));
                try
                {
                    printDocument1.Print();
                }
                finally
                {
                    Reader.Close();
                }
            }
            catch(Exception Situation)
            {
                MessageBox.Show(Situation.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Single String_on_page = 0.0F;
            Single Y = 0;
            var Left_end = e.MarginBounds.Left;
            var Top_end = e.MarginBounds.Top;
            var Str = String.Empty;
            var fnt = new Font("Times New Roman", 12.0F);

            String_on_page = e.MarginBounds.Height / Font.GetHeight(e.Graphics);

            var i = 0;

            while(i < String_on_page)
            {
                var Reader = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251));
                Str = Reader.ReadLine();

                Y = Top_end + i * Font.GetHeight(e.Graphics);
                e.Graphics.DrawString(Str, fnt, Brushes.Black, Left_end, Y, new StringFormat());
                i += 1;

                if(Str != null)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }
    }
}
