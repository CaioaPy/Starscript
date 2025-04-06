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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            htmlCssButton = new Button();
            label1 = new Label();
            upgradesBox = new GroupBox();
            upgrade1 = new Button();
            starsVar = new Label();
            pokedexButton = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            upgradesBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(-3, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(930, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(htmlCssButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(upgradesBox);
            tabPage1.Controls.Add(starsVar);
            tabPage1.Controls.Add(pokedexButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "local";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(3, 132);
            label2.Name = "label2";
            label2.Size = new Size(257, 28);
            label2.TabIndex = 5;
            label2.Text = "Your first HTML CSS project!";
            label2.Visible = false;
            // 
            // htmlCssButton
            // 
            htmlCssButton.Location = new Point(3, 163);
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
            // upgradesBox
            // 
            upgradesBox.BackColor = Color.DarkGray;
            upgradesBox.Controls.Add(upgrade1);
            upgradesBox.Font = new Font("Segoe UI", 20F);
            upgradesBox.Location = new Point(-4, 249);
            upgradesBox.Name = "upgradesBox";
            upgradesBox.Size = new Size(921, 195);
            upgradesBox.TabIndex = 2;
            upgradesBox.TabStop = false;
            upgradesBox.Text = "Upgrades";
            upgradesBox.Enter += groupBox1_Enter;
            // 
            // upgrade1
            // 
            upgrade1.BackColor = Color.Black;
            upgrade1.Font = new Font("Cambria", 12F);
            upgrade1.ForeColor = Color.LimeGreen;
            upgrade1.Location = new Point(6, 42);
            upgrade1.Name = "upgrade1";
            upgrade1.Size = new Size(148, 113);
            upgrade1.TabIndex = 0;
            upgrade1.Text = "[130 stars] First 'Hello World' (+20% stars)";
            upgrade1.UseVisualStyleBackColor = false;
            upgrade1.Visible = false;
            upgrade1.Click += upgrade1_Click;
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
            pokedexButton.Location = new Point(3, 80);
            pokedexButton.Name = "pokedexButton";
            pokedexButton.Size = new Size(124, 32);
            pokedexButton.TabIndex = 0;
            pokedexButton.Text = "COMMIT!!";
            pokedexButton.UseVisualStyleBackColor = true;
            pokedexButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Life Simulator";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            upgradesBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Label starsVar;
        private Button pokedexButton;
        private GroupBox upgradesBox;
        private Label label1;
        private Label label2;
        private Button htmlCssButton;
        private Button upgrade1;
    }
}
