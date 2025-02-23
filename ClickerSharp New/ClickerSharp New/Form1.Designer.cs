namespace ClickerSharp_New
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
            button1 = new Button();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            shopToolStripMenuItem = new ToolStripMenuItem();
            boostX7ToolStripMenuItem = new ToolStripMenuItem();
            price5000ToolStripMenuItem = new ToolStripMenuItem();
            autoClickerToolStripMenuItem = new ToolStripMenuItem();
            price1500ToolStripMenuItem = new ToolStripMenuItem();
            click2ToolStripMenuItem = new ToolStripMenuItem();
            price500ToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            yesToolStripMenuItem = new ToolStripMenuItem();
            noToolStripMenuItem = new ToolStripMenuItem();
            cheatsToolStripMenuItem = new ToolStripMenuItem();
            scoreToolStripMenuItem = new ToolStripMenuItem();
            defineScore500ToolStripMenuItem = new ToolStripMenuItem();
            defineScore1000ToolStripMenuItem = new ToolStripMenuItem();
            defineScore10000000ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(156, 150);
            button1.Name = "button1";
            button1.Size = new Size(181, 88);
            button1.TabIndex = 1;
            button1.Text = "Click!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(156, 117);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 2;
            label3.Text = "Score: ";
            label3.Click += label3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { shopToolStripMenuItem, optionsToolStripMenuItem, cheatsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 374);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(509, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // shopToolStripMenuItem
            // 
            shopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boostX7ToolStripMenuItem, autoClickerToolStripMenuItem, click2ToolStripMenuItem });
            shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            shopToolStripMenuItem.Size = new Size(46, 20);
            shopToolStripMenuItem.Text = "Shop";
            // 
            // boostX7ToolStripMenuItem
            // 
            boostX7ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { price5000ToolStripMenuItem });
            boostX7ToolStripMenuItem.Name = "boostX7ToolStripMenuItem";
            boostX7ToolStripMenuItem.Size = new Size(180, 22);
            boostX7ToolStripMenuItem.Text = "Boost x7 ( 10 sec )";
            // 
            // price5000ToolStripMenuItem
            // 
            price5000ToolStripMenuItem.Name = "price5000ToolStripMenuItem";
            price5000ToolStripMenuItem.Size = new Size(180, 22);
            price5000ToolStripMenuItem.Text = "Price : 5000";
            price5000ToolStripMenuItem.Click += price5000ToolStripMenuItem_Click;
            // 
            // autoClickerToolStripMenuItem
            // 
            autoClickerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { price1500ToolStripMenuItem });
            autoClickerToolStripMenuItem.Name = "autoClickerToolStripMenuItem";
            autoClickerToolStripMenuItem.Size = new Size(180, 22);
            autoClickerToolStripMenuItem.Text = "AutoClicker";
            // 
            // price1500ToolStripMenuItem
            // 
            price1500ToolStripMenuItem.Name = "price1500ToolStripMenuItem";
            price1500ToolStripMenuItem.Size = new Size(133, 22);
            price1500ToolStripMenuItem.Text = "Price : 1500";
            price1500ToolStripMenuItem.Click += price1500ToolStripMenuItem_Click;
            // 
            // click2ToolStripMenuItem
            // 
            click2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { price500ToolStripMenuItem });
            click2ToolStripMenuItem.Name = "click2ToolStripMenuItem";
            click2ToolStripMenuItem.Size = new Size(180, 22);
            click2ToolStripMenuItem.Text = "Click +2";
            // 
            // price500ToolStripMenuItem
            // 
            price500ToolStripMenuItem.Name = "price500ToolStripMenuItem";
            price500ToolStripMenuItem.Size = new Size(127, 22);
            price500ToolStripMenuItem.Text = "Price : 500";
            price500ToolStripMenuItem.Click += price500ToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yesToolStripMenuItem, noToolStripMenuItem });
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(102, 22);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // yesToolStripMenuItem
            // 
            yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            yesToolStripMenuItem.Size = new Size(91, 22);
            yesToolStripMenuItem.Text = "Yes";
            yesToolStripMenuItem.Click += yesToolStripMenuItem_Click;
            // 
            // noToolStripMenuItem
            // 
            noToolStripMenuItem.Name = "noToolStripMenuItem";
            noToolStripMenuItem.Size = new Size(91, 22);
            noToolStripMenuItem.Text = "No";
            // 
            // cheatsToolStripMenuItem
            // 
            cheatsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scoreToolStripMenuItem });
            cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            cheatsToolStripMenuItem.Size = new Size(55, 20);
            cheatsToolStripMenuItem.Text = "Cheats";
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defineScore500ToolStripMenuItem, defineScore1000ToolStripMenuItem, defineScore10000000ToolStripMenuItem });
            scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            scoreToolStripMenuItem.Size = new Size(103, 22);
            scoreToolStripMenuItem.Text = "Score";
            // 
            // defineScore500ToolStripMenuItem
            // 
            defineScore500ToolStripMenuItem.Name = "defineScore500ToolStripMenuItem";
            defineScore500ToolStripMenuItem.Size = new Size(202, 22);
            defineScore500ToolStripMenuItem.Text = "Define Score = 500";
            defineScore500ToolStripMenuItem.Click += defineScore500ToolStripMenuItem_Click;
            // 
            // defineScore1000ToolStripMenuItem
            // 
            defineScore1000ToolStripMenuItem.Name = "defineScore1000ToolStripMenuItem";
            defineScore1000ToolStripMenuItem.Size = new Size(202, 22);
            defineScore1000ToolStripMenuItem.Text = "Define Score = 1000";
            defineScore1000ToolStripMenuItem.Click += defineScore1000ToolStripMenuItem_Click;
            // 
            // defineScore10000000ToolStripMenuItem
            // 
            defineScore10000000ToolStripMenuItem.Name = "defineScore10000000ToolStripMenuItem";
            defineScore10000000ToolStripMenuItem.Size = new Size(202, 22);
            defineScore10000000ToolStripMenuItem.Text = "Define Score = 10000000";
            defineScore10000000ToolStripMenuItem.Click += defineScore10000000ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(156, 1);
            label1.Name = "label1";
            label1.Size = new Size(208, 45);
            label1.TabIndex = 6;
            label1.Text = "ClickerSharp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(305, 46);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "V2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 81, 149);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(509, 398);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ClickerSharp - v2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cheatsToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem defineScore500ToolStripMenuItem;
        private ToolStripMenuItem defineScore1000ToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem yesToolStripMenuItem;
        private ToolStripMenuItem noToolStripMenuItem;
        private ToolStripMenuItem defineScore10000000ToolStripMenuItem;
        private ToolStripMenuItem shopToolStripMenuItem;
        private ToolStripMenuItem boostX7ToolStripMenuItem;
        private ToolStripMenuItem price5000ToolStripMenuItem;
        private ToolStripMenuItem autoClickerToolStripMenuItem;
        private ToolStripMenuItem price1500ToolStripMenuItem;
        private ToolStripMenuItem click2ToolStripMenuItem;
        private ToolStripMenuItem price500ToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}
