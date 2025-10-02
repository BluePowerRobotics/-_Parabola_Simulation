using System.Windows.Forms;
using System;
namespace 抛物线模拟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RenderTarget_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                axisDisplayer2.V = value;
                axisDisplayer2.Invalidate();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double value))
            {
                axisDisplayer2.Arg = value;
                axisDisplayer2.Invalidate();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double value))
            {
                axisDisplayer2.StuffX = value;
                axisDisplayer2.Invalidate();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox4.Text, out double value))
            {
                axisDisplayer2.StuffY = value;
                axisDisplayer2.Invalidate();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox5.Text, out double value))
            {
                axisDisplayer2.SWidth = value;
                axisDisplayer2.Invalidate();
            }
        }
    }
}
