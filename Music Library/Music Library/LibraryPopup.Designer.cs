namespace Music_Library
{
    partial class LibraryPopup
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
            dgvPopup = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPopup).BeginInit();
            SuspendLayout();
            // 
            // dgvPopup
            // 
            dgvPopup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPopup.Location = new Point(12, 12);
            dgvPopup.Name = "dgvPopup";
            dgvPopup.RowHeadersWidth = 62;
            dgvPopup.Size = new Size(776, 426);
            dgvPopup.TabIndex = 0;
            // 
            // LibraryPopup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPopup);
            Name = "LibraryPopup";
            Text = "LibraryPopup";
            Load += LibraryPopup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPopup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPopup;
    }
}