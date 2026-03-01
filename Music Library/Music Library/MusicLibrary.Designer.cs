namespace Music_Library
{
    partial class MusicLibrary
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
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtAlbum = new TextBox();
            cmbGenre = new ComboBox();
            btnAdd = new Button();
            dgvLibrary = new DataGridView();
            btnShuffle = new Button();
            comboSort = new ComboBox();
            btnSort = new Button();
            btnPopOut = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 0;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(12, 49);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(150, 31);
            txtArtist.TabIndex = 1;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(12, 86);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(150, 31);
            txtAlbum.TabIndex = 2;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(12, 123);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(150, 33);
            cmbGenre.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Song";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvLibrary
            // 
            dgvLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrary.Location = new Point(184, 12);
            dgvLibrary.MultiSelect = false;
            dgvLibrary.Name = "dgvLibrary";
            dgvLibrary.RowHeadersWidth = 62;
            dgvLibrary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibrary.Size = new Size(646, 349);
            dgvLibrary.TabIndex = 5;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(184, 369);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(112, 34);
            btnShuffle.TabIndex = 6;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // comboSort
            // 
            comboSort.FormattingEnabled = true;
            comboSort.Location = new Point(656, 369);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(174, 33);
            comboSort.TabIndex = 7;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(538, 367);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 8;
            btnSort.Text = "Sort By";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnPopOut
            // 
            btnPopOut.Location = new Point(302, 367);
            btnPopOut.Name = "btnPopOut";
            btnPopOut.Size = new Size(112, 34);
            btnPopOut.TabIndex = 9;
            btnPopOut.Text = "Pop Out";
            btnPopOut.UseVisualStyleBackColor = true;
            btnPopOut.Click += btnPopOut_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 369);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(420, 367);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 414);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnPopOut);
            Controls.Add(btnSort);
            Controls.Add(comboSort);
            Controls.Add(btnShuffle);
            Controls.Add(dgvLibrary);
            Controls.Add(btnAdd);
            Controls.Add(cmbGenre);
            Controls.Add(txtAlbum);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Music Library";
            ((System.ComponentModel.ISupportInitialize)dgvLibrary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtAlbum;
        private ComboBox cmbGenre;
        private Button btnAdd;
        private DataGridView dgvLibrary;
        private Button btnShuffle;
        private ComboBox comboSort;
        private Button btnSort;
        private Button btnPopOut;
        private Button button1;
        private Button btnSave;
        private Button btnLoad;
        private Button btnDelete;
    }
}
