using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection.Metadata;
using Tesseract;

namespace Stats_input
{
    public partial class statsInputForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //constants for modifiers
        private const int MOD_NONE = 0x0000;
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;
        
        private const int WM_HOTKEY = 0x0312;

        private const int HOTKEY_ID = 1;

        public statsInputForm()
        {
            InitializeComponent();

            FormClosing += (s, e) => { UnregisterHotKey(Handle, HOTKEY_ID); };

            RegisterHotKey(Handle, HOTKEY_ID, MOD_NONE, (int)Keys.F7);
        }

        private void StatsInputForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (id == HOTKEY_ID)
                {
                    //MessageBox.Show("Hotkey has been pressed!");
                    typeStats(statsArray);
                }
            }

            base.WndProc(ref m);
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
                    extractText();
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
                    extractText();
                }
            }
        }

        private void statsInputForm_Click(object sender, EventArgs e)
        {
            statsPictureBox.Focus();
        }

        private void extractText()
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

            if (Int32.TryParse(hpDetectedTextBox.Text, out int j))
            {
                statsArray[0] = j;
            }
            if (Int32.TryParse(atkDetectedTextBox.Text, out int j2))
            {
                statsArray[1] = j2;
            }
            if (Int32.TryParse(defDetectedTextBox.Text, out int j3))
            {
                statsArray[2] = j3;
            }
            if (Int32.TryParse(spAtkDetectedTextBox.Text, out int j4))
            {
                statsArray[3] = j4;
            }
            if (Int32.TryParse(spDefDetectedTextBox.Text, out int j5))
            {
                statsArray[4] = j5;
            }
            if (Int32.TryParse(speedDetectedTextBox.Text, out int j6))
            {
                statsArray[5] = j6;
            }
        }

        private void hpDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(hpDetectedTextBox.Text, out int j))
            {
                statsArray[0] = j;
            }
        }

        private void atkDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(atkDetectedTextBox.Text, out int j))
            {
                statsArray[1] = j;
            }
        }

        private void defDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(defDetectedTextBox.Text, out int j))
            {
                statsArray[2] = j;
            }
        }

        private void spAtkDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(spAtkDetectedTextBox.Text, out int j))
            {
                statsArray[3] = j;
            }

        }

        private void spDefDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(spDefDetectedTextBox.Text, out int j))
            {
                statsArray[4] = j;
            }
        }

        private void speedDetectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(speedDetectedTextBox.Text, out int j))
            {
                statsArray[5] = j;
            }
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

        private void typeStats(int[] statsArr)
        {
            char c;
            ushort scanCode;
            string currentStat;

            foreach (int stat in statsArr)
            {
                currentStat = "" + stat;

                for (int i = 0; i<currentStat.Length; i++)
                {
                    c = char.Parse(currentStat.Substring(i, 1));
                    scanCode = GetScanCode(c);
                    InputSender.ClickKey(scanCode);
                }
                InputSender.ClickKey(0x0f);
            }
        }

        private ushort GetScanCode(char c)
        {
            switch (Char.ToLower(c)) {
                case '\n':
                    return 0x1c;

                case ')':
                case '0':
                    return 0x0b;

                case '!':
                case '1':
                    return 0x02;

                case '@':
                case '2':
                    return 0x03;

                case '#':
                case '3':
                    return 0x04;

                case '$':
                case '4':
                    return 0x05;

                case '%':
                case '5':
                    return 0x06;

                case '^':
                case '6':
                    return 0x07;

                case '&':
                case '7':
                    return 0x08;

                case '*':
                case '8':
                    return 0x09;

                case '(':
                case '9':
                    return 0x0a;

                default:
                    return 00;
            }
        }
    }
}