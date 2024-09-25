using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class WordPad : Form
    {
        public static WordPad MainForm { get; set; }    
        public WordPad()
        {

            InitializeComponent();
            MainForm = this;
        }
        private void WordPad_Load(object sender, EventArgs e)
        {
            for (int i = 8; i <= 12; i++)
            {
                comboBoxFontSize.Items.Add(i);
            }
            for (int i = 14; i <= 28; i=i+2)
            {
                comboBoxFontSize.Items.Add(i);
            }
            comboBoxFontSize.Items.Add(36);
            comboBoxFontSize.Items.Add(48);
            comboBoxFontSize.Items.Add(72);
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFontFamily.Items.Add(font.Name);
            }
        }
        private void comboBoxFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbDocument.SelectionFont = new Font(comboBoxFontFamily.Text, int.Parse(comboBoxFontSize.Text),style);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int numberOfIncreaseClicks = 0;
        private void tsButtonIncrease_Click(object sender, EventArgs e)
        {
            numberOfIncreaseClicks++;
            if (int.Parse(comboBoxFontSize.Text) >= 72 && int.Parse(comboBoxFontSize.Text) < 80 && numberOfIncreaseClicks==1)
            {
                comboBoxFontSize.Text = (80).ToString();
            }
            if(int.Parse(comboBoxFontSize.Text) >= 80 && numberOfIncreaseClicks >1)
            {
                comboBoxFontSize.Text = (int.Parse(comboBoxFontSize.Text)+10).ToString();
            }
            if(int.Parse(comboBoxFontSize.Text) <8 && numberOfIncreaseClicks > 1)
            {
                comboBoxFontSize.Text = (int.Parse(comboBoxFontSize.Text)+1).ToString();
                if (int.Parse(comboBoxFontSize.Text) == 8)
                {
                    numberOfIncreaseClicks = 0;
                }
            }
            if(int.Parse(comboBoxFontSize.Text) < 72 && int.Parse(comboBoxFontSize.Text)>=8 &&numberOfIncreaseClicks>0)
            {
                numberOfIncreaseClicks = 0;
                comboBoxFontSize.SelectedIndex++;
            }
        }
        private void tsButtonDecrease_Click(object sender, EventArgs e)
        {
            if (int.Parse(comboBoxFontSize.Text) <= 8 && int.Parse(comboBoxFontSize.Text) > 1)
            {
                comboBoxFontSize.Text = (int.Parse(comboBoxFontSize.Text)-1).ToString();
            }
            if(int.Parse(comboBoxFontSize.Text) <= 72 && int.Parse(comboBoxFontSize.Text) >= 9)
            {
                comboBoxFontSize.SelectedIndex--;
            }
            if(int.Parse(comboBoxFontSize.Text) == 80)
            {
                comboBoxFontSize.Text = (int.Parse(comboBoxFontSize.Text) - 8).ToString();
            }
            if(int.Parse(comboBoxFontSize.Text) >= 90)
            {
                comboBoxFontSize.Text = (int.Parse(comboBoxFontSize.Text) - 10).ToString();
            }
        }

        private int numberOfBoldCliks = 0; 
        private FontStyle style;
        private void tsButtonBold_Click(object sender, EventArgs e)
        {
            numberOfBoldCliks++;
            if (numberOfBoldCliks == 1)
            {
                style = style ^ FontStyle.Bold;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
            }
            else if (numberOfBoldCliks == 2)
            {
                style -= FontStyle.Bold;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
                numberOfBoldCliks = 0;
            }
            
        }

        private int numberOfItalicClicks = 0;
        private void tsButtonItalic_Click(object sender, EventArgs e)
        {
            numberOfItalicClicks++;
            if (numberOfItalicClicks == 1)
            {
                style = style ^ FontStyle.Italic;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
            }
            else if (numberOfItalicClicks == 2)
            {
                style -= FontStyle.Italic;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
                numberOfItalicClicks = 0;
            }
            
        }

        private int numberOfUnderlineClicks = 0;

        private void tsButtonUnderline_Click(object sender, EventArgs e)
        {
            numberOfUnderlineClicks++;
            if (numberOfUnderlineClicks == 1)
            {
                style = style ^ FontStyle.Underline;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
            }
            else if (numberOfUnderlineClicks == 2)
            {
                style -= FontStyle.Underline;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
                numberOfUnderlineClicks = 0;
            }
            
        }
        private void açTSMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    byte[] textBytes = new byte[stream.Length];
                    stream.Read(textBytes, 0, textBytes.Length);
                    rbDocument.Text += Encoding.Default.GetString(textBytes);
                }
            }
        }

        private void kaydetTSMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if(res == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    byte[] textBytes = Encoding.Default.GetBytes(rbDocument.Text);
                    stream.Write(textBytes, 0, textBytes.Length);
                }
            }
        }

        private int numberOfStrikeOutClicks = 0;
        private void tSButtonStrikeOut_Click(object sender, EventArgs e)
        {
            numberOfStrikeOutClicks++;
            if (numberOfStrikeOutClicks == 1)
            {
                style = style ^ FontStyle.Strikeout;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
            }
            else if (numberOfStrikeOutClicks == 2)
            {
                style -= FontStyle.Strikeout;
                rbDocument.SelectionFont = new Font(rbDocument.SelectionFont, style);
                numberOfStrikeOutClicks = 0;
            }
        }

        private void tSButtonSelectAll_Click(object sender, EventArgs e)
        {
            rbDocument.SelectAll();
        }

        private void tSDDButtonPaste_Click(object sender, EventArgs e)
        {
            rbDocument.Text += Clipboard.GetText();
        }

        private void tSButtonCut_Click(object sender, EventArgs e)
        {

            if (tSButtonCut.Enabled)
            {
                Clipboard.SetText(rbDocument.SelectedText);
                rbDocument.SelectedText = "";
            }
        }

        private void tSButtonCopy_Click(object sender, EventArgs e)
        {
            if (tsButtonCopy.Enabled)
            {
                Clipboard.SetText(rbDocument.SelectedText);
            }
            
        }

        private void rbDocument_SelectionChanged(object sender, EventArgs e)
       {
            if(rbDocument.SelectedText != "")
            {
                tsButtonCopy.Enabled = true;
                tSButtonCut.Enabled = true;
            }
            else
            {
                tsButtonCopy.Enabled = false;
                tSButtonCut.Enabled = false;
            }
        }

        private Color tempColor;
        private void tSOtherColor_Click(object sender, EventArgs e)
        {
           
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            rbDocument.SelectionColor = dlg.Color;
            tempColor = dlg.Color;
        }

        private void toolStripMenuItemOtomatik_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionColor = Color.Black;
            tempColor = Color.Black;
        }

        private Color tempSelectionColor;
        private void SelectionBackColor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            rbDocument.SelectionBackColor = tsm.BackColor;
            tempSelectionColor = tsm.BackColor;
        }

        private void SelectionColorParent_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionBackColor = tempSelectionColor;
        }

        private void tSButtonForeColorParent_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionColor = tempColor;
        }


        private void tSButtonObject_Click(object sender, EventArgs e)
        {
           
        }

        private void yazdırTSMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void tSDDButtonPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string lstrFile = fileDialog.FileName;
            Bitmap myBitmap = new Bitmap(lstrFile);
            Clipboard.SetDataObject(myBitmap);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            if (rbDocument.CanPaste(myFormat))
            {
                rbDocument.Paste(myFormat);
            }
            else
            {
                MessageBox.Show("Seçtiğiniz biçim desteklenmiyor.");
            }
        }

        private void tSButtonAlignLeft_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tSButtonAlignRight_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tSButtonAlignCenter_Click(object sender, EventArgs e)
        {
            rbDocument.SelectionAlignment= HorizontalAlignment.Center;
        }

        private void tSButtonDateTime_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        //private int Width = 700;
        private int zoomOutClicks = 0;
        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value != trackBar1.Maximum)
            {
                trackBar1.Value = (((trackBar1.Value / 10) + 1) * 10);
                labelValue.Text = "%" + trackBar1.Value.ToString();
                rbDocument.Width += 10;
                rbDocument.Location = new Point(rbDocument.Location.X - 5, rbDocument.Location.Y);
            }
        }
        
        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value != 10)
            {
                if (trackBar1.Value % 10 == 0)
                {
                    trackBar1.Value = (trackBar1.Value - 10);
                }
                else
                {
                    trackBar1.Value = (((trackBar1.Value / 10)) * 10);
                }
                rbDocument.Width -= 10;
                rbDocument.Location = new Point(rbDocument.Location.X + 5, rbDocument.Location.Y);
                labelValue.Text = "%" + trackBar1.Value.ToString();
            }
        }

        private void tSButtonZoom100_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 100;
            labelValue.Text = "%" + trackBar1.Value.ToString();
            rbDocument.Width = 700;
            rbDocument.Location = new Point(273, 188);

        }

        private void tSButtonSuperscript_Click(object sender, EventArgs e)
        {
        }

        private void tSButtonSubscript_Click(object sender, EventArgs e)
        {
            
        }

        private int checkClicks = 0;
        private void checkBoxDurum_CheckedChanged(object sender, EventArgs e)
        {
            checkClicks++;
            if (checkClicks == 1)
            {
                labelValue.Hide();
                buttonZoomIn.Hide();
                buttonZoomOut.Hide();
                trackBar1.Hide();
            }
            else if (checkClicks == 2)
            {
                labelValue.Show();
                buttonZoomOut.Show();
                buttonZoomIn.Show();
                trackBar1.Show();
                checkClicks = 0;
            }
        }
        private int tempValue = 100;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelValue.Text = "%" + trackBar1.Value.ToString();
            if (trackBar1.Value > tempValue)
            {
                rbDocument.Width += 10;
                rbDocument.Location = new Point(rbDocument.Location.X - 5, rbDocument.Location.Y);
                tempValue = trackBar1.Value;
            }
            else if (trackBar1.Value < tempValue)
            {
                rbDocument.Width -= 10;
                rbDocument.Location = new Point(rbDocument.Location.X + 5, rbDocument.Location.Y);
                tempValue = trackBar1.Value;
            }
        }

        private void tsButtonFinder_Click(object sender, EventArgs e)
        {
            /*
             find.tbFinder.Text = this.rbDocument.SelectedText;
             rbDocument.SelectedText = find.tbFinder.Text;
             find.Caller = this;
            */
            Form3 find = new Form3();
            find.Show();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbDocument.Clear();
        }

        private void tSButtonSelectColor_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {

        }
    }
}

