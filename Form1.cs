using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace lifeSimulator
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        //currency and modifiers
        double stars = 0;
        double starsModifier = 1.0;
        int clicks = 0;
        int clicksModifier = 1;
        double timeModifier = 1.0;

        //upgrades
        bool upgrade1Bought = false;

        private void timer_Tick(object sender, EventArgs e)
        {
            starsVar.Text = "Stars: " + stars;
            starsLabel.Text = "Stars: " + stars;
        }

        double starsFunc(double baseStars)
        {
            double finalStars = baseStars * starsModifier;
            return finalStars;
        }

        int clicksFunc(int baseClicks)
        {
            int finalClicks = baseClicks * clicksModifier;
            return finalClicks;
        }

        int unlockFunc(int currentClicks)
        {
            if (currentClicks >= 10)
            {
                label2.Visible = true;
                htmlCssButton.Visible = true;
                htmlCssBar.Visible = true;
                tabPage2.Visible = true;
            }
            if (currentClicks >= 25)
            {
                upgrade1.Visible = true;
            }
            return 0;
        }

        double timeFunc(double baseTime)
        {
            double finalTime = baseTime * timeModifier;
            return finalTime;
        }

        async Task barFunc(double time, ProgressBar bar)
        {
            int tick = (int)(time / 5);
            int steps = (int)(time / tick);
            int increment = bar.Maximum / steps;

            bar.Value = 0;
            for (int i = 0; i < steps; i++)
            {
                bar.Value = Math.Min(bar.Maximum, bar.Value + increment);
                await Task.Delay(tick);
            }

            int finalDelay = 350;
            if (time >= 2000)
            {
                finalDelay = 200;
            }

            bar.Value = bar.Maximum;
            await Task.Delay(finalDelay);
            bar.Value = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int time = 1000;
            double buttonTime = timeFunc(time);
            await barFunc(timeFunc(buttonTime), pokedexBar);
            stars += starsFunc(1);
            clicks += clicksFunc(1);
            unlockFunc(clicks);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Text = "Stars: " + stars;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            int time = 2000;
            double buttonTime = timeFunc(time);
            await barFunc(timeFunc(buttonTime), htmlCssBar);
            stars += starsFunc(2.5);
            clicks += clicksFunc(1);
            unlockFunc(clicks);
        }

        private void upgrade1_Click_1(object sender, EventArgs e)
        {
            if (upgrade1Bought)
            {
                MessageBox.Show("You already bought the upgrade!");
                return;
            }

            if (stars >= 130)
            {
                upgrade1.Text = "First 'Hello World' (Bought)";
                starsModifier *= 1.2;
                stars -= 130;
                upgrade1Bought = true;
            }
            else
            {
                MessageBox.Show("You need 130 stars to buy this upgrade!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
