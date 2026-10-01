using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bai5
{
    public partial class frnMain : Form
    {
        public frnMain()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            int soChu = 0;

            foreach (char c in txtFile.Text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    soChu++;
                }
            }

            lblSoTu.Text = "Số chữ: " + soChu;
        }

        private void tạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtFile.Focus();
        }

        private void mởTậpTinMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = File.ReadAllText(openFileDialog1.FileName);
                txtFile.Focus();
            }
        }

        private void lưuVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(
                    saveFileDialog1.FileName,
                    txtFile.Text
                );
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.SelectionFont = fontDialog1.Font;
                cboFont.Text = fontDialog1.Font.FontFamily.Name;
                cboSize.Text = fontDialog1.Font.Size.ToString();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFont.SelectedItem == null)
                return;

            if (txtFile.SelectionFont == null)
                return;

            Font f = txtFile.SelectionFont;

            txtFile.SelectionFont = new Font(
                cboFont.SelectedItem.ToString(),
                f.Size,
                f.Style
            );
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFile.SelectionFont == null)
                return;

            float size;

            if (float.TryParse(cboSize.Text, out size))
            {
                Font f = txtFile.SelectionFont;

                txtFile.SelectionFont = new Font(
                    f.FontFamily,
                    size,
                    f.Style
                );
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (txtFile.SelectionFont == null)
                return;

            Font f = txtFile.SelectionFont;
            FontStyle style;

            if (f.Bold)
                style = f.Style & ~FontStyle.Bold;
            else
                style = f.Style | FontStyle.Bold;

            txtFile.SelectionFont = new Font(
                f.FontFamily,
                f.Size,
                style
            );
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (txtFile.SelectionFont == null)
                return;

            Font f = txtFile.SelectionFont;
            FontStyle style;

            if (f.Italic)
                style = f.Style & ~FontStyle.Italic;
            else
                style = f.Style | FontStyle.Italic;

            txtFile.SelectionFont = new Font(
                f.FontFamily,
                f.Size,
                style
            );
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (txtFile.SelectionFont == null)
                return;

            Font f = txtFile.SelectionFont;
            FontStyle style;

            if (f.Underline)
                style = f.Style & ~FontStyle.Underline;
            else
                style = f.Style | FontStyle.Underline;

            txtFile.SelectionFont = new Font(
                f.FontFamily,
                f.Size,
                style
            );
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtFile.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(
                    saveFileDialog1.FileName,
                    txtFile.Text
                );
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
        }
    }
}