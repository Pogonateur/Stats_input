using System.Diagnostics;

namespace Stats_input
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}