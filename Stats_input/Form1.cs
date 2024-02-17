using System.Diagnostics;

namespace Stats_input
{
    public partial class statsInputForm : Form
    {
        public statsInputForm()
        {
            InitializeComponent();
        }

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
                }
            }
        }

        private void statsInputForm_Click(object sender, EventArgs e)
        {
            statsPictureBox.Focus();
        }
    }
}