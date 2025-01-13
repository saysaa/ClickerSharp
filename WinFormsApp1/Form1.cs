using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(500, 392);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score++;
            label3.Text = "Score: " + score.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Console.WriteLine("Score: " + score.ToString());
            }

        }
    }
}
