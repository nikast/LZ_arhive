namespace LZ_arhive
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UnArchiveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Archive = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.OpenFIle = new System.Windows.Forms.Button();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathLabelUnzip = new System.Windows.Forms.Label();
            this.OpenUnzipButton = new System.Windows.Forms.Button();
            this.NameBoxUnzip = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Archive.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchiveMenu,
            this.UnArchiveMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // ArchiveMenu
            // 
            this.ArchiveMenu.Name = "ArchiveMenu";
            this.ArchiveMenu.Size = new System.Drawing.Size(146, 22);
            this.ArchiveMenu.Text = "Archive file";
            // 
            // UnArchiveMenu
            // 
            this.UnArchiveMenu.Name = "UnArchiveMenu";
            this.UnArchiveMenu.Size = new System.Drawing.Size(146, 22);
            this.UnArchiveMenu.Text = "Unarchive file";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(146, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.Archive);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(460, 206);
            this.MainPanel.TabIndex = 2;
            // 
            // Archive
            // 
            this.Archive.Controls.Add(this.tabPage1);
            this.Archive.Controls.Add(this.tabPage2);
            this.Archive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Archive.Location = new System.Drawing.Point(0, 0);
            this.Archive.Name = "Archive";
            this.Archive.SelectedIndex = 0;
            this.Archive.Size = new System.Drawing.Size(458, 204);
            this.Archive.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.BottomPanel);
            this.tabPage1.Controls.Add(this.PathLabel);
            this.tabPage1.Controls.Add(this.OpenFIle);
            this.tabPage1.Controls.Add(this.NameBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Archive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.StartButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 103);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(442, 70);
            this.BottomPanel.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(24, 24);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(26, 17);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(35, 13);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Path: ";
            // 
            // OpenFIle
            // 
            this.OpenFIle.Location = new System.Drawing.Point(29, 71);
            this.OpenFIle.Name = "OpenFIle";
            this.OpenFIle.Size = new System.Drawing.Size(74, 23);
            this.OpenFIle.TabIndex = 2;
            this.OpenFIle.Text = "Open file";
            this.OpenFIle.UseVisualStyleBackColor = true;
            this.OpenFIle.Click += new System.EventHandler(this.OpenFileButton);
            // 
            // NameBox1
            // 
            this.NameBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBox1.Location = new System.Drawing.Point(29, 45);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(238, 20);
            this.NameBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PathLabelUnzip);
            this.tabPage2.Controls.Add(this.OpenUnzipButton);
            this.tabPage2.Controls.Add(this.NameBoxUnzip);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unarchive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathLabelUnzip
            // 
            this.PathLabelUnzip.AutoSize = true;
            this.PathLabelUnzip.Location = new System.Drawing.Point(25, 12);
            this.PathLabelUnzip.Name = "PathLabelUnzip";
            this.PathLabelUnzip.Size = new System.Drawing.Size(35, 13);
            this.PathLabelUnzip.TabIndex = 6;
            this.PathLabelUnzip.Text = "Path: ";
            // 
            // OpenUnzipButton
            // 
            this.OpenUnzipButton.Location = new System.Drawing.Point(28, 63);
            this.OpenUnzipButton.Name = "OpenUnzipButton";
            this.OpenUnzipButton.Size = new System.Drawing.Size(74, 23);
            this.OpenUnzipButton.TabIndex = 5;
            this.OpenUnzipButton.Text = "Open file";
            this.OpenUnzipButton.UseVisualStyleBackColor = true;
            this.OpenUnzipButton.Click += new System.EventHandler(this.OpenUnzipButton_Click);
            // 
            // NameBoxUnzip
            // 
            this.NameBoxUnzip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBoxUnzip.Location = new System.Drawing.Point(28, 37);
            this.NameBoxUnzip.Name = "NameBoxUnzip";
            this.NameBoxUnzip.Size = new System.Drawing.Size(238, 20);
            this.NameBoxUnzip.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 252);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Archive LZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.Archive.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ArchiveMenu;
        private System.Windows.Forms.ToolStripMenuItem UnArchiveMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl Archive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenFIle;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label PathLabelUnzip;
        private System.Windows.Forms.Button OpenUnzipButton;
        private System.Windows.Forms.TextBox NameBoxUnzip;
    }
}

