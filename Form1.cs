namespace lifeSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //currency and modifiers
        double stars = 0;
        double starsModifier = 1;
        int clicks = 0;
        int clicksModifier = 1;

        //upgrades
        bool upgrade1Bought = false;

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
            }
            if (currentClicks >= 25)
            {
                upgrade1.Visible = true;
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Text = "Stars: " + stars;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stars += starsFunc(1);
            starsVar.Text = "Stars: " + stars;
            clicks += clicksFunc(1);
            unlockFunc(clicks);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Text = "Stars: " + stars;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stars += starsFunc(2.5);
            starsVar.Text = "Stars: " + stars;
            clicks += clicksFunc(1);
            unlockFunc(clicks);
        }

        private void upgrade1_Click(object sender, EventArgs e)
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
    }
}
