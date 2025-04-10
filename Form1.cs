using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace lifeSimulator
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private TabPage hiddenTab;

        List<TabPage> hiddenTabs = new List<TabPage>();

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            timer.Start();
            HideTab("upgradesTab"); //hide tab
        }

        //currency and modifiers
        double stars = 0;
        double starsModifier = 1.0;
        int clicks = 0;
        int clicksModifier = 1;
        double timeModifier = 1;

        //upgrades
        bool upgrade1Bought = false;
        bool upgrade2Bought = false;
        bool upgrade3Bought = false;
        bool upgrade4Bought = false;

        private void HideTab(string tabName)
        {
            var tabToHide = tabControl.TabPages
                .Cast<TabPage>()
                .FirstOrDefault(tab => tab.Name == tabName);

            if (tabToHide != null)
            {
                tabControl.TabPages.Remove(tabToHide);
                hiddenTabs.Add(tabToHide);
            }
        }

        private void ShowTab(string tabName, int index)
        {
            var tabToShow = hiddenTabs
                .FirstOrDefault(tab => tab.Name == tabName);

            if (tabToShow != null && !tabControl.TabPages.Contains(tabToShow))
            {
                tabControl.TabPages.Insert(index, tabToShow);
                hiddenTabs.Remove(tabToShow);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            starsVar.Text = "Stars: " + stars;
            starsLabel.Text = "Stars: " + stars;
            if (upgrade3Bought)
            {
                stars += Math.Floor(starsFunc(0.25) * 0.05);
            }
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
                upgrade1.Visible = true;
                upgrade1Label.Visible = true;
                ShowTab("upgradesTab", 1);
            }
            if (currentClicks >= 25)
            {
                upgrade2.Visible = true;
                upgrade2Label.Visible = true;
            }
            if (currentClicks >= 50)
            {
                label3.Visible = true;
                toDoButton.Visible = true;
                toDoBar.Visible = true;
                upgrade3Button.Visible = true;
                upgrade3Label.Visible = true;

            }
            if (currentClicks >= 60)
            {
                upgrade4Button.Visible = true;
                upgrade4Label.Visible = true;

            }
            if (currentClicks >= 75)
            {
                label4.Visible = true;
                badDocumentationBar.Visible = true;
                badDocumentationButton.Visible = true;
            }
            if (currentClicks >= 110)
            {
                label5.Visible = true;
                calculatorBar.Visible = true;
                calculatorButton.Visible = true;
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

            if (timeModifier < 0.90)
            {
                tick = (int)(time / 4);
            }
            if (timeModifier < 0.70)
            {
                tick = (int)(time / 3);
            }
            if (timeModifier < 0.50)
            {
                tick = (int)(time / 2);
            }

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

        bool cooldown1 = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!cooldown1)
            {
                int time = 1000;
                cooldown1 = true;
                double buttonTime = timeFunc(time);
                await barFunc(timeFunc(buttonTime), pokedexBar);
                stars += starsFunc(1);
                clicks += clicksFunc(1);
                unlockFunc(clicks);
                cooldown1 = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Text = "Stars: " + stars;
        }

        bool cooldown2 = false;
        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (!cooldown2)
            {
                int time = 2000;
                cooldown2 = true;
                double buttonTime = timeFunc(time);
                await barFunc(timeFunc(buttonTime), htmlCssBar);
                stars += starsFunc(2.5);
                clicks += clicksFunc(1);
                unlockFunc(clicks);
                cooldown2 = false;
            }
        }



        private void upgrade1_Click_1(object sender, EventArgs e)
        {
            if (upgrade1Bought)
            {
                MessageBox.Show("You already bought the upgrade!");
                return;
            }

            if (stars >= 50)
            {
                upgrade1.Text = "First 'Hello World' (Bought)";
                starsModifier *= 1.3;
                stars -= 50;
                upgrade1Bought = true;
            }
            else
            {
                MessageBox.Show("You need 50 stars to buy this upgrade!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        bool cooldown3 = false;
        private async void toDoButton_Click(object sender, EventArgs e)
        {
            if (!cooldown3)
            {
                int time = 3500;
                cooldown3 = true;
                double buttonTime = timeFunc(time);
                await barFunc(timeFunc(buttonTime), toDoBar);
                stars += starsFunc(6.5);
                clicks += clicksFunc(1);
                unlockFunc(clicks);
                cooldown3 = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        bool cooldown4 = false;
        private async void badDocumentationButton_Click(object sender, EventArgs e)
        {
            if (!cooldown4)
            {
                int time = 5500;
                cooldown4 = true;
                double buttonTime = timeFunc(time);
                await barFunc(timeFunc(buttonTime), badDocumentationBar);
                stars += starsFunc(12);
                clicks += clicksFunc(1);
                unlockFunc(clicks);
                cooldown4 = false;
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        bool cooldown5 = false;
        private async void calculatorButton_Click(object sender, EventArgs e)
        {
            if (!cooldown5)
            {
                int time = 8000;
                cooldown5 = true;
                double buttonTime = timeFunc(time);
                await barFunc(timeFunc(buttonTime), calculatorBar);
                stars += starsFunc(20);
                clicks += clicksFunc(1);
                unlockFunc(clicks);
                cooldown5 = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void upgrade2_Click(object sender, EventArgs e)
        {
            if (upgrade2Bought)
            {
                MessageBox.Show("You already bought the upgrade!");
                return;
            }

            if (stars >= 230)
            {
                upgrade2.Text = "StackOverflow Link Scrolls (Bought)";
                timeModifier *= 0.75;
                stars -= 230;
                upgrade2Bought = true;
            }
            else
            {
                MessageBox.Show("You need 230 stars to buy this upgrade!");
            }
        }

        private void upgrade2Label_Click(object sender, EventArgs e)
        {

        }

        private void upgrade3Button_Click(object sender, EventArgs e)
        {
            {
                if (upgrade3Bought)
                {
                    MessageBox.Show("You already bought the upgrade!");
                    return;
                }

                if (stars >= 400)
                {
                    upgrade3Button.Text = "Github Initiation (passive stars) (Bought)";
                    stars -= 400;
                    upgrade3Bought = true;
                }
                else
                {
                    MessageBox.Show("You need 400 stars to buy this upgrade!");
                }
            }
        }

        private void upgrade4Button_Click(object sender, EventArgs e)
        {
            {
                if (upgrade4Bought)
                {
                    MessageBox.Show("You already bought the upgrade!");
                    return;
                }

                if (stars >= 620)
                {
                    upgrade4Button.Text = "README Enlightenment (+50% stars) (Bought)";
                    stars -= 620;
                    starsModifier *= 1.5;
                    upgrade4Bought = true;
                }

                else
                {
                    MessageBox.Show("You need 620 stars to buy this upgrade!");
                }
            }
        }
    }
}
