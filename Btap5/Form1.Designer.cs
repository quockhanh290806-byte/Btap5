namespace Btap5
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
            menuStrip1 = new MenuStrip();
            hệToolStripMenuItem = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            luuNộiToolStripMenuItem = new ToolStripSeparator();
            mnuSave = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuFont = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnOpen = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            cmbFont = new ToolStripComboBox();
            cmbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblSoTu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệToolStripMenuItem, mnuFont });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệToolStripMenuItem
            // 
            hệToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, luuNộiToolStripMenuItem, mnuSave, mnuExit });
            hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            hệToolStripMenuItem.Size = new Size(69, 20);
            hệToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuNew
            // 
            mnuNew.Image = (Image)resources.GetObject("mnuNew.Image");
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new Size(190, 22);
            mnuNew.Text = "Tạo van bản ";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Image = (Image)resources.GetObject("mnuOpen.Image");
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(190, 22);
            mnuOpen.Text = "Mỏ tập tin";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // luuNộiToolStripMenuItem
            // 
            luuNộiToolStripMenuItem.Name = "luuNộiToolStripMenuItem";
            luuNộiToolStripMenuItem.Size = new Size(187, 6);
            // 
            // mnuSave
            // 
            mnuSave.Image = (Image)resources.GetObject("mnuSave.Image");
            mnuSave.Name = "mnuSave";
            mnuSave.Size = new Size(190, 22);
            mnuSave.Text = "Lưu nội dung văn bản";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(190, 22);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuFont
            // 
            mnuFont.Name = "mnuFont";
            mnuFont.Size = new Size(73, 20);
            mnuFont.Text = "định dạng";
            mnuFont.Click += mnuFont_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnOpen, toolStripButton2, cmbFont, cmbSize, btnBold, btnItalic, btnUnderline });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(23, 22);
            btnOpen.Text = "toolStripButton1";
            btnOpen.Click += btnOpen_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // cmbFont
            // 
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 25);
            // 
            // cmbSize
            // 
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 25);
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(23, 22);
            btnBold.Text = "toolStripButton3";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(23, 22);
            btnItalic.Text = "toolStripButton4";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(23, 22);
            btnUnderline.Text = "toolStripButton5";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 401);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoTu });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoTu
            // 
            lblSoTu.Name = "lblSoTu";
            lblSoTu.Size = new Size(46, 17);
            lblSoTu.Text = "Số từ: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệToolStripMenuItem;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuFont;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem mnuSave;
        private ToolStripSeparator luuNộiToolStripMenuItem;
        private ToolStripMenuItem mnuExit;
        private ToolStripButton btnOpen;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox cmbFont;
        private ToolStripComboBox cmbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoTu;
    }
}
