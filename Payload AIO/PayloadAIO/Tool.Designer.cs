namespace PayloadAIO
{
    // Token: 0x02000008 RID: 8
    public partial class Tool : global::System.Windows.Forms.Form
    {
        // Token: 0x06000051 RID: 81 RVA: 0x000040D8 File Offset: 0x000022D8
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00004110 File Offset: 0x00002310
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.InjectPayload_Button = new System.Windows.Forms.Button();
            this.SelectPayload_Button = new System.Windows.Forms.Button();
            this.CurrentStatus_Label = new System.Windows.Forms.Label();
            this.OpenPayloadDialog = new System.Windows.Forms.OpenFileDialog();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Payload_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.GoldHenButton = new System.Windows.Forms.Button();
            this.PayloadGroupB = new System.Windows.Forms.GroupBox();
            this.PS4DebugButton = new System.Windows.Forms.Button();
            this.WebRTEButton = new System.Windows.Forms.Button();
            this.DisableUpdates = new System.Windows.Forms.Button();
            this.OrbisToolboxButton = new System.Windows.Forms.Button();
            this.EnableUpdates = new System.Windows.Forms.Button();
            this.HistoryBlockerButton = new System.Windows.Forms.Button();
            this.DBBackupButton = new System.Windows.Forms.Button();
            this.DBRestoreButton = new System.Windows.Forms.Button();
            this.ToDexButton = new System.Windows.Forms.Button();
            this.KernelDumperButton = new System.Windows.Forms.Button();
            this.PermanentUartButton = new System.Windows.Forms.Button();
            this.App2USBButton = new System.Windows.Forms.Button();
            this.AppDumperButton = new System.Windows.Forms.Button();
            this.RifRenamerButton = new System.Windows.Forms.Button();
            this.GameDumperButton = new System.Windows.Forms.Button();
            this.EnableBrowserButton = new System.Windows.Forms.Button();
            this.FakeUSBButton = new System.Windows.Forms.Button();
            this.DisableASLRButton = new System.Windows.Forms.Button();
            this.ModuleDumperButton = new System.Windows.Forms.Button();
            this.FanSpeedButton = new System.Windows.Forms.Button();
            this.LinuxButton = new System.Windows.Forms.Button();
            this.FanSpeedCombo = new System.Windows.Forms.ComboBox();
            this.LinuxCombo = new System.Windows.Forms.ComboBox();
            this.LinuxEnable = new System.Windows.Forms.CheckBox();
            this.LinuxGroup = new System.Windows.Forms.GroupBox();
            this.MainGB = new System.Windows.Forms.GroupBox();
            this.FTPButton = new System.Windows.Forms.Button();
            this.DumperGB = new System.Windows.Forms.GroupBox();
            this.PayloadGroupB.SuspendLayout();
            this.LinuxGroup.SuspendLayout();
            this.MainGB.SuspendLayout();
            this.DumperGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(117, 31);
            this.Port_TextBox.Multiline = true;
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(44, 20);
            this.Port_TextBox.TabIndex = 0;
            this.Port_TextBox.TabStop = false;
            this.Port_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Port_TextBox.TextChanged += new System.EventHandler(this.Port_TextBox_TextChanged);
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_TextBox.Location = new System.Drawing.Point(6, 31);
            this.IP_TextBox.Multiline = true;
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(105, 20);
            this.IP_TextBox.TabIndex = 0;
            this.IP_TextBox.TabStop = false;
            this.IP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IP_TextBox.TextChanged += new System.EventHandler(this.IP_TextBox_TextChanged);
            // 
            // InjectPayload_Button
            // 
            this.InjectPayload_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InjectPayload_Button.Location = new System.Drawing.Point(633, 30);
            this.InjectPayload_Button.Name = "InjectPayload_Button";
            this.InjectPayload_Button.Size = new System.Drawing.Size(140, 23);
            this.InjectPayload_Button.TabIndex = 0;
            this.InjectPayload_Button.TabStop = false;
            this.InjectPayload_Button.Text = "Inject Payload";
            this.InjectPayload_Button.UseVisualStyleBackColor = true;
            this.InjectPayload_Button.Click += new System.EventHandler(this.InjectPayload_Button_Click);
            // 
            // SelectPayload_Button
            // 
            this.SelectPayload_Button.Location = new System.Drawing.Point(167, 30);
            this.SelectPayload_Button.Name = "SelectPayload_Button";
            this.SelectPayload_Button.Size = new System.Drawing.Size(140, 23);
            this.SelectPayload_Button.TabIndex = 0;
            this.SelectPayload_Button.TabStop = false;
            this.SelectPayload_Button.Text = "Select Payload";
            this.SelectPayload_Button.UseVisualStyleBackColor = true;
            this.SelectPayload_Button.Click += new System.EventHandler(this.SelectPayload_Button_Click);
            // 
            // CurrentStatus_Label
            // 
            this.CurrentStatus_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentStatus_Label.AutoSize = true;
            this.CurrentStatus_Label.Location = new System.Drawing.Point(44, 200);
            this.CurrentStatus_Label.Name = "CurrentStatus_Label";
            this.CurrentStatus_Label.Size = new System.Drawing.Size(0, 13);
            this.CurrentStatus_Label.TabIndex = 0;
            // 
            // OpenPayloadDialog
            // 
            this.OpenPayloadDialog.Filter = "BIN file (*.BIN)|*.BIN";
            // 
            // Status_Label
            // 
            this.Status_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(4, 200);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(42, 13);
            this.Status_Label.TabIndex = 0;
            this.Status_Label.Text = "Status:";
            // 
            // Payload_BGWorker
            // 
            this.Payload_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Payload_BGWorker_DoWork);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathBox.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.FilePathBox.Location = new System.Drawing.Point(6, 5);
            this.FilePathBox.MaxLength = 2000000000;
            this.FilePathBox.Multiline = true;
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(767, 20);
            this.FilePathBox.TabIndex = 1;
            this.FilePathBox.TabStop = false;
            // 
            // GoldHenButton
            // 
            this.GoldHenButton.Location = new System.Drawing.Point(6, 14);
            this.GoldHenButton.Name = "GoldHenButton";
            this.GoldHenButton.Size = new System.Drawing.Size(101, 23);
            this.GoldHenButton.TabIndex = 2;
            this.GoldHenButton.Text = "GoldHen";
            this.GoldHenButton.UseVisualStyleBackColor = true;
            this.GoldHenButton.Click += new System.EventHandler(this.GoldHenButton_Click);
            // 
            // PayloadGroupB
            // 
            this.PayloadGroupB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PayloadGroupB.Controls.Add(this.DumperGB);
            this.PayloadGroupB.Controls.Add(this.MainGB);
            this.PayloadGroupB.Controls.Add(this.LinuxGroup);
            this.PayloadGroupB.Controls.Add(this.DisableASLRButton);
            this.PayloadGroupB.Controls.Add(this.FakeUSBButton);
            this.PayloadGroupB.Controls.Add(this.EnableBrowserButton);
            this.PayloadGroupB.Controls.Add(this.RifRenamerButton);
            this.PayloadGroupB.Controls.Add(this.PermanentUartButton);
            this.PayloadGroupB.Controls.Add(this.ToDexButton);
            this.PayloadGroupB.Location = new System.Drawing.Point(6, 57);
            this.PayloadGroupB.Name = "PayloadGroupB";
            this.PayloadGroupB.Size = new System.Drawing.Size(767, 140);
            this.PayloadGroupB.TabIndex = 3;
            this.PayloadGroupB.TabStop = false;
            this.PayloadGroupB.Text = "Payloads";
            // 
            // PS4DebugButton
            // 
            this.PS4DebugButton.Location = new System.Drawing.Point(109, 14);
            this.PS4DebugButton.Name = "PS4DebugButton";
            this.PS4DebugButton.Size = new System.Drawing.Size(101, 23);
            this.PS4DebugButton.TabIndex = 3;
            this.PS4DebugButton.Text = "PS4Debug";
            this.PS4DebugButton.UseVisualStyleBackColor = true;
            this.PS4DebugButton.Click += new System.EventHandler(this.PS4DebugButton_Click);
            // 
            // WebRTEButton
            // 
            this.WebRTEButton.Location = new System.Drawing.Point(212, 14);
            this.WebRTEButton.Name = "WebRTEButton";
            this.WebRTEButton.Size = new System.Drawing.Size(101, 23);
            this.WebRTEButton.TabIndex = 4;
            this.WebRTEButton.Text = "WebRTE";
            this.WebRTEButton.UseVisualStyleBackColor = true;
            this.WebRTEButton.Click += new System.EventHandler(this.WebRTEButton_Click);
            // 
            // DisableUpdates
            // 
            this.DisableUpdates.Location = new System.Drawing.Point(109, 39);
            this.DisableUpdates.Name = "DisableUpdates";
            this.DisableUpdates.Size = new System.Drawing.Size(101, 23);
            this.DisableUpdates.TabIndex = 5;
            this.DisableUpdates.Text = "Disable Updates";
            this.DisableUpdates.UseVisualStyleBackColor = true;
            this.DisableUpdates.Click += new System.EventHandler(this.DisableUpdates_Click);
            // 
            // OrbisToolboxButton
            // 
            this.OrbisToolboxButton.Location = new System.Drawing.Point(6, 39);
            this.OrbisToolboxButton.Name = "OrbisToolboxButton";
            this.OrbisToolboxButton.Size = new System.Drawing.Size(101, 23);
            this.OrbisToolboxButton.TabIndex = 6;
            this.OrbisToolboxButton.Text = "Orbis Toolbox";
            this.OrbisToolboxButton.UseVisualStyleBackColor = true;
            this.OrbisToolboxButton.Click += new System.EventHandler(this.OrbisToolboxButton_Click);
            // 
            // EnableUpdates
            // 
            this.EnableUpdates.Location = new System.Drawing.Point(212, 39);
            this.EnableUpdates.Name = "EnableUpdates";
            this.EnableUpdates.Size = new System.Drawing.Size(101, 23);
            this.EnableUpdates.TabIndex = 7;
            this.EnableUpdates.Text = "Enable Updates";
            this.EnableUpdates.UseVisualStyleBackColor = true;
            this.EnableUpdates.Click += new System.EventHandler(this.EnableUpdates_Click);
            // 
            // HistoryBlockerButton
            // 
            this.HistoryBlockerButton.Location = new System.Drawing.Point(6, 64);
            this.HistoryBlockerButton.Name = "HistoryBlockerButton";
            this.HistoryBlockerButton.Size = new System.Drawing.Size(101, 23);
            this.HistoryBlockerButton.TabIndex = 8;
            this.HistoryBlockerButton.Text = "History Blocker";
            this.HistoryBlockerButton.UseVisualStyleBackColor = true;
            this.HistoryBlockerButton.Click += new System.EventHandler(this.HistoryBlockerButton_Click);
            // 
            // DBBackupButton
            // 
            this.DBBackupButton.Location = new System.Drawing.Point(109, 64);
            this.DBBackupButton.Name = "DBBackupButton";
            this.DBBackupButton.Size = new System.Drawing.Size(101, 23);
            this.DBBackupButton.TabIndex = 9;
            this.DBBackupButton.Text = "DB Backup";
            this.DBBackupButton.UseVisualStyleBackColor = true;
            this.DBBackupButton.Click += new System.EventHandler(this.DBBackupButton_Click);
            // 
            // DBRestoreButton
            // 
            this.DBRestoreButton.Location = new System.Drawing.Point(212, 64);
            this.DBRestoreButton.Name = "DBRestoreButton";
            this.DBRestoreButton.Size = new System.Drawing.Size(101, 23);
            this.DBRestoreButton.TabIndex = 10;
            this.DBRestoreButton.Text = "DB Restore";
            this.DBRestoreButton.UseVisualStyleBackColor = true;
            this.DBRestoreButton.Click += new System.EventHandler(this.DBRestoreButton_Click);
            // 
            // ToDexButton
            // 
            this.ToDexButton.Location = new System.Drawing.Point(551, 77);
            this.ToDexButton.Name = "ToDexButton";
            this.ToDexButton.Size = new System.Drawing.Size(101, 23);
            this.ToDexButton.TabIndex = 11;
            this.ToDexButton.Text = "ToDex";
            this.ToDexButton.UseVisualStyleBackColor = true;
            this.ToDexButton.Click += new System.EventHandler(this.ToDexButton_Click);
            // 
            // KernelDumperButton
            // 
            this.KernelDumperButton.Location = new System.Drawing.Point(6, 65);
            this.KernelDumperButton.Name = "KernelDumperButton";
            this.KernelDumperButton.Size = new System.Drawing.Size(101, 23);
            this.KernelDumperButton.TabIndex = 12;
            this.KernelDumperButton.Text = "Kernel Dumper";
            this.KernelDumperButton.UseVisualStyleBackColor = true;
            this.KernelDumperButton.Click += new System.EventHandler(this.KernelDumperButton_Click);
            // 
            // PermanentUartButton
            // 
            this.PermanentUartButton.Location = new System.Drawing.Point(654, 108);
            this.PermanentUartButton.Name = "PermanentUartButton";
            this.PermanentUartButton.Size = new System.Drawing.Size(101, 23);
            this.PermanentUartButton.TabIndex = 15;
            this.PermanentUartButton.Text = "Permanent Uart";
            this.PermanentUartButton.UseVisualStyleBackColor = true;
            this.PermanentUartButton.Click += new System.EventHandler(this.PermanentUartButton_Click);
            // 
            // App2USBButton
            // 
            this.App2USBButton.Location = new System.Drawing.Point(6, 14);
            this.App2USBButton.Name = "App2USBButton";
            this.App2USBButton.Size = new System.Drawing.Size(101, 23);
            this.App2USBButton.TabIndex = 16;
            this.App2USBButton.Text = "App2USB";
            this.App2USBButton.UseVisualStyleBackColor = true;
            this.App2USBButton.Click += new System.EventHandler(this.App2USBButton_Click);
            // 
            // AppDumperButton
            // 
            this.AppDumperButton.Location = new System.Drawing.Point(109, 39);
            this.AppDumperButton.Name = "AppDumperButton";
            this.AppDumperButton.Size = new System.Drawing.Size(101, 23);
            this.AppDumperButton.TabIndex = 17;
            this.AppDumperButton.Text = "App Dumper";
            this.AppDumperButton.UseVisualStyleBackColor = true;
            this.AppDumperButton.Click += new System.EventHandler(this.AppDumperButton_Click);
            // 
            // RifRenamerButton
            // 
            this.RifRenamerButton.Location = new System.Drawing.Point(654, 77);
            this.RifRenamerButton.Name = "RifRenamerButton";
            this.RifRenamerButton.Size = new System.Drawing.Size(101, 23);
            this.RifRenamerButton.TabIndex = 18;
            this.RifRenamerButton.Text = "Rif Renamer";
            this.RifRenamerButton.UseVisualStyleBackColor = true;
            this.RifRenamerButton.Click += new System.EventHandler(this.RifRenamerButton_Click);
            // 
            // GameDumperButton
            // 
            this.GameDumperButton.Location = new System.Drawing.Point(6, 39);
            this.GameDumperButton.Name = "GameDumperButton";
            this.GameDumperButton.Size = new System.Drawing.Size(101, 23);
            this.GameDumperButton.TabIndex = 19;
            this.GameDumperButton.Text = "Game Dumper";
            this.GameDumperButton.UseVisualStyleBackColor = true;
            this.GameDumperButton.Click += new System.EventHandler(this.GameDumperButton_Click);
            // 
            // EnableBrowserButton
            // 
            this.EnableBrowserButton.Location = new System.Drawing.Point(335, 108);
            this.EnableBrowserButton.Name = "EnableBrowserButton";
            this.EnableBrowserButton.Size = new System.Drawing.Size(101, 23);
            this.EnableBrowserButton.TabIndex = 20;
            this.EnableBrowserButton.Text = "Enable Browser";
            this.EnableBrowserButton.UseVisualStyleBackColor = true;
            this.EnableBrowserButton.Click += new System.EventHandler(this.EnableBrowserButton_Click);
            // 
            // FakeUSBButton
            // 
            this.FakeUSBButton.Location = new System.Drawing.Point(551, 108);
            this.FakeUSBButton.Name = "FakeUSBButton";
            this.FakeUSBButton.Size = new System.Drawing.Size(101, 23);
            this.FakeUSBButton.TabIndex = 21;
            this.FakeUSBButton.Text = "FakeUSB";
            this.FakeUSBButton.UseVisualStyleBackColor = true;
            this.FakeUSBButton.Click += new System.EventHandler(this.FakeUSBButton_Click);
            // 
            // DisableASLRButton
            // 
            this.DisableASLRButton.Location = new System.Drawing.Point(438, 108);
            this.DisableASLRButton.Name = "DisableASLRButton";
            this.DisableASLRButton.Size = new System.Drawing.Size(101, 23);
            this.DisableASLRButton.TabIndex = 22;
            this.DisableASLRButton.Text = "Disable ASLR";
            this.DisableASLRButton.UseVisualStyleBackColor = true;
            this.DisableASLRButton.Click += new System.EventHandler(this.DisableASLRButton_Click);
            // 
            // ModuleDumperButton
            // 
            this.ModuleDumperButton.Location = new System.Drawing.Point(109, 14);
            this.ModuleDumperButton.Name = "ModuleDumperButton";
            this.ModuleDumperButton.Size = new System.Drawing.Size(101, 23);
            this.ModuleDumperButton.TabIndex = 26;
            this.ModuleDumperButton.Text = "Module Dumper";
            this.ModuleDumperButton.UseVisualStyleBackColor = true;
            this.ModuleDumperButton.Click += new System.EventHandler(this.ModuleDumperButton_Click);
            // 
            // FanSpeedButton
            // 
            this.FanSpeedButton.Location = new System.Drawing.Point(109, 89);
            this.FanSpeedButton.Name = "FanSpeedButton";
            this.FanSpeedButton.Size = new System.Drawing.Size(101, 23);
            this.FanSpeedButton.TabIndex = 27;
            this.FanSpeedButton.Text = "Fan Speed";
            this.FanSpeedButton.UseVisualStyleBackColor = true;
            this.FanSpeedButton.Click += new System.EventHandler(this.FanSpeedButton_Click);
            // 
            // LinuxButton
            // 
            this.LinuxButton.Enabled = false;
            this.LinuxButton.Location = new System.Drawing.Point(4, 14);
            this.LinuxButton.Name = "LinuxButton";
            this.LinuxButton.Size = new System.Drawing.Size(101, 23);
            this.LinuxButton.TabIndex = 28;
            this.LinuxButton.Text = "Linux";
            this.LinuxButton.UseVisualStyleBackColor = true;
            this.LinuxButton.Click += new System.EventHandler(this.LinuxButton_Click);
            // 
            // FanSpeedCombo
            // 
            this.FanSpeedCombo.FormattingEnabled = true;
            this.FanSpeedCombo.Items.AddRange(new object[] {
            "Default",
            "80",
            "75",
            "70",
            "65",
            "60",
            "55",
            "50"});
            this.FanSpeedCombo.Location = new System.Drawing.Point(212, 90);
            this.FanSpeedCombo.Name = "FanSpeedCombo";
            this.FanSpeedCombo.Size = new System.Drawing.Size(101, 21);
            this.FanSpeedCombo.TabIndex = 29;
            this.FanSpeedCombo.Text = "Default";
            // 
            // LinuxCombo
            // 
            this.LinuxCombo.Enabled = false;
            this.LinuxCombo.FormattingEnabled = true;
            this.LinuxCombo.Items.AddRange(new object[] {
            "1GB",
            "2GB",
            "3GB",
            "4GB",
            "5GB"});
            this.LinuxCombo.Location = new System.Drawing.Point(107, 15);
            this.LinuxCombo.Name = "LinuxCombo";
            this.LinuxCombo.Size = new System.Drawing.Size(101, 21);
            this.LinuxCombo.TabIndex = 30;
            this.LinuxCombo.Text = "1GB";
            // 
            // LinuxEnable
            // 
            this.LinuxEnable.AutoSize = true;
            this.LinuxEnable.Location = new System.Drawing.Point(74, 41);
            this.LinuxEnable.Name = "LinuxEnable";
            this.LinuxEnable.Size = new System.Drawing.Size(61, 17);
            this.LinuxEnable.TabIndex = 31;
            this.LinuxEnable.Text = "Enable";
            this.LinuxEnable.UseVisualStyleBackColor = true;
            this.LinuxEnable.CheckedChanged += new System.EventHandler(this.LinuxEnable_CheckedChanged);
            // 
            // LinuxGroup
            // 
            this.LinuxGroup.Controls.Add(this.LinuxEnable);
            this.LinuxGroup.Controls.Add(this.LinuxCombo);
            this.LinuxGroup.Controls.Add(this.LinuxButton);
            this.LinuxGroup.Location = new System.Drawing.Point(547, 13);
            this.LinuxGroup.Name = "LinuxGroup";
            this.LinuxGroup.Size = new System.Drawing.Size(213, 62);
            this.LinuxGroup.TabIndex = 32;
            this.LinuxGroup.TabStop = false;
            this.LinuxGroup.Text = "Linux";
            // 
            // MainGB
            // 
            this.MainGB.Controls.Add(this.FTPButton);
            this.MainGB.Controls.Add(this.GoldHenButton);
            this.MainGB.Controls.Add(this.PS4DebugButton);
            this.MainGB.Controls.Add(this.FanSpeedCombo);
            this.MainGB.Controls.Add(this.WebRTEButton);
            this.MainGB.Controls.Add(this.FanSpeedButton);
            this.MainGB.Controls.Add(this.OrbisToolboxButton);
            this.MainGB.Controls.Add(this.DisableUpdates);
            this.MainGB.Controls.Add(this.EnableUpdates);
            this.MainGB.Controls.Add(this.HistoryBlockerButton);
            this.MainGB.Controls.Add(this.DBBackupButton);
            this.MainGB.Controls.Add(this.DBRestoreButton);
            this.MainGB.Location = new System.Drawing.Point(8, 13);
            this.MainGB.Name = "MainGB";
            this.MainGB.Size = new System.Drawing.Size(319, 119);
            this.MainGB.TabIndex = 33;
            this.MainGB.TabStop = false;
            this.MainGB.Text = "Main";
            // 
            // FTPButton
            // 
            this.FTPButton.Location = new System.Drawing.Point(6, 89);
            this.FTPButton.Name = "FTPButton";
            this.FTPButton.Size = new System.Drawing.Size(101, 23);
            this.FTPButton.TabIndex = 30;
            this.FTPButton.Text = "FTP";
            this.FTPButton.UseVisualStyleBackColor = true;
            this.FTPButton.Click += new System.EventHandler(this.FTPButton_Click);
            // 
            // DumperGB
            // 
            this.DumperGB.Controls.Add(this.App2USBButton);
            this.DumperGB.Controls.Add(this.AppDumperButton);
            this.DumperGB.Controls.Add(this.KernelDumperButton);
            this.DumperGB.Controls.Add(this.ModuleDumperButton);
            this.DumperGB.Controls.Add(this.GameDumperButton);
            this.DumperGB.Location = new System.Drawing.Point(329, 13);
            this.DumperGB.Name = "DumperGB";
            this.DumperGB.Size = new System.Drawing.Size(216, 94);
            this.DumperGB.TabIndex = 34;
            this.DumperGB.TabStop = false;
            this.DumperGB.Text = "Dumpers";
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 219);
            this.Controls.Add(this.PayloadGroupB);
            this.Controls.Add(this.InjectPayload_Button);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.SelectPayload_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.CurrentStatus_Label);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.IP_TextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 258);
            this.Name = "Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payload AIO";
            this.Load += new System.EventHandler(this.Tool_Load);
            this.PayloadGroupB.ResumeLayout(false);
            this.LinuxGroup.ResumeLayout(false);
            this.LinuxGroup.PerformLayout();
            this.MainGB.ResumeLayout(false);
            this.DumperGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x0400002E RID: 46
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000033 RID: 51
        private global::System.Windows.Forms.TextBox Port_TextBox;

        // Token: 0x04000034 RID: 52
        private global::System.Windows.Forms.TextBox IP_TextBox;

        // Token: 0x04000036 RID: 54
        private global::System.Windows.Forms.Button InjectPayload_Button;

        // Token: 0x04000037 RID: 55
        private global::System.Windows.Forms.Button SelectPayload_Button;

        // Token: 0x04000038 RID: 56
        private global::System.Windows.Forms.Label CurrentStatus_Label;

        // Token: 0x04000039 RID: 57
        private global::System.Windows.Forms.OpenFileDialog OpenPayloadDialog;

        // Token: 0x0400003A RID: 58
        private global::System.Windows.Forms.Label Status_Label;

        // Token: 0x04000041 RID: 65
        private global::System.ComponentModel.BackgroundWorker Payload_BGWorker;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button GoldHenButton;
        private System.Windows.Forms.GroupBox PayloadGroupB;
        private System.Windows.Forms.Button PS4DebugButton;
        private System.Windows.Forms.Button LinuxButton;
        private System.Windows.Forms.Button FanSpeedButton;
        private System.Windows.Forms.Button ModuleDumperButton;
        private System.Windows.Forms.Button DisableASLRButton;
        private System.Windows.Forms.Button FakeUSBButton;
        private System.Windows.Forms.Button EnableBrowserButton;
        private System.Windows.Forms.Button GameDumperButton;
        private System.Windows.Forms.Button RifRenamerButton;
        private System.Windows.Forms.Button AppDumperButton;
        private System.Windows.Forms.Button App2USBButton;
        private System.Windows.Forms.Button PermanentUartButton;
        private System.Windows.Forms.Button KernelDumperButton;
        private System.Windows.Forms.Button ToDexButton;
        private System.Windows.Forms.Button DBRestoreButton;
        private System.Windows.Forms.Button DBBackupButton;
        private System.Windows.Forms.Button HistoryBlockerButton;
        private System.Windows.Forms.Button EnableUpdates;
        private System.Windows.Forms.Button OrbisToolboxButton;
        private System.Windows.Forms.Button DisableUpdates;
        private System.Windows.Forms.Button WebRTEButton;
        private System.Windows.Forms.ComboBox LinuxCombo;
        private System.Windows.Forms.ComboBox FanSpeedCombo;
        private System.Windows.Forms.GroupBox LinuxGroup;
        private System.Windows.Forms.CheckBox LinuxEnable;
        private System.Windows.Forms.GroupBox MainGB;
        private System.Windows.Forms.Button FTPButton;
        private System.Windows.Forms.GroupBox DumperGB;
    }
}
