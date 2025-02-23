using System.Diagnostics;
using System.Threading.Tasks;

namespace ClickerSharp_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(525, 437);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Ajoutez cette ligne
        }

        int score = 0;
        bool hasDoubled = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (hasDoubled)
            {
                score += 2;
            }
            else
            {
                score++;
            }
            label3.Text = "Score: " + score.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void defineScore500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score += 500;
            label3.Text = "Score: " + score.ToString();
        }

        private void defineScore1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score += 1000;
            label3.Text = "Score: " + score.ToString();
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            label3.Text = "Score: " + score.ToString();
        }

        private void defineScore10000000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score += 10000000;
            label3.Text = "Score: " + score.ToString();
        }

        private void price500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score >= 500 && !hasDoubled)
            {
                score -= 500;
                hasDoubled = true;
                price500ToolStripMenuItem.Visible = false; // Change Hide() to Visible = false
            }
            label3.Text = "Score: " + score.ToString();
        }

        private async void price1500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score >= 1500)
            {
                score -= 1500;
                price1500ToolStripMenuItem.Visible = false; // Change Hide() to Visible = false
                while (true)
                {
                    score += 1;
                    label3.Text = "Score: " + score.ToString();
                    await Task.Delay(400);
                }
            }
        }

        private void price5000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score >= 5000)
            {
                price5000ToolStripMenuItem.Visible = false; // Change Hide() to Visible = false
                score -= 5000;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                while (true)
                {
                    if (stopwatch.Elapsed.TotalSeconds >= 7)
                    {
                        score += 7;
                        break;
                    }

                    // Simulation de travail ou attente
                    Thread.Sleep(100); // Pause de 100 ms pour éviter une utilisation excessive du CPU
                }

                stopwatch.Stop();
            }
        }
    }
}
