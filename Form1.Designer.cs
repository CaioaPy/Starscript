namespace lifeSimulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            upgradesTab = new TabPage();
            panel1 = new Panel();
            button3 = new Button();
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
            upgradesTab.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            workTab.SuspendLayout();
            workPanel.SuspendLayout();
            tabControl.SuspendLayout();
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
            upgradesTab.Click += tabPage2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(upgrade1);
            panel1.Controls.Add(starsLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 661);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Cambria", 12F);
            button3.ForeColor = Color.LimeGreen;
            button3.Location = new Point(3, 168);
            button3.Name = "button3";
            button3.Size = new Size(148, 113);
            button3.TabIndex = 4;
            button3.Text = "[130 stars] First 'Hello World' (+20% stars)";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
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
            upgrade1.Text = "[130 stars] First 'Hello World' (+20% stars)";
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
            starsLabel.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(hScrollBar1);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 20F);
            groupBox1.Location = new Point(294, 2262);
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
            workTab.Click += tabPage1_Click;
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
            calculatorBar.Location = new Point(24, 332);
            calculatorBar.Name = "calculatorBar";
            calculatorBar.Size = new Size(251, 23);
            calculatorBar.TabIndex = 16;
            calculatorBar.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(18, 301);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 15;
            label5.Text = "JS Calculator";
            label5.Visible = false;
            label5.Click += label5_Click_1;
            // 
            // calculatorButton
            // 
            calculatorButton.Location = new Point(23, 361);
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
            badDocumentationBar.Location = new Point(338, 215);
            badDocumentationBar.Name = "badDocumentationBar";
            badDocumentationBar.Size = new Size(251, 23);
            badDocumentationBar.TabIndex = 13;
            badDocumentationBar.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(332, 184);
            label4.Name = "label4";
            label4.Size = new Size(272, 28);
            label4.TabIndex = 12;
            label4.Text = "Write Bad Documentation \\o/";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // badDocumentationButton
            // 
            badDocumentationButton.Location = new Point(337, 244);
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
            toDoBar.Location = new Point(21, 215);
            toDoBar.Name = "toDoBar";
            toDoBar.Size = new Size(251, 23);
            toDoBar.TabIndex = 10;
            toDoBar.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(15, 184);
            label3.Name = "label3";
            label3.Size = new Size(302, 28);
            label3.TabIndex = 9;
            label3.Text = "To-Do List... Wow... How original...";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // toDoButton
            // 
            toDoButton.Location = new Point(20, 244);
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
            starsVar.Location = new Point(8, 0);
            starsVar.Name = "starsVar";
            starsVar.Size = new Size(101, 37);
            starsVar.TabIndex = 1;
            starsVar.Text = "Stars: 0";
            starsVar.Click += label1_Click;
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
            pokedexButton.Location = new Point(17, 109);
            pokedexButton.Name = "pokedexButton";
            pokedexButton.Size = new Size(124, 32);
            pokedexButton.TabIndex = 0;
            pokedexButton.Text = "COMMIT!!";
            pokedexButton.UseVisualStyleBackColor = true;
            pokedexButton.Click += button1_Click;
            // 
            // pokedexBar
            // 
            pokedexBar.Location = new Point(18, 80);
            pokedexBar.Name = "pokedexBar";
            pokedexBar.Size = new Size(251, 23);
            pokedexBar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(15, 49);
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
            tabControl.Location = new Point(-3, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(930, 450);
            tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Starscript";
            Load += Form1_Load;
            upgradesTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            workTab.ResumeLayout(false);
            workPanel.ResumeLayout(false);
            workPanel.PerformLayout();
            tabControl.ResumeLayout(false);
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
        private Button button3;
    }
}
