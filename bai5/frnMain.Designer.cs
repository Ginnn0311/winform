namespace bai5
{
    partial class frnMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnMain));
            txtFile = new RichTextBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinMớiToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblSoTu = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            cboFont = new ToolStripComboBox();
            cboSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtFile
            // 
            txtFile.Dock = DockStyle.Fill;
            txtFile.Location = new Point(0, 49);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(800, 401);
            txtFile.TabIndex = 0;
            txtFile.Text = "";
            txtFile.TextChanged += txtFile_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoToolStripMenuItem, mởTậpTinMớiToolStripMenuItem, toolStripSeparator1, lưuVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // tạoToolStripMenuItem
            // 
            tạoToolStripMenuItem.Image = (Image)resources.GetObject("tạoToolStripMenuItem.Image");
            tạoToolStripMenuItem.Name = "tạoToolStripMenuItem";
            tạoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoToolStripMenuItem.Size = new Size(206, 22);
            tạoToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoToolStripMenuItem.Click += tạoToolStripMenuItem_Click;
            // 
            // mởTậpTinMớiToolStripMenuItem
            // 
            mởTậpTinMớiToolStripMenuItem.Name = "mởTậpTinMớiToolStripMenuItem";
            mởTậpTinMớiToolStripMenuItem.Size = new Size(206, 22);
            mởTậpTinMớiToolStripMenuItem.Text = "Mở tập tin mới";
            mởTậpTinMớiToolStripMenuItem.Click += mởTậpTinMớiToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(203, 6);
            // 
            // lưuVănBảnToolStripMenuItem
            // 
            lưuVănBảnToolStripMenuItem.Image = (Image)resources.GetObject("lưuVănBảnToolStripMenuItem.Image");
            lưuVănBảnToolStripMenuItem.Name = "lưuVănBảnToolStripMenuItem";
            lưuVănBảnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuVănBảnToolStripMenuItem.Size = new Size(206, 22);
            lưuVănBảnToolStripMenuItem.Text = "Lưu văn bản";
            lưuVănBảnToolStripMenuItem.Click += lưuVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(206, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem });
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(74, 20);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(98, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblSoTu });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // lblSoTu
            // 
            lblSoTu.Name = "lblSoTu";
            lblSoTu.Size = new Size(46, 17);
            lblSoTu.Text = "Số từ: 0";
            lblSoTu.Click += toolStripStatusLabel2_Click;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1, cboFont, cboSize, btnBold, btnItalic, btnUnderline });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 3;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += tạoToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += lưuVănBảnToolStripMenuItem_Click;
            // 
            // cboFont
            // 
            cboFont.Items.AddRange(new object[] { "Arial", "Times New Roman", "Tahoma" });
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(121, 25);
            cboFont.Text = "Arial";
            // 
            // cboSize
            // 
            cboSize.Items.AddRange(new object[] { "10", "12", "14", "16", "18" });
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(121, 25);
            cboSize.Text = "12";
            // 
            // btnBold
            // 
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(23, 22);
            btnBold.Text = "B";
            // 
            // btnItalic
            // 
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(23, 22);
            btnItalic.Text = "I";
            // 
            // btnUnderline
            // 
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(23, 22);
            btnUnderline.Text = "U";
            // 
            // frnMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(txtFile);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frnMain";
            Text = "Soạn Thảo Văn Bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private RichTextBox txtFile;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tạoToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinMớiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem lưuVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblSoTu;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox cboFont;
        private ToolStripComboBox cboSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
    }
}
