namespace osmonIdeTiny
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainEditorBox = new FastColoredTextBoxNS.FastColoredTextBox();
            menuStrip1 = new MenuStrip();
            faylToolStripMenuItem = new ToolStripMenuItem();
            ochishToolStripMenuItem = new ToolStripMenuItem();
            saqlashToolStripMenuItem = new ToolStripMenuItem();
            yangiToolStripMenuItem = new ToolStripMenuItem();
            malumotToolStripMenuItem = new ToolStripMenuItem();
            sozlamarToolStripMenuItem = new ToolStripMenuItem();
            fayllarStrukturasiToolStripMenuItem = new ToolStripMenuItem();
            shriftToolStripMenuItem = new ToolStripMenuItem();
            osmonexeToolStripMenuItem = new ToolStripMenuItem();
            korinishToolStripMenuItem = new ToolStripMenuItem();
            atomOneDarkToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            terminalBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)mainEditorBox).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainEditorBox
            // 
            mainEditorBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainEditorBox.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            mainEditorBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            mainEditorBox.AutoScrollMinSize = new Size(31, 22);
            mainEditorBox.BackBrush = null;
            mainEditorBox.CharHeight = 22;
            mainEditorBox.CharWidth = 10;
            mainEditorBox.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            mainEditorBox.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mainEditorBox.IsReplaceMode = false;
            mainEditorBox.Location = new Point(0, 52);
            mainEditorBox.Name = "mainEditorBox";
            mainEditorBox.Paddings = new Padding(0);
            mainEditorBox.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            mainEditorBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("mainEditorBox.ServiceColors");
            mainEditorBox.Size = new Size(884, 399);
            mainEditorBox.TabIndex = 0;
            mainEditorBox.Zoom = 100;
            mainEditorBox.Load += mainEditorBox_Load;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { faylToolStripMenuItem, malumotToolStripMenuItem, sozlamarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // faylToolStripMenuItem
            // 
            faylToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ochishToolStripMenuItem, saqlashToolStripMenuItem, yangiToolStripMenuItem });
            faylToolStripMenuItem.Name = "faylToolStripMenuItem";
            faylToolStripMenuItem.Size = new Size(40, 20);
            faylToolStripMenuItem.Text = "Fayl";
            // 
            // ochishToolStripMenuItem
            // 
            ochishToolStripMenuItem.Image = (Image)resources.GetObject("ochishToolStripMenuItem.Image");
            ochishToolStripMenuItem.Name = "ochishToolStripMenuItem";
            ochishToolStripMenuItem.Size = new Size(120, 22);
            ochishToolStripMenuItem.Text = "Ochish...";
            ochishToolStripMenuItem.Click += ochishToolStripMenuItem_Click;
            // 
            // saqlashToolStripMenuItem
            // 
            saqlashToolStripMenuItem.Image = (Image)resources.GetObject("saqlashToolStripMenuItem.Image");
            saqlashToolStripMenuItem.Name = "saqlashToolStripMenuItem";
            saqlashToolStripMenuItem.Size = new Size(120, 22);
            saqlashToolStripMenuItem.Text = "Saqlash";
            // 
            // yangiToolStripMenuItem
            // 
            yangiToolStripMenuItem.Image = (Image)resources.GetObject("yangiToolStripMenuItem.Image");
            yangiToolStripMenuItem.Name = "yangiToolStripMenuItem";
            yangiToolStripMenuItem.Size = new Size(120, 22);
            yangiToolStripMenuItem.Text = "Yangi";
            yangiToolStripMenuItem.Click += yangiToolStripMenuItem_Click;
            // 
            // malumotToolStripMenuItem
            // 
            malumotToolStripMenuItem.Name = "malumotToolStripMenuItem";
            malumotToolStripMenuItem.Size = new Size(71, 20);
            malumotToolStripMenuItem.Text = "Ma'lumot";
            // 
            // sozlamarToolStripMenuItem
            // 
            sozlamarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fayllarStrukturasiToolStripMenuItem, shriftToolStripMenuItem, osmonexeToolStripMenuItem, korinishToolStripMenuItem });
            sozlamarToolStripMenuItem.Name = "sozlamarToolStripMenuItem";
            sozlamarToolStripMenuItem.Size = new Size(67, 20);
            sozlamarToolStripMenuItem.Text = "Sozlamar";
            // 
            // fayllarStrukturasiToolStripMenuItem
            // 
            fayllarStrukturasiToolStripMenuItem.Name = "fayllarStrukturasiToolStripMenuItem";
            fayllarStrukturasiToolStripMenuItem.Size = new Size(166, 22);
            fayllarStrukturasiToolStripMenuItem.Text = "Fayllar strukturasi";
            // 
            // shriftToolStripMenuItem
            // 
            shriftToolStripMenuItem.Image = (Image)resources.GetObject("shriftToolStripMenuItem.Image");
            shriftToolStripMenuItem.Name = "shriftToolStripMenuItem";
            shriftToolStripMenuItem.Size = new Size(166, 22);
            shriftToolStripMenuItem.Text = "Shrift";
            shriftToolStripMenuItem.Click += shriftToolStripMenuItem_Click;
            // 
            // osmonexeToolStripMenuItem
            // 
            osmonexeToolStripMenuItem.Name = "osmonexeToolStripMenuItem";
            osmonexeToolStripMenuItem.Size = new Size(166, 22);
            osmonexeToolStripMenuItem.Text = "Osmon.exe";
            // 
            // korinishToolStripMenuItem
            // 
            korinishToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atomOneDarkToolStripMenuItem });
            korinishToolStripMenuItem.Name = "korinishToolStripMenuItem";
            korinishToolStripMenuItem.Size = new Size(166, 22);
            korinishToolStripMenuItem.Text = "Ko'rinish";
            korinishToolStripMenuItem.Click += korinishToolStripMenuItem_Click;
            // 
            // atomOneDarkToolStripMenuItem
            // 
            atomOneDarkToolStripMenuItem.Name = "atomOneDarkToolStripMenuItem";
            atomOneDarkToolStripMenuItem.Size = new Size(156, 22);
            atomOneDarkToolStripMenuItem.Text = "Atom One Dark";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton6, toolStripSeparator1, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "openFileButtonStrip";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Saqlash";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "Faylga saqlash";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripRunButton";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // terminalBox
            // 
            terminalBox.BackColor = Color.Black;
            terminalBox.BorderStyle = BorderStyle.FixedSingle;
            terminalBox.Dock = DockStyle.Bottom;
            terminalBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            terminalBox.ForeColor = Color.White;
            terminalBox.Location = new Point(0, 457);
            terminalBox.Name = "terminalBox";
            terminalBox.Size = new Size(884, 175);
            terminalBox.TabIndex = 3;
            terminalBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 632);
            Controls.Add(terminalBox);
            Controls.Add(toolStrip1);
            Controls.Add(mainEditorBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Osmon Dev";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)mainEditorBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox mainEditorBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem faylToolStripMenuItem;
        private ToolStripMenuItem ochishToolStripMenuItem;
        private ToolStripMenuItem saqlashToolStripMenuItem;
        private ToolStripMenuItem malumotToolStripMenuItem;
        private ToolStripMenuItem sozlamarToolStripMenuItem;
        private ToolStripMenuItem fayllarStrukturasiToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem yangiToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripMenuItem shriftToolStripMenuItem;
        private ToolStripMenuItem osmonexeToolStripMenuItem;
        private ToolStripButton toolStripButton6;
        private ToolStripMenuItem korinishToolStripMenuItem;
        private ToolStripMenuItem atomOneDarkToolStripMenuItem;
        private RichTextBox terminalBox;
    }
}