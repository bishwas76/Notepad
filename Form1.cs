using System;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewFile()
        {
            if (!string.IsNullOrEmpty(this.richTextBox1.Text))
            {
                DialogResult dialog = MessageBox.Show("Would you like to Save?", "Save", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dialog == DialogResult.No)
                {
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "Untitled";
                }
            }
            else
            {
                this.richTextBox1.Text = string.Empty;
                this.Text = "Untitled";
            }
        }

        private void newStripMenu_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenFile()
        {
            openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                this.Text = openFileDialog.FileName;
            }
        }

        private void openStripMenu_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveAsFile()
        {
             saveFileDialog = new SaveFileDialog();
             saveFileDialog.Filter = "Text File (*.txt) | *.txt | All Files (*.*) | *.*";
             if (saveFileDialog.ShowDialog() == DialogResult.OK)
             {
                 File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                 this.Text = saveFileDialog.FileName;
            }
        }

        private void SaveFile()
        {
            if (this.Text.Equals("Notepad") || this.Text.Equals("Untitled"))
            {
                SaveAsFile();
            }
            else
            {
                File.WriteAllText(this.Text, this.richTextBox1.Text);
            }
            }


        private void saveStripMenu_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsStripMenu_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void exitStripMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTextBox1.Text))
            {
                DialogResult dialog = MessageBox.Show("Would you like to Save?", "Save", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dialog == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void copyStripMenu_Click(object sender, EventArgs e)
        {
            RichTextBox txtData = this.ActiveControl as RichTextBox;
            if (txtData.SelectedText != string.Empty)
            {
                Clipboard.SetData(DataFormats.Text, txtData.SelectedText);
            }
        }

        private void cutStripMenu_Click(object sender, EventArgs e)
        {
            RichTextBox txtData = this.ActiveControl as RichTextBox;
            if(txtData.SelectedText != string.Empty)
            {
                Clipboard.SetData(DataFormats.Text, txtData.SelectedText);
            }
            txtData.SelectedText = string.Empty;
        }

        private void pasteStripMenu_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is RichTextBox)
            {
                RichTextBox txtData = this.ActiveControl as RichTextBox;
                txtData.Paste();
            }
        }

        private void undoStripMenu_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is RichTextBox)
            {
                RichTextBox txtData = this.ActiveControl as RichTextBox;
                txtData.Undo();
            }
        }

        private void AddFont()
        {
            fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Font = fontDialog.Font;
            }
        }

        private void fontStripMenu_Click(object sender, EventArgs e)
        {
            AddFont();
        }
    }
}
