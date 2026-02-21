namespace Catapult_Simulator
{
    partial class Launch_Outcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(28, 30);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1096, 572);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // Launch_Outcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 625);
            Controls.Add(richTextBox);
            Name = "Launch_Outcome";
            Text = "Launch Outcome";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
    }
}