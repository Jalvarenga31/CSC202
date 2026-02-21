namespace Catapult_Simulator
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
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            logsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 27);
            label1.Name = "label1";
            label1.Size = new Size(446, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Catapult Simulator!! \r\nPress the button to catapult a object of your choosing!\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(269, 393);
            button1.Name = "button1";
            button1.Size = new Size(117, 34);
            button1.TabIndex = 1;
            button1.Text = "Watermelon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Watermelon_Click;
            // 
            // button2
            // 
            button2.Location = new Point(105, 393);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Bolder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Bolder_Click;
            // 
            // button3
            // 
            button3.Location = new Point(439, 393);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Pie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Pie_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.catapult;
            pictureBox1.Location = new Point(142, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 340);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 5;
            label2.Text = "Choose your ammo!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 458);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "Results:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 502);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(269, 651);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 8;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Clear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(656, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            logsToolStripMenuItem.Size = new Size(66, 29);
            logsToolStripMenuItem.Text = "Logs";
            logsToolStripMenuItem.Click += LogMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 734);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Catapult Simulator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logsToolStripMenuItem;
    }
}
