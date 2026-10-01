using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitaptrenlop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.mnuHeThong = new ToolStripMenuItem();
            this.mnuNew = new ToolStripMenuItem();
            this.mnuOpen = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.mnuSave = new ToolStripMenuItem();
            this.mnuExit = new ToolStripMenuItem();
            this.mnuDinhDang = new ToolStripMenuItem();
            this.toolStrip1 = new ToolStrip();
            this.btnNew = new ToolStripButton();
            this.btnSave = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.cmbFonts = new ToolStripComboBox();
            this.cmbSize = new ToolStripComboBox();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.btnBold = new ToolStripButton();
            this.btnItalic = new ToolStripButton();
            this.btnUnderline = new ToolStripButton();
            this.statusStrip1 = new StatusStrip();
            this.lblWordCount = new ToolStripStatusLabel();
            this.richText = new RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.mnuHeThong, this.mnuDinhDang });
            this.menuStrip1.Name = "menuStrip1";

            this.mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] {
                this.mnuNew, this.mnuOpen, this.toolStripSeparator1, this.mnuSave, this.mnuExit });
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Text = "Hệ thống";

            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Text = "Tạo văn bản mới";
            this.mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            this.mnuNew.Click += new EventHandler(this.mnuNew_Click);

            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Text = "Mở tập tin";
            this.mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            this.mnuOpen.Click += new EventHandler(this.mnuOpen_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";

            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Text = "Lưu nội dung văn bản";
            this.mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            this.mnuSave.Click += new EventHandler(this.mnuSave_Click);

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new EventHandler(this.mnuExit_Click);

            this.mnuDinhDang.Name = "mnuDinhDang";
            this.mnuDinhDang.Text = "Định dạng";
            this.mnuDinhDang.Click += new EventHandler(this.mnuDinhDang_Click);

            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
                this.btnNew, this.btnSave, this.toolStripSeparator2,
                this.cmbFonts, this.cmbSize, this.toolStripSeparator3,
                this.btnBold, this.btnItalic, this.btnUnderline });
            this.toolStrip1.Name = "toolStrip1";

            this.btnNew.Name = "btnNew";
            this.btnNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnNew.Text = "📄";
            this.btnNew.ToolTipText = "Tạo văn bản mới (Ctrl+N)";
            this.btnNew.Click += new EventHandler(this.mnuNew_Click);

            this.btnSave.Name = "btnSave";
            this.btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnSave.Text = "💾";
            this.btnSave.ToolTipText = "Lưu nội dung văn bản (Ctrl+S)";
            this.btnSave.Click += new EventHandler(this.mnuSave_Click);

            this.toolStripSeparator2.Name = "toolStripSeparator2";

            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new Size(180, 25);
            this.cmbFonts.SelectedIndexChanged += new EventHandler(this.cmbFonts_SelectedIndexChanged);

            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new Size(70, 25);
            this.cmbSize.SelectedIndexChanged += new EventHandler(this.cmbSize_SelectedIndexChanged);

            this.toolStripSeparator3.Name = "toolStripSeparator3";

            this.btnBold.Name = "btnBold";
            this.btnBold.CheckOnClick = true;
            this.btnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnBold.Text = "B";
            this.btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBold.Click += new EventHandler(this.btnBold_Click);

            this.btnItalic.Name = "btnItalic";
            this.btnItalic.CheckOnClick = true;
            this.btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnItalic.Text = "I";
            this.btnItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.btnItalic.Click += new EventHandler(this.btnItalic_Click);

            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.CheckOnClick = true;
            this.btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.btnUnderline.Text = "U";
            this.btnUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            this.btnUnderline.Click += new EventHandler(this.btnUnderline_Click);

            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.lblWordCount });
            this.statusStrip1.Name = "statusStrip1";

            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Text = "Tổng số từ: 0";

            this.richText.Dock = DockStyle.Fill;
            this.richText.Name = "richText";
            this.richText.Text = "";
            this.richText.TextChanged += new EventHandler(this.richText_TextChanged);
            this.richText.SelectionChanged += new EventHandler(this.richText_SelectionChanged);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.Load += new EventHandler(this.Form1_Load);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuDinhDang;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox cmbFonts;
        private ToolStripComboBox cmbSize;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblWordCount;
        private RichTextBox richText;
    }
}
