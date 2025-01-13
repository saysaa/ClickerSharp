namespace WinFormsApp1
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 50);
            label1.TabIndex = 0;
            label1.Text = ">_ClickerSharp";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(164, 143);
            button1.Name = "button1";
            button1.Size = new Size(165, 82);
            button1.TabIndex = 1;
            button1.Text = "Click here";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 59);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Alpha - v0.1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 333);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 3;
            label3.Text = "Score :";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(403, 344);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Console";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(484, 372);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "ClickerSharp - Alpha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;

        // Ajout des méthodes manquantes pour les événements Click
        private void label1_Click(object sender, EventArgs e)
        {
            // Gérer l'événement de clic pour label1 ici
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Gérer l'événement de clic pour button1 ici
        }

        private CheckBox checkBox1;
    }
}
