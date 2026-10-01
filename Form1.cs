using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace baitaptrenlop
{
    public partial class Form1 : Form
    {
        private string currentFile = null;
        private bool updatingUI = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
                cmbFonts.Items.Add(font.Name);

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                cmbSize.Items.Add(s.ToString());

            ApplyDefault();
            UpdateWordCount();
        }

        private void ApplyDefault()
        {
            updatingUI = true;
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;
            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";
            btnBold.Checked = false;
            btnItalic.Checked = false;
            btnUnderline.Checked = false;
            updatingUI = false;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            richText.Clear();
            currentFile = null;
            ApplyDefault();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text/RTF files (*.txt;*.rtf)|*.txt;*.rtf";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    string ext = Path.GetExtension(ofd.FileName).ToLower();
                    if (ext == ".rtf")
                        richText.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    else
                        richText.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);

                    currentFile = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tập tin: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    sfd.DefaultExt = "rtf";
                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    richText.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    currentFile = sfd.FileName;
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                RichTextBoxStreamType type =
                    Path.GetExtension(currentFile).ToLower() == ".rtf"
                    ? RichTextBoxStreamType.RichText
                    : RichTextBoxStreamType.PlainText;

                richText.SaveFile(currentFile, type);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void ApplyStyle(FontStyle style, bool on)
        {
            Font cur = richText.SelectionFont ?? richText.Font;
            FontStyle newStyle = on ? (cur.Style | style) : (cur.Style & ~style);
            richText.SelectionFont = new Font(cur, newStyle);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Bold, btnBold.Checked);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Italic, btnItalic.Checked);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Underline, btnUnderline.Checked);
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingUI) return;
            Font cur = richText.SelectionFont ?? richText.Font;
            richText.SelectionFont = new Font(cmbFonts.Text, cur.Size, cur.Style);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingUI) return;
            Font cur = richText.SelectionFont ?? richText.Font;
            if (float.TryParse(cmbSize.Text, out float size))
                richText.SelectionFont = new Font(cur.FontFamily, size, cur.Style);
        }

        private void richText_SelectionChanged(object sender, EventArgs e)
        {
            Font f = richText.SelectionFont;
            if (f == null) return;

            updatingUI = true;
            btnBold.Checked = f.Bold;
            btnItalic.Checked = f.Italic;
            btnUnderline.Checked = f.Underline;
            cmbFonts.Text = f.Name;
            cmbSize.Text = ((int)f.Size).ToString();
            updatingUI = false;
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            UpdateWordCount();
        }

        private void UpdateWordCount()
        {
            string[] words = richText.Text.Split(
                new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            lblWordCount.Text = "Tổng số từ: " + words.Length;
        }
    }
}
