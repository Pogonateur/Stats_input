using System;
using System.Diagnostics;
using Tesseract;

namespace Stats_input
{
    public partial class statsInputForm : Form
    {
        public statsInputForm()
        {
            InitializeComponent();
        }

        int[] statsArray = new int[6];

        private void toSpypokes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var targetURL = "http://www.psypokes.com/dex/iv.php";
            var psi = new ProcessStartInfo
            {
                FileName = targetURL,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void toMarriland_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var targetURL = "https://marriland.com/tools/iv-calculator/";
            var psi = new ProcessStartInfo
            {
                FileName = targetURL,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    statsPictureBox.Image = Image.FromFile(filenames[0]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statsPictureBox.AllowDrop = true;
        }

        private void statsPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void statsInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                if (Clipboard.ContainsImage())
                {
                    statsPictureBox.Image = Clipboard.GetImage();
                    textExtracted();
                }
            }
        }

        private void statsInputForm_Click(object sender, EventArgs e)
        {
            statsPictureBox.Focus();
        }

        private void textExtracted()
        {
            var ocrengine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
            ocrengine.SetVariable("tessedit_char_whitelist", "0123456789");
            Bitmap bitmap = new Bitmap(statsPictureBox.Image);
            var res = ocrengine.Process(PixConverter.ToPix(bitmap));
            //MessageBox.Show(res.GetText());
            setStatsIntoLabelBoxes(res.GetText());
        }

        private void setStatsIntoLabelBoxes(string statsNumbers)
        {
            string[] statsNumbersArray = new string[6];
            int i = 0;
            char[] delimiters = new char[] { ' ', '\t', '\n', };

            foreach (string statsNumber in statsNumbers.Split(delimiters))
            {
                statsNumbersArray[i] = statsNumber;
                i++;
                if (i > 5)
                {
                    break;
                }
            }

            hpDetectedTextBox.Text = statsNumbersArray[0];
            atkDetectedTextBox.Text = statsNumbersArray[1];
            defDetectedTextBox.Text = statsNumbersArray[2];
            spAtkDetectedTextBox.Text = statsNumbersArray[3];
            spDefDetectedTextBox.Text = statsNumbersArray[4];
            speedDetectedTextBox.Text = statsNumbersArray[5];

            statsArray[0] = Int32.Parse(hpDetectedTextBox.Text);
            statsArray[1] = Int32.Parse(atkDetectedTextBox.Text);
            statsArray[2] = Int32.Parse(defDetectedTextBox.Text);
            statsArray[3] = Int32.Parse(spAtkDetectedTextBox.Text);
            statsArray[4] = Int32.Parse(spDefDetectedTextBox.Text);
            statsArray[5] = Int32.Parse(speedDetectedTextBox.Text);

        }

        private void hpDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[0] = Int32.Parse(hpDetectedTextBox.Text);
        }

        private void atkDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[1] = Int32.Parse(atkDetectedTextBox.Text);
        }

        private void defDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[2] = Int32.Parse(defDetectedTextBox.Text);
        }

        private void spAtkDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[3] = Int32.Parse(spAtkDetectedTextBox.Text);

        }

        private void spDefDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[4] = Int32.Parse(spDefDetectedTextBox.Text);
        }

        private void speedDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            statsArray[5] = Int32.Parse(speedDetectedTextBox.Text);
        }

        private void hpDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void atkDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void defDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void spAtkDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void spDefDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void speedDetectedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}