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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            pokedexBar = new ProgressBar();
            label2 = new Label();
            htmlCssButton = new Button();
            label1 = new Label();
            starsVar = new Label();
            pokedexButton = new Button();
            tabPage2 = new TabPage();
            upgrade1 = new Button();
            groupBox1 = new GroupBox();
            hScrollBar1 = new HScrollBar();
            button2 = new Button();
            starsLabel = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(-3, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(930, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pokedexBar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(htmlCssButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(starsVar);
            tabPage1.Controls.Add(pokedexButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Work";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pokedexBar
            // 
            pokedexBar.Location = new Point(6, 80);
            pokedexBar.Name = "pokedexBar";
            pokedexBar.Size = new Size(251, 23);
            pokedexBar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 157);
            label2.Name = "label2";
            label2.Size = new Size(257, 28);
            label2.TabIndex = 5;
            label2.Text = "Your first HTML CSS project!";
            label2.Visible = false;
            // 
            // htmlCssButton
            // 
            htmlCssButton.Location = new Point(0, 211);
            htmlCssButton.Name = "htmlCssButton";
            htmlCssButton.Size = new Size(124, 32);
            htmlCssButton.TabIndex = 4;
            htmlCssButton.Text = "COMMIT!!";
            htmlCssButton.UseVisualStyleBackColor = true;
            htmlCssButton.Visible = false;
            htmlCssButton.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 3;
            label1.Text = "Create a Pokédex Repository";
            // 
            // starsVar
            // 
            starsVar.AutoSize = true;
            starsVar.Font = new Font("Segoe UI", 20F);
            starsVar.Location = new Point(-4, 0);
            starsVar.Name = "starsVar";
            starsVar.Size = new Size(101, 37);
            starsVar.TabIndex = 1;
            starsVar.Text = "Stars: 0";
            starsVar.Click += label1_Click;
            // 
            // pokedexButton
            // 
            pokedexButton.Location = new Point(6, 109);
            pokedexButton.Name = "pokedexButton";
            pokedexButton.Size = new Size(124, 32);
            pokedexButton.TabIndex = 0;
            pokedexButton.Text = "COMMIT!!";
            pokedexButton.UseVisualStyleBackColor = true;
            pokedexButton.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(upgrade1);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(starsLabel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Upgrades";
            tabPage2.Click += tabPage2_Click;
            // 
            // upgrade1
            // 
            upgrade1.BackColor = Color.Black;
            upgrade1.Font = new Font("Cambria", 12F);
            upgrade1.ForeColor = Color.LimeGreen;
            upgrade1.Location = new Point(11, 43);
            upgrade1.Name = "upgrade1";
            upgrade1.Size = new Size(148, 113);
            upgrade1.TabIndex = 3;
            upgrade1.Text = "[130 stars] First 'Hello World' (+20% stars)";
            upgrade1.UseVisualStyleBackColor = false;
            upgrade1.Visible = false;
            upgrade1.Click += upgrade1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(hScrollBar1);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 20F);
            groupBox1.Location = new Point(357, 568);
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
            // starsLabel
            // 
            starsLabel.AutoSize = true;
            starsLabel.Font = new Font("Segoe UI", 20F);
            starsLabel.Location = new Point(-4, 0);
            starsLabel.Name = "starsLabel";
            starsLabel.Size = new Size(101, 37);
            starsLabel.TabIndex = 1;
            starsLabel.Text = "Stars: 0";
            starsLabel.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Starscript";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Label starsVar;
        private Button pokedexButton;
        private Label label1;
        private Label label2;
        private Button htmlCssButton;
        private ProgressBar pokedexBar;
        private TabPage tabPage2;
        private Button upgrade1;
        private GroupBox groupBox1;
        private HScrollBar hScrollBar1;
        private Button button2;
        private Label starsLabel;
    }
}
