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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex4 ex4 = new Ex4();
            ex4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ex5 ex5 = new Ex5();
            ex5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ex6 ex6 = new Ex6();
            ex6.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Решения";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ex7 ex7 = new Ex7();
            ex7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ex8 ex8 = new Ex8();
            ex8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ex9 ex9 = new Ex9();
            ex9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ex10 ex10 = new Ex10();
            ex10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ex11 ex11 = new Ex11();
            ex11.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ex12 ex12 = new Ex12();
            ex12.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ex13 ex13 = new Ex13();
            ex13.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ex14 ex14 = new Ex14();
            ex14.Show();
        }
    }
}
