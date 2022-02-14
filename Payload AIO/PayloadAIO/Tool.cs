using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using librpc;
using PayloadAIO.Properties;

namespace PayloadAIO
{
    public partial class Tool : Form
	{
		private string Payload_File;
		private string Payload;
		private readonly string Startup = Application.StartupPath;
		public static PS4RPC ps4 = new PS4RPC(Settings.Default.IP);

		public Tool()
		{
			InitializeComponent();
			TestConnection();
		}

		private void TestConnection()
		{
			Task.Factory.StartNew(delegate()
			{
				try
				{
					ps4.Connect();
					Invoke(new MethodInvoker(delegate()
					{
						CurrentStatus_Label.ForeColor = Color.LimeGreen;
						CurrentStatus_Label.Text = "Connected to PS4";
						IP_TextBox.Enabled = false;
						Port_TextBox.Enabled = false;
					}));
				}
				catch
				{
				}
			});
		}

		private void Tool_Load(object Injecter, EventArgs e)
		{
			IP_TextBox.Text = Settings.Default.IP;
			Port_TextBox.Text = Settings.Default.PORT;
			InjectPayload_Button.Enabled = false;
		}

		private void SocketConnection(string IP, int port, string Payload)
		{
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                ReceiveTimeout = 1500,
                SendTimeout = 1500
            };
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
			socket.SendFile(Payload);
			socket.Close();
		}

		private void IP_TextBox_TextChanged(object Injecter, EventArgs e)
		{
			Settings.Default.IP = IP_TextBox.Text;
			Settings.Default.Save();
		}

		private void Port_TextBox_TextChanged(object Injecter, EventArgs e)
		{
			Settings.Default.PORT = Port_TextBox.Text;
			Settings.Default.Save();
		}

		private void SelectPayload_Button_Click(object Injecter, EventArgs e)
		{
			OpenPayloadDialog.ShowDialog();
			var P = OpenPayloadDialog.FileName;
			Payload_File = P;
			Status(P);
			InjectPayload_Button.Enabled = true;
		}

		private void InjectPayload_Button_Click(object sender, EventArgs e)
		{
			Payload_BGWorker.RunWorkerAsync();
		}

		private void Payload_BGWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				Invoke(new MethodInvoker(delegate()
				{
					CurrentStatus_Label.ForeColor = Color.RoyalBlue;
					CurrentStatus_Label.Text = $"Sending {Payload}.bin to {IP_TextBox.Text}:{Port_TextBox.Text}...";
				}));
				SocketConnection(IP_TextBox.Text, Convert.ToInt32(Port_TextBox.Text), Payload_File);
				Thread.Sleep(1000);
				Invoke(new MethodInvoker(delegate()
				{
					CurrentStatus_Label.ForeColor = Color.LimeGreen;
					CurrentStatus_Label.Text = $"{Payload}.bin injected successfully!";
				}));
			}
			catch (Exception ex)
			{
				bool flag = ex.HResult == -2147467259;
				if (flag)
				{
					Invoke(new MethodInvoker(delegate()
					{
						CurrentStatus_Label.ForeColor = Color.Red;
						CurrentStatus_Label.Text = $"{Payload}.bin injection failed!";
					}));
				}
				else
				{
					MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		private void Status(string path)
        {
			FilePathBox.Text = path;
			Payload  = Path.GetFileNameWithoutExtension(path);
			CurrentStatus_Label.ForeColor = Color.RoyalBlue;
			CurrentStatus_Label.Text = $"{Payload}.bin has been selected!";
		}

        private void GoldHenButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\goldhen.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void PS4DebugButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\ps4debug.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void WebRTEButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\webrte.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void FanSpeedButton_Click(object sender, EventArgs e)
        {
			switch (FanSpeedCombo.Text)
            {
				case "Default":
					Payload_File = $@"{Startup}\payloads\fan-speed-default.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "80":
					Payload_File = $@"{Startup}\payloads\fan-speed-80.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "75":
					Payload_File = $@"{Startup}\payloads\fan-speed-75.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "70":
					Payload_File = $@"{Startup}\payloads\fan-speed-70.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "65":
					Payload_File = $@"{Startup}\payloads\fan-speed-65.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "60":
					Payload_File = $@"{Startup}\payloads\fan-speed-60.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "55":
					Payload_File = $@"{Startup}\payloads\fan-speed-55.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "50":
					Payload_File = $@"{Startup}\payloads\fan-speed-50.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				default:
					Payload_File = $@"{Startup}\payloads\fan-speed-default.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
			}
		}

        private void LinuxEnable_CheckedChanged(object sender, EventArgs e)
        {
			LinuxButton.Enabled = LinuxCombo.Enabled = LinuxEnable.Checked;
        }

		private void LinuxButton_Click(object sender, EventArgs e)
		{
			switch (LinuxCombo.Text)
			{
				case "1GB":
					Payload_File = $@"{Startup}\payloads\linux1gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "2GB":
					Payload_File = $@"{Startup}\payloads\linux2gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "3GB":
					Payload_File = $@"{Startup}\payloads\linux3gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "4GB":
					Payload_File = $@"{Startup}\payloads\linux4gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				case "5GB":
					Payload_File = $@"{Startup}\payloads\linux5gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
				default:
					Payload_File = $@"{Startup}\payloads\linux1gb.bin";
					Status(Payload_File);
					InjectPayload_Button.Enabled = true;
					break;
			}
		}

		private void OrbisToolboxButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\orbistoolbox.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

		private void DisableUpdates_Click(object sender, EventArgs e)
		{
			Payload_File = $@"{Startup}\payloads\disable-updates.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

		private void EnableUpdates_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\enable-updates.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void DBBackupButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\dbbackup.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void DBRestoreButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\dbrestore.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void HistoryBlockerButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\history-blocker.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void FTPButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\ftp.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void App2USBButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\app2usb.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		} 

		private void ModuleDumperButton_Click(object sender, EventArgs e)
		{
			Payload_File = $@"{Startup}\payloads\module-dumper.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

		private void GameDumperButton_Click(object sender, EventArgs e)
		{
			Payload_File = $@"{Startup}\payloads\game-dumper.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

		private void AppDumperButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\app-dumper.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void KernelDumperButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\kernel-dumper.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void EnableBrowserButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\enable-browser.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void DisableASLRButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\disable-aslr.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void ToDexButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\todex.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void RifRenamerButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\rif-renamer.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void FakeUSBButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\fakeusb.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}

        private void PermanentUartButton_Click(object sender, EventArgs e)
        {
			Payload_File = $@"{Startup}\payloads\permanent-uart.bin";
			Status(Payload_File);
			InjectPayload_Button.Enabled = true;
		}
    }
}
