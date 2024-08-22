namespace Cafe_Aziz
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
            btnClean = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpFile = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            lstMenu = new ListBox();
            lstCh = new ListBox();
            btnRemove = new Button();
            txSum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(299, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(299, 310);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 1;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpFile });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpFile
            // 
            OpFile.Name = "OpFile";
            OpFile.Size = new Size(134, 22);
            OpFile.Text = "Load menu";
            OpFile.Click += OpFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 15;
            lstMenu.Location = new Point(118, 47);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(175, 304);
            lstMenu.TabIndex = 3;
            lstMenu.SelectedIndexChanged += lstMenu_SelectedIndexChanged;
            // 
            // lstCh
            // 
            lstCh.FormattingEnabled = true;
            lstCh.ItemHeight = 15;
            lstCh.Location = new Point(380, 47);
            lstCh.Name = "lstCh";
            lstCh.Size = new Size(175, 304);
            lstCh.TabIndex = 4;
            lstCh.SelectedIndexChanged += lstCh_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(299, 150);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txSum
            // 
            txSum.Location = new Point(416, 372);
            txSum.Name = "txSum";
            txSum.Size = new Size(100, 23);
            txSum.TabIndex = 6;
            txSum.TextChanged += txSum_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 354);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(187, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Menu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(448, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "Check";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txSum);
            Controls.Add(btnRemove);
            Controls.Add(lstCh);
            Controls.Add(lstMenu);
            Controls.Add(btnClean);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnClean;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpFile;
        private OpenFileDialog openFileDialog1;
        private ListBox lstMenu;
        private ListBox lstCh;
        private Button btnRemove;
        private TextBox txSum;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
