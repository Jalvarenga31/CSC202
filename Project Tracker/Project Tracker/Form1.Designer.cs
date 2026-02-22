namespace Project_Tracker
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
            btnAdd = new Button();
            btnRemove = new Button();
            txtProjectName = new TextBox();
            txtData = new TextBox();
            lstProjects = new ListBox();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Project";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(12, 52);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 34);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Project";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(164, 15);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(407, 31);
            txtProjectName.TabIndex = 2;
            // 
            // txtData
            // 
            txtData.Location = new Point(164, 55);
            txtData.Name = "txtData";
            txtData.Size = new Size(407, 31);
            txtData.TabIndex = 3;
            // 
            // lstProjects
            // 
            lstProjects.FormattingEnabled = true;
            lstProjects.Location = new Point(12, 92);
            lstProjects.Name = "lstProjects";
            lstProjects.Size = new Size(559, 354);
            lstProjects.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(297, 468);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 34);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 528);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lstProjects);
            Controls.Add(txtData);
            Controls.Add(txtProjectName);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Project Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private TextBox txtProjectName;
        private TextBox txtData;
        private ListBox lstProjects;
        private Button btnSave;
        private Button btnLoad;
    }
}
