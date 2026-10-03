using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Btap5
{
    public partial class Form1 : Form
    {    

        // Lưu đường dẫn file hiện tại
        private string currentFile = "";

        public Form1()
        {
            InitializeComponent();

            // Cấu hình ban đầu
            LoadFonts();
            LoadSizes();

            cmbFont.Text = "Tahoma";
            cmbSize.Text = "14";

            richTextBox1.Font = new Font("Tahoma", 14);
            richTextBox1.Text = "";

            // Sự kiện
            richTextBox1.TextChanged += richTextBox1_TextChanged;

            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;

            //btnNew.Click += btnNew_Click;
            btnOpen.Click += btnOpen_Click;
            btnBold.Click += btnBold_Click;
            btnItalic.Click += btnItalic_Click;
            btnUnderline.Click += btnUnderline_Click;

            mnuNew.Click += mnuNew_Click;
            mnuOpen.Click += mnuOpen_Click;
            mnuSave.Click += mnuSave_Click;
            mnuExit.Click += mnuExit_Click;
            mnuFont.Click += mnuFont_Click;

            // Phím tắt
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;

            // Hiển thị số từ ban đầu
            UpdateWordCount();
        }

        // =====================================================
        // 1. LOAD DANH SÁCH FONT
        // =====================================================

        private void LoadFonts()
        {
            cmbFont.Items.Clear();

            InstalledFontCollection fonts =
                new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                cmbFont.Items.Add(font.Name);
            }
        }

        // =====================================================
        // 2. LOAD DANH SÁCH SIZE
        // =====================================================

        private void LoadSizes()
        {
            cmbSize.Items.Clear();

            int[] sizes =
            {
                8, 9, 10, 11, 12, 14, 16,
                18, 20, 22, 24, 26, 28,
                36, 48, 72
            };

            foreach (int size in sizes)
            {
                cmbSize.Items.Add(size);
            }
        }

        // =====================================================
        // 3. TẠO VĂN BẢN MỚI
        // =====================================================

        private void NewDocument()
        {
            richTextBox1.Clear();

            currentFile = "";

            cmbFont.Text = "Tahoma";
            cmbSize.Text = "14";

            richTextBox1.Font = new Font("Tahoma", 14);

            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont =
                new Font("Tahoma", 14, FontStyle.Regular);

            UpdateWordCount();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        // =====================================================
        // 4. MỞ FILE
        // =====================================================

        private void OpenDocument()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Mở tập tin";
            openFile.Filter =
                "Rich Text Format (*.rtf)|*.rtf|" +
                "Text File (*.txt)|*.txt|" +
                "All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFile.FileName;

                string extension =
                    Path.GetExtension(currentFile).ToLower();

                if (extension == ".rtf")
                {
                    richTextBox1.LoadFile(
                        currentFile,
                        RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(
                        currentFile,
                        RichTextBoxStreamType.PlainText);
                }

                // Lấy Font hiện tại của văn bản
                if (richTextBox1.Font != null)
                {
                    cmbFont.Text =
                        richTextBox1.Font.FontFamily.Name;

                    cmbSize.Text =
                        richTextBox1.Font.Size.ToString();
                }

                UpdateWordCount();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        // =====================================================
        // 5. LƯU FILE
        // =====================================================

        private void SaveDocument()
        {
            // Nếu chưa từng lưu
            if (string.IsNullOrEmpty(currentFile))
            {
                SaveFileDialog saveFile =
                    new SaveFileDialog();

                saveFile.Title =
                    "Lưu nội dung văn bản";

                saveFile.Filter =
                    "Rich Text Format (*.rtf)|*.rtf";

                saveFile.DefaultExt = "rtf";

                saveFile.AddExtension = true;

                if (saveFile.ShowDialog() ==
                    DialogResult.OK)
                {
                    currentFile = saveFile.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                richTextBox1.SaveFile(
                    currentFile,
                    RichTextBoxStreamType.RichText);

                MessageBox.Show(
                    "Lưu văn bản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu file!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        // =====================================================
        // 6. THOÁT
        // =====================================================

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // =====================================================
        // 7. CHỌN FONT
        // =====================================================

        private void cmbFont_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbFont.SelectedItem == null)
                return;

            string fontName =
                cmbFont.SelectedItem.ToString();

            ApplyFont(fontName);
        }

        private void ApplyFont(string fontName)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Font oldFont =
                    richTextBox1.SelectionFont;

                float size = 14;
                FontStyle style = FontStyle.Regular;

                if (oldFont != null)
                {
                    size = oldFont.Size;
                    style = oldFont.Style;
                }

                richTextBox1.SelectionFont =
                    new Font(fontName, size, style);
            }
            else
            {
                float size = 14;

                if (float.TryParse(
                    cmbSize.Text,
                    out float result))
                {
                    size = result;
                }

                richTextBox1.Font =
                    new Font(
                        fontName,
                        size,
                        FontStyle.Regular);
            }
        }

        // =====================================================
        // 8. CHỌN SIZE
        // =====================================================

        private void cmbSize_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbSize.SelectedItem == null)
                return;

            if (!float.TryParse(
                cmbSize.SelectedItem.ToString(),
                out float size))
                return;

            if (richTextBox1.SelectionLength > 0)
            {
                Font oldFont =
                    richTextBox1.SelectionFont;

                FontStyle style =
                    oldFont != null
                    ? oldFont.Style
                    : FontStyle.Regular;

                string fontName =
                    oldFont != null
                    ? oldFont.FontFamily.Name
                    : cmbFont.Text;

                richTextBox1.SelectionFont =
                    new Font(
                        fontName,
                        size,
                        style);
            }
            else
            {
                string fontName =
                    string.IsNullOrEmpty(cmbFont.Text)
                    ? "Tahoma"
                    : cmbFont.Text;

                richTextBox1.Font =
                    new Font(
                        fontName,
                        size,
                        FontStyle.Regular);
            }
        }

        // =====================================================
        // 9. IN ĐẬM
        // =====================================================

        private void btnBold_Click(
            object sender,
            EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        // =====================================================
        // 10. IN NGHIÊNG
        // =====================================================

        private void btnItalic_Click(
            object sender,
            EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        // =====================================================
        // 11. GẠCH DƯỚI
        // =====================================================

        private void btnUnderline_Click(
            object sender,
            EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        // =====================================================
        // 12. HÀM XỬ LÝ B/I/U
        // =====================================================

        private void ToggleFontStyle(
            FontStyle style)
        {
            if (richTextBox1.SelectionLength == 0)
                return;

            Font currentFont =
                richTextBox1.SelectionFont;

            if (currentFont == null)
                return;

            FontStyle newStyle;

            if (currentFont.Style.HasFlag(style))
            {
                newStyle =
                    currentFont.Style & ~style;
            }
            else
            {
                newStyle =
                    currentFont.Style | style;
            }

            richTextBox1.SelectionFont =
                new Font(
                    currentFont.FontFamily,
                    currentFont.Size,
                    newStyle);
        }

        // =====================================================
        // 13. FONT DIALOG
        // =====================================================

        private void mnuFont_Click(
            object sender,
            EventArgs e)
        {
            FontDialog fontDlg =
                new FontDialog();

            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            if (richTextBox1.SelectionFont != null)
            {
                fontDlg.Font =
                    richTextBox1.SelectionFont;

                fontDlg.Color =
                    richTextBox1.SelectionColor;
            }

            if (fontDlg.ShowDialog() !=
                DialogResult.Cancel)
            {
                richTextBox1.SelectionColor =
                    fontDlg.Color;

                richTextBox1.SelectionFont =
                    fontDlg.Font;

                cmbFont.Text =
                    fontDlg.Font.FontFamily.Name;

                cmbSize.Text =
                    fontDlg.Font.Size.ToString();
            }
        }

        // =====================================================
        // 14. ĐẾM SỐ TỪ
        // =====================================================

        private void richTextBox1_TextChanged(
            object sender,
            EventArgs e)
        {
            UpdateWordCount();
        }

        private void UpdateWordCount()
        {
            string text =
                richTextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                lblSoTu.Text = "Số từ: 0";
                return;
            }

            string[] words =
                text.Split(
                    new char[]
                    {
                        ' ',
                        '\n',
                        '\r',
                        '\t'
                    },
                    StringSplitOptions.RemoveEmptyEntries);

            lblSoTu.Text =
                "Số từ: " + words.Length;
        }
    }
}