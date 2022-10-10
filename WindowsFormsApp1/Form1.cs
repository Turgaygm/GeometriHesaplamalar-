using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a,b, sonuc = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ("Kısa Kenar");
            label2.Text = ("Uzun Kenar");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ("Kısa Kenar");
            label2.Text = ("Uzun Kenar");
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                sonuc = a * b;
                MessageBox.Show("Sonuç :" + sonuc);
            }
            if (radioButton2.Checked)
            {
                sonuc = 2*(a+b);
                MessageBox.Show("Sonuç :" + sonuc);
            }
            if (radioButton3.Checked)
            {
                sonuc = (a * b)/2;
                MessageBox.Show("Sonuç :" + sonuc);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                label1.Text = ("Taban");
                label2.Text = ("Yükseklik");
        }
    }
}
