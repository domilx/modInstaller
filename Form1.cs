using System.Diagnostics;
using System;
using System.Net;
using System.IO;
namespace Minecraft_Add_On_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void label1_Click(object sender, EventArgs e)
		{
			//ResizeableBorderlessForm resizeableBorderlessForm = new();
			//resizeableBorderlessForm.Show();
		}

		private void forge_Click(object sender, EventArgs e)
		{
			//Form form = new();
			//form.Text = "Slider Puzzle Example";
			//SlidePuzzleControl slidePuzzleControl = new();
			//slidePuzzleControl.Dock = DockStyle.Fill;
			//form.Controls.Add(slidePuzzleControl);
			//form.Show();
		}

		private void java_Click(object sender, EventArgs e)
		{
			
		}

		private void badlion_Click(object sender, EventArgs e)
		{

		}

		private void lunar_Click(object sender, EventArgs e)
		{

		}

		private void curseforge_Click(object sender, EventArgs e)
		{

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closePanel_Paint(object sender, PaintEventArgs e)
        {
			
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
			Close();
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void movePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void java_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://download.oracle.com/java/17/latest/jdk-17_windows-x64_bin.exe", @"c:\temp\javaInstaller.exe");
            Process.Start("C:\\temp\\javaInstaller.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/926539742324068382/926959286804951060/OptiFine_1.12.2_HD_U_G5.jar", @"c:\temp\optifine.jar");
            Process.Start("java.exe", "-jar c:\\temp\\optifine.jar");
        }

        private void badlion_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://client-updates-cdn77.badlion.net/Badlion%20Client%20Setup%203.6.4.exe", @"c:\temp\badlion.exe");
            Process.Start("c:\\temp\\badlion.exe");
        }

        private void curseforge_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/926539742324068382/926960589090197585/CurseForge_-_Installer.exe", @"c:\temp\curseforge.exe");
            Process.Start("c:\\temp\\curseforge.exe");
        }

        private void lunar_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://launcherupdates.lunarclientcdn.com/Lunar%20Client%20v2.9.3.exe", @"c:\temp\lunar.exe");
            Process.Start("c:\\temp\\lunar.exe");
        }

        private void forge_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory("c:\\temp\\");
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://maven.minecraftforge.net/net/minecraftforge/forge/1.12.2-14.23.5.2860/forge-1.12.2-14.23.5.2860-installer.jar", @"c:\temp\forge.jar");
            Process.Start("java.exe", "-jar c:\\temp\\forge.jar");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}