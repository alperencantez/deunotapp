using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kararyapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToInt32(maskedTextBox1.Text);
            double final = Convert.ToInt32(maskedTextBox2.Text);
            double sonuc = vize * 0.40 + final * 0.60;

            if (vize * 0.40 + final * 0.60 >= 50)
            {
                label4.Text = "Tebrikler! Başarılı!";
            }
            else
            {
                label4.Text = "Maalesef, başarısız!";
            }
            label6.Text = sonuc.ToString();
        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBox2.SelectionStart = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            button1.Enabled = false;
            checkBox1.Checked = false;
            label6.Text = "";
            label4.Text = "";
        }
    }
}