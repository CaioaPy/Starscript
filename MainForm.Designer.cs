namespace lifeSimulator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            upgradesTab = new TabPage();
            panel1 = new Panel();
            upgrade4Label = new Label();
            upgrade4Button = new Button();
            upgrade3Label = new Label();
            upgrade3Button = new Button();
            upgrade2Label = new Label();
            upgrade1Label = new Label();
            upgrade2 = new Button();
            upgrade1 = new Button();
            starsLabel = new Label();
            groupBox1 = new GroupBox();
            hScrollBar1 = new HScrollBar();
            button2 = new Button();
            workTab = new TabPage();
            workPanel = new Panel();
            calculatorBar = new ProgressBar();
            label5 = new Label();
            calculatorButton = new Button();
            badDocumentationBar = new ProgressBar();
            label4 = new Label();
            badDocumentationButton = new Button();
            toDoBar = new ProgressBar();
            label3 = new Label();
            toDoButton = new Button();
            starsVar = new Label();
            htmlCssBar = new ProgressBar();
            pokedexButton = new Button();
            pokedexBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            htmlCssButton = new Button();
            tabControl = new TabControl();
            internsTab = new TabPage();
            panel2 = new Panel();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            pokedexInternButton = new Button();
            internsStarLabel = new Label();
            groupBox2 = new GroupBox();
            hScrollBar2 = new HScrollBar();
            button6 = new Button();
            upgradesTab.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            workTab.SuspendLayout();
            workPanel.SuspendLayout();
            tabControl.SuspendLayout();
            internsTab.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // upgradesTab
            // 
            upgradesTab.AutoScroll = true;
            upgradesTab.BackColor = Color.White;
            upgradesTab.Controls.Add(panel1);
            upgradesTab.Controls.Add(groupBox1);
            upgradesTab.Location = new Point(4, 24);
            upgradesTab.Name = "upgradesTab";
            upgradesTab.Padding = new Padding(3);
            upgradesTab.Size = new Size(922, 422);
            upgradesTab.TabIndex = 1;
            upgradesTab.Text = "Upgrades";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(upgrade4Label);
            panel1.Controls.Add(upgrade4Button);
            panel1.Controls.Add(upgrade3Label);
            panel1.Controls.Add(upgrade3Button);
            panel1.Controls.Add(upgrade2Label);
            panel1.Controls.Add(upgrade1Label);
            panel1.Controls.Add(upgrade2);
            panel1.Controls.Add(upgrade1);
            panel1.Controls.Add(starsLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 661);
            panel1.TabIndex = 4;
            // 
            // upgrade4Label
            // 
            upgrade4Label.Font = new Font("Calisto MT", 24F);
            upgrade4Label.Location = new Point(184, 437);
            upgrade4Label.Name = "upgrade4Label";
            upgrade4Label.Size = new Size(646, 81);
            upgrade4Label.TabIndex = 10;
            upgrade4Label.Text = "You finally wrote one—and it makes sense.";
            upgrade4Label.TextAlign = ContentAlignment.MiddleLeft;
            upgrade4Label.Visible = false;
            // 
            // upgrade4Button
            // 
            upgrade4Button.BackColor = Color.Black;
            upgrade4Button.Font = new Font("Cambria", 12F);
            upgrade4Button.ForeColor = Color.LimeGreen;
            upgrade4Button.Location = new Point(3, 427);
            upgrade4Button.Name = "upgrade4Button";
            upgrade4Button.Size = new Size(148, 113);
            upgrade4Button.TabIndex = 9;
            upgrade4Button.Text = "[620 stars] README Enlightenment (+50% stars)";
            upgrade4Button.UseVisualStyleBackColor = false;
            upgrade4Button.Visible = false;
            upgrade4Button.Click += upgrade4Button_Click;
            // 
            // upgrade3Label
            // 
            upgrade3Label.Font = new Font("Calisto MT", 24F);
            upgrade3Label.Location = new Point(184, 309);
            upgrade3Label.Name = "upgrade3Label";
            upgrade3Label.Size = new Size(646, 81);
            upgrade3Label.TabIndex = 8;
            upgrade3Label.Text = "You’ve made your first public repo—welcome to the void community.";
            upgrade3Label.TextAlign = ContentAlignment.MiddleLeft;
            upgrade3Label.Visible = false;
            // 
            // upgrade3Button
            // 
            upgrade3Button.BackColor = Color.Black;
            upgrade3Button.Font = new Font("Cambria", 12F);
            upgrade3Button.ForeColor = Color.LimeGreen;
            upgrade3Button.Location = new Point(3, 299);
            upgrade3Button.Name = "upgrade3Button";
            upgrade3Button.Size = new Size(148, 113);
            upgrade3Button.TabIndex = 7;
            upgrade3Button.Text = "[400 stars] Github Initiation (passive stars)";
            upgrade3Button.UseVisualStyleBackColor = false;
            upgrade3Button.Visible = false;
            upgrade3Button.Click += upgrade3Button_Click;
            // 
            // upgrade2Label
            // 
            upgrade2Label.AutoSize = true;
            upgrade2Label.Font = new Font("Calisto MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upgrade2Label.Location = new Point(184, 200);
            upgrade2Label.Name = "upgrade2Label";
            upgrade2Label.Size = new Size(603, 37);
            upgrade2Label.TabIndex = 6;
            upgrade2Label.Text = "Ancient knowledge, copied with reverence.";
            upgrade2Label.TextAlign = ContentAlignment.MiddleLeft;
            upgrade2Label.Visible = false;
            // 
            // upgrade1Label
            // 
            upgrade1Label.AutoSize = true;
            upgrade1Label.Font = new Font("Calisto MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upgrade1Label.Location = new Point(184, 72);
            upgrade1Label.Name = "upgrade1Label";
            upgrade1Label.Size = new Size(569, 37);
            upgrade1Label.TabIndex = 5;
            upgrade1Label.Text = "You spoke to the void—and it answered.";
            upgrade1Label.Visible = false;
            // 
            // upgrade2
            // 
            upgrade2.BackColor = Color.Black;
            upgrade2.Font = new Font("Cambria", 12F);
            upgrade2.ForeColor = Color.LimeGreen;
            upgrade2.Location = new Point(3, 168);
            upgrade2.Name = "upgrade2";
            upgrade2.Size = new Size(148, 113);
            upgrade2.TabIndex = 4;
            upgrade2.Text = "[230 stars] StackOverflow Link Scrolls (+25% work speed)";
            upgrade2.UseVisualStyleBackColor = false;
            upgrade2.Visible = false;
            upgrade2.Click += upgrade2_Click;
            // 
            // upgrade1
            // 
            upgrade1.BackColor = Color.Black;
            upgrade1.Font = new Font("Cambria", 12F);
            upgrade1.ForeColor = Color.LimeGreen;
            upgrade1.Location = new Point(3, 40);
            upgrade1.Name = "upgrade1";
            upgrade1.Size = new Size(148, 113);
            upgrade1.TabIndex = 3;
            upgrade1.Text = "[50 stars] First 'Hello World' (+30% stars)";
            upgrade1.UseVisualStyleBackColor = false;
            upgrade1.Visible = false;
            upgrade1.Click += upgrade1_Click_1;
            // 
            // starsLabel
            // 
            starsLabel.AutoSize = true;
            starsLabel.Font = new Font("Segoe UI", 20F);
            starsLabel.Location = new Point(0, 0);
            starsLabel.Name = "starsLabel";
            starsLabel.Size = new Size(101, 37);
            starsLabel.TabIndex = 1;
            starsLabel.Text = "Stars: 0";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(hScrollBar1);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 20F);
            groupBox1.Location = new Point(159, 5892);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(940, 195);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Upgrades";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hScrollBar1.Location = new Point(0, 251);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(926, 17);
            hScrollBar1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Cambria", 12F);
            button2.ForeColor = Color.LimeGreen;
            button2.Location = new Point(6, 42);
            button2.Name = "button2";
            button2.Size = new Size(148, 113);
            button2.TabIndex = 0;
            button2.Text = "[130 stars] First 'Hello World' (+20% stars)";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            // 
            // workTab
            // 
            workTab.AutoScroll = true;
            workTab.Controls.Add(workPanel);
            workTab.Location = new Point(4, 24);
            workTab.Name = "workTab";
            workTab.Padding = new Padding(3);
            workTab.Size = new Size(922, 422);
            workTab.TabIndex = 0;
            workTab.Text = "Work";
            workTab.UseVisualStyleBackColor = true;
            // 
            // workPanel
            // 
            workPanel.Controls.Add(calculatorBar);
            workPanel.Controls.Add(label5);
            workPanel.Controls.Add(calculatorButton);
            workPanel.Controls.Add(badDocumentationBar);
            workPanel.Controls.Add(label4);
            workPanel.Controls.Add(badDocumentationButton);
            workPanel.Controls.Add(toDoBar);
            workPanel.Controls.Add(label3);
            workPanel.Controls.Add(toDoButton);
            workPanel.Controls.Add(starsVar);
            workPanel.Controls.Add(htmlCssBar);
            workPanel.Controls.Add(pokedexButton);
            workPanel.Controls.Add(pokedexBar);
            workPanel.Controls.Add(label1);
            workPanel.Controls.Add(label2);
            workPanel.Controls.Add(htmlCssButton);
            workPanel.Dock = DockStyle.Top;
            workPanel.Location = new Point(3, 3);
            workPanel.Name = "workPanel";
            workPanel.Size = new Size(916, 419);
            workPanel.TabIndex = 8;
            // 
            // calculatorBar
            // 
            calculatorBar.Location = new Point(16, 324);
            calculatorBar.Name = "calculatorBar";
            calculatorBar.Size = new Size(251, 23);
            calculatorBar.TabIndex = 16;
            calculatorBar.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(10, 293);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 15;
            label5.Text = "JS Calculator";
            label5.Visible = false;
            // 
            // calculatorButton
            // 
            calculatorButton.Location = new Point(15, 353);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(124, 32);
            calculatorButton.TabIndex = 14;
            calculatorButton.Text = "COMMIT!!";
            calculatorButton.UseVisualStyleBackColor = true;
            calculatorButton.Visible = false;
            calculatorButton.Click += calculatorButton_Click;
            // 
            // badDocumentationBar
            // 
            badDocumentationBar.Location = new Point(338, 207);
            badDocumentationBar.Name = "badDocumentationBar";
            badDocumentationBar.Size = new Size(251, 23);
            badDocumentationBar.TabIndex = 13;
            badDocumentationBar.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(332, 176);
            label4.Name = "label4";
            label4.Size = new Size(272, 28);
            label4.TabIndex = 12;
            label4.Text = "Write Bad Documentation \\o/";
            label4.Visible = false;
            // 
            // badDocumentationButton
            // 
            badDocumentationButton.Location = new Point(337, 236);
            badDocumentationButton.Name = "badDocumentationButton";
            badDocumentationButton.Size = new Size(124, 32);
            badDocumentationButton.TabIndex = 11;
            badDocumentationButton.Text = "COMMIT!!";
            badDocumentationButton.UseVisualStyleBackColor = true;
            badDocumentationButton.Visible = false;
            badDocumentationButton.Click += badDocumentationButton_Click;
            // 
            // toDoBar
            // 
            toDoBar.Location = new Point(13, 207);
            toDoBar.Name = "toDoBar";
            toDoBar.Size = new Size(251, 23);
            toDoBar.TabIndex = 10;
            toDoBar.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(7, 176);
            label3.Name = "label3";
            label3.Size = new Size(302, 28);
            label3.TabIndex = 9;
            label3.Text = "To-Do List... Wow... How original...";
            label3.Visible = false;
            // 
            // toDoButton
            // 
            toDoButton.Location = new Point(12, 236);
            toDoButton.Name = "toDoButton";
            toDoButton.Size = new Size(124, 32);
            toDoButton.TabIndex = 8;
            toDoButton.Text = "COMMIT!!";
            toDoButton.UseVisualStyleBackColor = true;
            toDoButton.Visible = false;
            toDoButton.Click += toDoButton_Click;
            // 
            // starsVar
            // 
            starsVar.AutoSize = true;
            starsVar.Font = new Font("Segoe UI", 20F);
            starsVar.Location = new Point(0, 0);
            starsVar.Name = "starsVar";
            starsVar.Size = new Size(101, 37);
            starsVar.TabIndex = 1;
            starsVar.Text = "Stars: 0";
            // 
            // htmlCssBar
            // 
            htmlCssBar.Location = new Point(332, 80);
            htmlCssBar.Name = "htmlCssBar";
            htmlCssBar.Size = new Size(251, 23);
            htmlCssBar.TabIndex = 7;
            htmlCssBar.Visible = false;
            // 
            // pokedexButton
            // 
            pokedexButton.Location = new Point(9, 109);
            pokedexButton.Name = "pokedexButton";
            pokedexButton.Size = new Size(124, 32);
            pokedexButton.TabIndex = 0;
            pokedexButton.Text = "COMMIT!!";
            pokedexButton.UseVisualStyleBackColor = true;
            pokedexButton.Click += button1_Click;
            // 
            // pokedexBar
            // 
            pokedexBar.Location = new Point(10, 80);
            pokedexBar.Name = "pokedexBar";
            pokedexBar.Size = new Size(251, 23);
            pokedexBar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(7, 49);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 3;
            label1.Text = "Create a Pokédex Repository";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(326, 49);
            label2.Name = "label2";
            label2.Size = new Size(257, 28);
            label2.TabIndex = 5;
            label2.Text = "Your first HTML CSS project!";
            label2.Visible = false;
            // 
            // htmlCssButton
            // 
            htmlCssButton.Location = new Point(331, 109);
            htmlCssButton.Name = "htmlCssButton";
            htmlCssButton.Size = new Size(124, 32);
            htmlCssButton.TabIndex = 4;
            htmlCssButton.Text = "COMMIT!!";
            htmlCssButton.UseVisualStyleBackColor = true;
            htmlCssButton.Visible = false;
            htmlCssButton.Click += button1_Click_1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(workTab);
            tabControl.Controls.Add(upgradesTab);
            tabControl.Controls.Add(internsTab);
            tabControl.Location = new Point(-3, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(930, 450);
            tabControl.TabIndex = 0;
            // 
            // internsTab
            // 
            internsTab.AutoScroll = true;
            internsTab.BackColor = Color.White;
            internsTab.Controls.Add(panel2);
            internsTab.Controls.Add(groupBox2);
            internsTab.Location = new Point(4, 24);
            internsTab.Name = "internsTab";
            internsTab.Padding = new Padding(3);
            internsTab.Size = new Size(922, 422);
            internsTab.TabIndex = 2;
            internsTab.Text = "Interns";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pokedexInternButton);
            panel2.Controls.Add(internsStarLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 661);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(176, 25);
            label6.Name = "label6";
            label6.Size = new Size(611, 41);
            label6.TabIndex = 7;
            label6.Text = "Outsourcing Insight (Interns)";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Calisto MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(176, 234);
            label8.Name = "label8";
            label8.Size = new Size(622, 81);
            label8.TabIndex = 6;
            label8.Text = "Always stuck in a loop, but enthusiastic. He's in for pokédex.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Calisto MT", 18F);
            label9.Location = new Point(3, 95);
            label9.Name = "label9";
            label9.Size = new Size(893, 76);
            label9.TabIndex = 5;
            label9.Text = "You’ve stopped growing from the simple tasks. You now guide others. You hire, delegate, and orchestrate what once taught you everything.";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pokedexInternButton
            // 
            pokedexInternButton.BackColor = Color.Black;
            pokedexInternButton.Font = new Font("Cambria", 12F);
            pokedexInternButton.ForeColor = Color.LimeGreen;
            pokedexInternButton.Location = new Point(3, 224);
            pokedexInternButton.Name = "pokedexInternButton";
            pokedexInternButton.Size = new Size(148, 113);
            pokedexInternButton.TabIndex = 4;
            pokedexInternButton.Text = "[70 stars] Loopie (automates Pokédex work)";
            pokedexInternButton.UseVisualStyleBackColor = false;
            pokedexInternButton.Click += pokedexInternButton_Click;
            // 
            // internsStarLabel
            // 
            internsStarLabel.AutoSize = true;
            internsStarLabel.Font = new Font("Segoe UI", 20F);
            internsStarLabel.Location = new Point(3, 171);
            internsStarLabel.Name = "internsStarLabel";
            internsStarLabel.Size = new Size(101, 37);
            internsStarLabel.TabIndex = 1;
            internsStarLabel.Text = "Stars: 0";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(hScrollBar2);
            groupBox2.Controls.Add(button6);
            groupBox2.Font = new Font("Segoe UI", 20F);
            groupBox2.Location = new Point(511, 5892);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 195);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Upgrades";
            // 
            // hScrollBar2
            // 
            hScrollBar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hScrollBar2.Location = new Point(0, 346);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(926, 17);
            hScrollBar2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Font = new Font("Cambria", 12F);
            button6.ForeColor = Color.LimeGreen;
            button6.Location = new Point(6, 42);
            button6.Name = "button6";
            button6.Size = new Size(148, 113);
            button6.TabIndex = 0;
            button6.Text = "[130 stars] First 'Hello World' (+20% stars)";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Starscript";
            upgradesTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            workTab.ResumeLayout(false);
            workPanel.ResumeLayout(false);
            workPanel.PerformLayout();
            tabControl.ResumeLayout(false);
            internsTab.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage upgradesTab;
        private Button upgrade1;
        private GroupBox groupBox1;
        private HScrollBar hScrollBar1;
        private Button button2;
        private Label starsLabel;
        private TabPage workTab;
        private ProgressBar htmlCssBar;
        private ProgressBar pokedexBar;
        private Label label2;
        private Button htmlCssButton;
        private Label label1;
        private Label starsVar;
        private Button pokedexButton;
        private TabControl tabControl;
        private Panel workPanel;
        private ProgressBar badDocumentationBar;
        private Label label4;
        private Button badDocumentationButton;
        private ProgressBar toDoBar;
        private Label label3;
        private Button toDoButton;
        private Panel panel1;
        private ProgressBar calculatorBar;
        private Label label5;
        private Button calculatorButton;
        private Button upgrade2;
        private Label upgrade1Label;
        private Label upgrade2Label;
        private Label upgrade3Label;
        private Button upgrade3Button;
        private Label upgrade4Label;
        private Button upgrade4Button;
        private TabPage internsTab;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Button pokedexInternButton;
        private Label internsStarLabel;
        private GroupBox groupBox2;
        private HScrollBar hScrollBar2;
        private Button button6;
        private Label label6;
    }
}
