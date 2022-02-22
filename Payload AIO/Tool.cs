using PayloadAIO.Properties;
using PayloadAIO.Updates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayloadAIO
{
    public partial class Tool : Form
    {
        private string Payload_File;
        private string Payload;
        private readonly string Startup = Application.StartupPath;

        public Tool()
        {
            InitializeComponent();
            //TestConnection();
            Text = $"Payload AIO {Application.ProductVersion}";
        }

        private async void Tool_Load(object Injecter, EventArgs e)
        {
            IP_TextBox.Text = Settings.Default.IP;
            Port_TextBox.Text = Settings.Default.PORT;
            InjectPayload_Button.Enabled = false;
            List<UpdateInfo> infos = await UpdateChecker.GetReleases();
            UpdateInfo latest = infos.OrderByDescending(x => x.ParsedVersion).FirstOrDefault();
            if (latest == null || latest.ParsedVersion.CompareTo(Version.Parse(Application.ProductVersion)) <= 0)
                return;

            if (MessageBox.Show($"An update is available:\r\n{latest.Name}\r\nVersion: {latest.Version}\r\n{(latest.Prerelease ? "This is a prerelease update.\r\n" : "")}Would you like to download it?",
                                "Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start(latest.URL);
        }

        #region PS4DEBUG
        //private static PS4DBG m = new(Settings.Default.IP);

        private void DeConPS4Debug_Click(object sender, EventArgs e)
        {
        }

        private void ConnectionTestTimer_Tick(object sender, EventArgs e)
        {
            /*
            if (!m.IsConnected)
            {
            }
            */
        }
        /*
        private void TestConnection()
        {
            Task.Factory.StartNew(delegate ()
            {
                try
                {
                    m.Connect();
                    Invoke(new MethodInvoker(delegate ()
                    {
                        CurrentStatus_Label.ForeColor = Color.LimeGreen;
                        CurrentStatus_Label.Text = "Connected to PS4 via PS4Debug!";
                        IP_TextBox.Enabled = false;
                    }));
                }
                catch
                {
                    CurrentStatus_Label.ForeColor = Color.Red;
                    CurrentStatus_Label.Text = "PS4Debug not injected!";
                }
            });
        }
        */
        #endregion PS4DEBUG

        private static void SocketConnection(string IP, int port, string Payload)
        {
            Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                ReceiveTimeout = 1500,
                SendTimeout = 1500
            };
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(Payload);
            socket.Close();
        }

        private void Payload_BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    CurrentStatus_Label.ForeColor = Color.RoyalBlue;
                    CurrentStatus_Label.Text = $"Sending {Payload}.bin to {IP_TextBox.Text}:{Port_TextBox.Text}...";
                }));
                SocketConnection(IP_TextBox.Text, Convert.ToInt32(Port_TextBox.Text), Payload_File);
                Thread.Sleep(1000);
                Invoke(new MethodInvoker(delegate ()
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
                    Invoke(new MethodInvoker(delegate ()
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
            Inject(P, "path");
        }

        private void InjectPayload_Button_Click(object sender, EventArgs e)
        {
            Payload_BGWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Injects payload to PS4 on set ip and port
        /// </summary>
        /// <param name="path"></param>
        /// <param name="method">btn, path</param>
        private void Inject(string path, string method = "btn")
        {
            if (method == "btn")
            {
                path = $@"{Startup}\Payloads\{path}";
                Payload = Path.GetFileNameWithoutExtension(path);
                Payload_File = path;
                InjectUtil(path);
            }
            else if (method == "path")
            {
                Payload = Path.GetFileNameWithoutExtension(path);
                Payload_File = path;
                InjectUtil(path);
            }
        }

        private void InjectUtil(string path)
        {
            if (!File.Exists(path))
            {
                FilePathBox.Text = "";
                CurrentStatus_Label.ForeColor = Color.Red;
                CurrentStatus_Label.Text = $"{Payload}.bin does not exist!";
                InjectPayload_Button.Enabled = false;
            }
            else
            {
                FilePathBox.Text = path;
                CurrentStatus_Label.ForeColor = Color.RoyalBlue;
                CurrentStatus_Label.Text = $"{Payload}.bin has been selected!";
                InjectPayload_Button.Enabled = true;
            }
        }

        private void GoldHenButton_Click(object sender, EventArgs e)
        {
            Inject("goldhen.bin");
        }

        private void PS4DebugButton_Click(object sender, EventArgs e)
        {
            Inject("ps4debug.bin");
        }

        private void WebRTEButton_Click(object sender, EventArgs e)
        {
            Inject("webrte.bin");
        }

        private void FanSpeedButton_Click(object sender, EventArgs e)
        {
            Inject($"fan-speed-{FanSpeedCombo.Text.ToLower()}.bin");
        }

        private void LinuxEnable_CheckedChanged(object sender, EventArgs e)
        {
            LinuxButton.Enabled = LinuxCombo.Enabled = LinuxEnable.Checked;
        }

        private void LinuxButton_Click(object sender, EventArgs e)
        {
            Inject($"linux{LinuxCombo.Text.ToLower()}.bin");
        }

        private void OrbisToolboxButton_Click(object sender, EventArgs e)
        {
            Inject("orbistoolbox.bin");
        }

        private void DisableUpdates_Click(object sender, EventArgs e)
        {
            Inject("disable-updates.bin");
        }

        private void EnableUpdates_Click(object sender, EventArgs e)
        {
            Inject("enable-updates.bin");
        }

        private void DBBackupButton_Click(object sender, EventArgs e)
        {
            Inject("dbbackup.bin");
        }

        private void DBRestoreButton_Click(object sender, EventArgs e)
        {
            Inject("dbrestore.bin");
        }

        private void HistoryBlockerButton_Click(object sender, EventArgs e)
        {
            Inject("history-blocker.bin");
        }

        private void FTPButton_Click(object sender, EventArgs e)
        {
            Inject("ftp.bin");
        }

        private void App2USBButton_Click(object sender, EventArgs e)
        {
            Inject("app2usb.bin");
        }

        private void ModuleDumperButton_Click(object sender, EventArgs e)
        {
            Inject("module-dumper.bin");
        }

        private void GameDumperButton_Click(object sender, EventArgs e)
        {
            Inject("game-dumper.bin");
        }

        private void AppDumperButton_Click(object sender, EventArgs e)
        {
            Inject("app-dumper.bin");
        }

        private void KernelDumperButton_Click(object sender, EventArgs e)
        {
            Inject("kernel-dumper.bin");
        }

        private void EnableBrowserButton_Click(object sender, EventArgs e)
        {
            Inject("enable-browser.bin");
        }

        private void DisableASLRButton_Click(object sender, EventArgs e)
        {
            Inject("disable-aslr.bin");
        }

        private void ToDexButton_Click(object sender, EventArgs e)
        {
            Inject("todex.bin");
        }

        private void DisableToDexButton_Click(object sender, EventArgs e)
        {
            Inject("todex-disable.bin");
        }

        private void RifRenamerButton_Click(object sender, EventArgs e)
        {
            Inject("rif-renamer.bin");
        }

        private void FakeUSBButton_Click(object sender, EventArgs e)
        {
            Inject("fakeusb.bin");
        }

        private void PermanentUartButton_Click(object sender, EventArgs e)
        {
            Inject("permanent-uart.bin");
        }
    }
}