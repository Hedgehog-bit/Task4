using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            if (x != 0)
            {
                textBox3.Text = Fanc(x, n).ToString();
            }
        }
        static double Fanc(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1 / Math.Pow(x, Math.Abs(n));
            if (n > 0) return x * Math.Pow(x, n - 1);
            Fanc(1, 0);
            return 0;
        }
        void Fanc2(int n, int s = 0)
        {
            if (n > 0)
            {
                for (int i = 0; i < s; i++)
                    textBox5.Text += " ";
                for (int i = 1; i < n + 1; i++)
                    textBox5.Text += i.ToString();
                if (s == 0) textBox5.Text += "\r\t n";
                if (s > 0) textBox5.Text += "\r\t n-" + s.ToString();
                textBox5.Text += "\r\n";
                Fanc2(n - 1, s + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox4.Text);
            Fanc2(n);
        }
    }
}
