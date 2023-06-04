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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            Port_TextBox = new System.Windows.Forms.TextBox();
            IP_TextBox = new System.Windows.Forms.TextBox();
            InjectPayload_Button = new System.Windows.Forms.Button();
            SelectPayload_Button = new System.Windows.Forms.Button();
            CurrentStatus_Label = new System.Windows.Forms.Label();
            OpenPayloadDialog = new System.Windows.Forms.OpenFileDialog();
            Status_Label = new System.Windows.Forms.Label();
            Payload_BGWorker = new System.ComponentModel.BackgroundWorker();
            FilePathBox = new System.Windows.Forms.TextBox();
            GoldHenButton = new System.Windows.Forms.Button();
            PayloadGroupB = new System.Windows.Forms.GroupBox();
            DisableToDexButton = new System.Windows.Forms.Button();
            App2USBButton = new System.Windows.Forms.Button();
            DumperGB = new System.Windows.Forms.GroupBox();
            AppDumperButton = new System.Windows.Forms.Button();
            KernelDumperButton = new System.Windows.Forms.Button();
            ModuleDumperButton = new System.Windows.Forms.Button();
            GameDumperButton = new System.Windows.Forms.Button();
            MainGB = new System.Windows.Forms.GroupBox();
            FTPButton = new System.Windows.Forms.Button();
            PS4DebugButton = new System.Windows.Forms.Button();
            FanSpeedCombo = new System.Windows.Forms.ComboBox();
            WebRTEButton = new System.Windows.Forms.Button();
            FanSpeedButton = new System.Windows.Forms.Button();
            OrbisToolboxButton = new System.Windows.Forms.Button();
            DisableUpdates = new System.Windows.Forms.Button();
            EnableUpdates = new System.Windows.Forms.Button();
            HistoryBlockerButton = new System.Windows.Forms.Button();
            DBBackupButton = new System.Windows.Forms.Button();
            DBRestoreButton = new System.Windows.Forms.Button();
            LinuxGroup = new System.Windows.Forms.GroupBox();
            LinuxEnable = new System.Windows.Forms.CheckBox();
            LinuxCombo = new System.Windows.Forms.ComboBox();
            LinuxButton = new System.Windows.Forms.Button();
            DisableASLRButton = new System.Windows.Forms.Button();
            FakeUSBButton = new System.Windows.Forms.Button();
            EnableBrowserButton = new System.Windows.Forms.Button();
            RifRenamerButton = new System.Windows.Forms.Button();
            PermanentUartButton = new System.Windows.Forms.Button();
            ToDexButton = new System.Windows.Forms.Button();
            DeConPS4Debug = new System.Windows.Forms.Button();
            ConnectionTestTimer = new System.Windows.Forms.Timer(components);
            PayloadGroupB.SuspendLayout();
            DumperGB.SuspendLayout();
            MainGB.SuspendLayout();
            LinuxGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Port_TextBox
            // 
            Port_TextBox.Location = new System.Drawing.Point(113, 31);
            Port_TextBox.Multiline = true;
            Port_TextBox.Name = "Port_TextBox";
            Port_TextBox.Size = new System.Drawing.Size(44, 20);
            Port_TextBox.TabIndex = 0;
            Port_TextBox.TabStop = false;
            Port_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Port_TextBox.TextChanged += Port_TextBox_TextChanged;
            // 
            // IP_TextBox
            // 
            IP_TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            IP_TextBox.Location = new System.Drawing.Point(6, 31);
            IP_TextBox.Multiline = true;
            IP_TextBox.Name = "IP_TextBox";
            IP_TextBox.Size = new System.Drawing.Size(105, 20);
            IP_TextBox.TabIndex = 0;
            IP_TextBox.TabStop = false;
            IP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            IP_TextBox.TextChanged += IP_TextBox_TextChanged;
            // 
            // InjectPayload_Button
            // 
            InjectPayload_Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            InjectPayload_Button.Location = new System.Drawing.Point(633, 30);
            InjectPayload_Button.Name = "InjectPayload_Button";
            InjectPayload_Button.Size = new System.Drawing.Size(140, 23);
            InjectPayload_Button.TabIndex = 0;
            InjectPayload_Button.TabStop = false;
            InjectPayload_Button.Text = "Inject Payload";
            InjectPayload_Button.UseVisualStyleBackColor = true;
            InjectPayload_Button.Click += InjectPayload_Button_Click;
            // 
            // SelectPayload_Button
            // 
            SelectPayload_Button.Location = new System.Drawing.Point(487, 30);
            SelectPayload_Button.Name = "SelectPayload_Button";
            SelectPayload_Button.Size = new System.Drawing.Size(140, 23);
            SelectPayload_Button.TabIndex = 0;
            SelectPayload_Button.TabStop = false;
            SelectPayload_Button.Text = "Select Payload";
            SelectPayload_Button.UseVisualStyleBackColor = true;
            SelectPayload_Button.Click += SelectPayload_Button_Click;
            // 
            // CurrentStatus_Label
            // 
            CurrentStatus_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            CurrentStatus_Label.AutoSize = true;
            CurrentStatus_Label.Location = new System.Drawing.Point(44, 200);
            CurrentStatus_Label.Name = "CurrentStatus_Label";
            CurrentStatus_Label.Size = new System.Drawing.Size(0, 13);
            CurrentStatus_Label.TabIndex = 0;
            // 
            // OpenPayloadDialog
            // 
            OpenPayloadDialog.Filter = "BIN file (*.BIN)|*.BIN";
            // 
            // Status_Label
            // 
            Status_Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Status_Label.AutoSize = true;
            Status_Label.Location = new System.Drawing.Point(4, 200);
            Status_Label.Name = "Status_Label";
            Status_Label.Size = new System.Drawing.Size(42, 13);
            Status_Label.TabIndex = 0;
            Status_Label.Text = "Status:";
            // 
            // Payload_BGWorker
            // 
            Payload_BGWorker.DoWork += Payload_BGWorker_DoWork;
            // 
            // FilePathBox
            // 
            FilePathBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FilePathBox.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FilePathBox.Location = new System.Drawing.Point(6, 5);
            FilePathBox.MaxLength = 2000000000;
            FilePathBox.Multiline = true;
            FilePathBox.Name = "FilePathBox";
            FilePathBox.ReadOnly = true;
            FilePathBox.Size = new System.Drawing.Size(767, 20);
            FilePathBox.TabIndex = 1;
            FilePathBox.TabStop = false;
            // 
            // GoldHenButton
            // 
            GoldHenButton.Location = new System.Drawing.Point(6, 14);
            GoldHenButton.Name = "GoldHenButton";
            GoldHenButton.Size = new System.Drawing.Size(101, 23);
            GoldHenButton.TabIndex = 2;
            GoldHenButton.Text = "GoldHen";
            GoldHenButton.UseVisualStyleBackColor = true;
            GoldHenButton.Click += GoldHenButton_Click;
            // 
            // PayloadGroupB
            // 
            PayloadGroupB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PayloadGroupB.Controls.Add(DisableToDexButton);
            PayloadGroupB.Controls.Add(App2USBButton);
            PayloadGroupB.Controls.Add(DumperGB);
            PayloadGroupB.Controls.Add(MainGB);
            PayloadGroupB.Controls.Add(LinuxGroup);
            PayloadGroupB.Controls.Add(DisableASLRButton);
            PayloadGroupB.Controls.Add(FakeUSBButton);
            PayloadGroupB.Controls.Add(EnableBrowserButton);
            PayloadGroupB.Controls.Add(RifRenamerButton);
            PayloadGroupB.Controls.Add(PermanentUartButton);
            PayloadGroupB.Controls.Add(ToDexButton);
            PayloadGroupB.Location = new System.Drawing.Point(6, 57);
            PayloadGroupB.Name = "PayloadGroupB";
            PayloadGroupB.Size = new System.Drawing.Size(767, 140);
            PayloadGroupB.TabIndex = 3;
            PayloadGroupB.TabStop = false;
            PayloadGroupB.Text = "Payloads";
            // 
            // DisableToDexButton
            // 
            DisableToDexButton.Location = new System.Drawing.Point(438, 109);
            DisableToDexButton.Name = "DisableToDexButton";
            DisableToDexButton.Size = new System.Drawing.Size(101, 23);
            DisableToDexButton.TabIndex = 35;
            DisableToDexButton.Text = "Disable ToDex";
            DisableToDexButton.UseVisualStyleBackColor = true;
            DisableToDexButton.Click += DisableToDexButton_Click;
            // 
            // App2USBButton
            // 
            App2USBButton.Location = new System.Drawing.Point(551, 84);
            App2USBButton.Name = "App2USBButton";
            App2USBButton.Size = new System.Drawing.Size(101, 23);
            App2USBButton.TabIndex = 16;
            App2USBButton.Text = "App2USB";
            App2USBButton.UseVisualStyleBackColor = true;
            App2USBButton.Click += App2USBButton_Click;
            // 
            // DumperGB
            // 
            DumperGB.Controls.Add(AppDumperButton);
            DumperGB.Controls.Add(KernelDumperButton);
            DumperGB.Controls.Add(ModuleDumperButton);
            DumperGB.Controls.Add(GameDumperButton);
            DumperGB.Location = new System.Drawing.Point(329, 13);
            DumperGB.Name = "DumperGB";
            DumperGB.Size = new System.Drawing.Size(216, 69);
            DumperGB.TabIndex = 34;
            DumperGB.TabStop = false;
            DumperGB.Text = "Dumpers";
            // 
            // AppDumperButton
            // 
            AppDumperButton.Location = new System.Drawing.Point(109, 14);
            AppDumperButton.Name = "AppDumperButton";
            AppDumperButton.Size = new System.Drawing.Size(101, 23);
            AppDumperButton.TabIndex = 17;
            AppDumperButton.Text = "App Dumper";
            AppDumperButton.UseVisualStyleBackColor = true;
            AppDumperButton.Click += AppDumperButton_Click;
            // 
            // KernelDumperButton
            // 
            KernelDumperButton.Location = new System.Drawing.Point(6, 40);
            KernelDumperButton.Name = "KernelDumperButton";
            KernelDumperButton.Size = new System.Drawing.Size(101, 23);
            KernelDumperButton.TabIndex = 12;
            KernelDumperButton.Text = "Kernel Dumper";
            KernelDumperButton.UseVisualStyleBackColor = true;
            KernelDumperButton.Click += KernelDumperButton_Click;
            // 
            // ModuleDumperButton
            // 
            ModuleDumperButton.Location = new System.Drawing.Point(111, 40);
            ModuleDumperButton.Name = "ModuleDumperButton";
            ModuleDumperButton.Size = new System.Drawing.Size(101, 23);
            ModuleDumperButton.TabIndex = 26;
            ModuleDumperButton.Text = "Module Dumper";
            ModuleDumperButton.UseVisualStyleBackColor = true;
            ModuleDumperButton.Click += ModuleDumperButton_Click;
            // 
            // GameDumperButton
            // 
            GameDumperButton.Location = new System.Drawing.Point(6, 14);
            GameDumperButton.Name = "GameDumperButton";
            GameDumperButton.Size = new System.Drawing.Size(101, 23);
            GameDumperButton.TabIndex = 19;
            GameDumperButton.Text = "Game Dumper";
            GameDumperButton.UseVisualStyleBackColor = true;
            GameDumperButton.Click += GameDumperButton_Click;
            // 
            // MainGB
            // 
            MainGB.Controls.Add(FTPButton);
            MainGB.Controls.Add(GoldHenButton);
            MainGB.Controls.Add(PS4DebugButton);
            MainGB.Controls.Add(FanSpeedCombo);
            MainGB.Controls.Add(WebRTEButton);
            MainGB.Controls.Add(FanSpeedButton);
            MainGB.Controls.Add(OrbisToolboxButton);
            MainGB.Controls.Add(DisableUpdates);
            MainGB.Controls.Add(EnableUpdates);
            MainGB.Controls.Add(HistoryBlockerButton);
            MainGB.Controls.Add(DBBackupButton);
            MainGB.Controls.Add(DBRestoreButton);
            MainGB.Location = new System.Drawing.Point(8, 13);
            MainGB.Name = "MainGB";
            MainGB.Size = new System.Drawing.Size(319, 119);
            MainGB.TabIndex = 33;
            MainGB.TabStop = false;
            MainGB.Text = "Main";
            // 
            // FTPButton
            // 
            FTPButton.Location = new System.Drawing.Point(6, 89);
            FTPButton.Name = "FTPButton";
            FTPButton.Size = new System.Drawing.Size(101, 23);
            FTPButton.TabIndex = 30;
            FTPButton.Text = "FTP";
            FTPButton.UseVisualStyleBackColor = true;
            FTPButton.Click += FTPButton_Click;
            // 
            // PS4DebugButton
            // 
            PS4DebugButton.Location = new System.Drawing.Point(109, 14);
            PS4DebugButton.Name = "PS4DebugButton";
            PS4DebugButton.Size = new System.Drawing.Size(101, 23);
            PS4DebugButton.TabIndex = 3;
            PS4DebugButton.Text = "PS4Debug";
            PS4DebugButton.UseVisualStyleBackColor = true;
            PS4DebugButton.Click += PS4DebugButton_Click;
            // 
            // FanSpeedCombo
            // 
            FanSpeedCombo.FormattingEnabled = true;
            FanSpeedCombo.Items.AddRange(new object[] { "Default", "80", "75", "70", "65", "60", "55", "50" });
            FanSpeedCombo.Location = new System.Drawing.Point(212, 90);
            FanSpeedCombo.Name = "FanSpeedCombo";
            FanSpeedCombo.Size = new System.Drawing.Size(101, 21);
            FanSpeedCombo.TabIndex = 29;
            FanSpeedCombo.Text = "Default";
            // 
            // WebRTEButton
            // 
            WebRTEButton.Location = new System.Drawing.Point(212, 14);
            WebRTEButton.Name = "WebRTEButton";
            WebRTEButton.Size = new System.Drawing.Size(101, 23);
            WebRTEButton.TabIndex = 4;
            WebRTEButton.Text = "WebRTE";
            WebRTEButton.UseVisualStyleBackColor = true;
            WebRTEButton.Click += WebRTEButton_Click;
            // 
            // FanSpeedButton
            // 
            FanSpeedButton.Location = new System.Drawing.Point(109, 89);
            FanSpeedButton.Name = "FanSpeedButton";
            FanSpeedButton.Size = new System.Drawing.Size(101, 23);
            FanSpeedButton.TabIndex = 27;
            FanSpeedButton.Text = "Fan Speed";
            FanSpeedButton.UseVisualStyleBackColor = true;
            FanSpeedButton.Click += FanSpeedButton_Click;
            // 
            // OrbisToolboxButton
            // 
            OrbisToolboxButton.Location = new System.Drawing.Point(6, 39);
            OrbisToolboxButton.Name = "OrbisToolboxButton";
            OrbisToolboxButton.Size = new System.Drawing.Size(101, 23);
            OrbisToolboxButton.TabIndex = 6;
            OrbisToolboxButton.Text = "Orbis Toolbox";
            OrbisToolboxButton.UseVisualStyleBackColor = true;
            OrbisToolboxButton.Click += OrbisToolboxButton_Click;
            // 
            // DisableUpdates
            // 
            DisableUpdates.Location = new System.Drawing.Point(109, 39);
            DisableUpdates.Name = "DisableUpdates";
            DisableUpdates.Size = new System.Drawing.Size(101, 23);
            DisableUpdates.TabIndex = 5;
            DisableUpdates.Text = "Disable Updates";
            DisableUpdates.UseVisualStyleBackColor = true;
            DisableUpdates.Click += DisableUpdates_Click;
            // 
            // EnableUpdates
            // 
            EnableUpdates.Location = new System.Drawing.Point(212, 39);
            EnableUpdates.Name = "EnableUpdates";
            EnableUpdates.Size = new System.Drawing.Size(101, 23);
            EnableUpdates.TabIndex = 7;
            EnableUpdates.Text = "Enable Updates";
            EnableUpdates.UseVisualStyleBackColor = true;
            EnableUpdates.Click += EnableUpdates_Click;
            // 
            // HistoryBlockerButton
            // 
            HistoryBlockerButton.Location = new System.Drawing.Point(6, 64);
            HistoryBlockerButton.Name = "HistoryBlockerButton";
            HistoryBlockerButton.Size = new System.Drawing.Size(101, 23);
            HistoryBlockerButton.TabIndex = 8;
            HistoryBlockerButton.Text = "History Blocker";
            HistoryBlockerButton.UseVisualStyleBackColor = true;
            HistoryBlockerButton.Click += HistoryBlockerButton_Click;
            // 
            // DBBackupButton
            // 
            DBBackupButton.Location = new System.Drawing.Point(109, 64);
            DBBackupButton.Name = "DBBackupButton";
            DBBackupButton.Size = new System.Drawing.Size(101, 23);
            DBBackupButton.TabIndex = 9;
            DBBackupButton.Text = "DB Backup";
            DBBackupButton.UseVisualStyleBackColor = true;
            DBBackupButton.Click += DBBackupButton_Click;
            // 
            // DBRestoreButton
            // 
            DBRestoreButton.Location = new System.Drawing.Point(212, 64);
            DBRestoreButton.Name = "DBRestoreButton";
            DBRestoreButton.Size = new System.Drawing.Size(101, 23);
            DBRestoreButton.TabIndex = 10;
            DBRestoreButton.Text = "DB Restore";
            DBRestoreButton.UseVisualStyleBackColor = true;
            DBRestoreButton.Click += DBRestoreButton_Click;
            // 
            // LinuxGroup
            // 
            LinuxGroup.Controls.Add(LinuxEnable);
            LinuxGroup.Controls.Add(LinuxCombo);
            LinuxGroup.Controls.Add(LinuxButton);
            LinuxGroup.Location = new System.Drawing.Point(547, 13);
            LinuxGroup.Name = "LinuxGroup";
            LinuxGroup.Size = new System.Drawing.Size(213, 69);
            LinuxGroup.TabIndex = 32;
            LinuxGroup.TabStop = false;
            LinuxGroup.Text = "Linux";
            // 
            // LinuxEnable
            // 
            LinuxEnable.AutoSize = true;
            LinuxEnable.Location = new System.Drawing.Point(74, 45);
            LinuxEnable.Name = "LinuxEnable";
            LinuxEnable.Size = new System.Drawing.Size(61, 17);
            LinuxEnable.TabIndex = 31;
            LinuxEnable.Text = "Enable";
            LinuxEnable.UseVisualStyleBackColor = true;
            LinuxEnable.CheckedChanged += LinuxEnable_CheckedChanged;
            // 
            // LinuxCombo
            // 
            LinuxCombo.Enabled = false;
            LinuxCombo.FormattingEnabled = true;
            LinuxCombo.Items.AddRange(new object[] { "1GB", "2GB", "3GB", "4GB", "5GB" });
            LinuxCombo.Location = new System.Drawing.Point(107, 15);
            LinuxCombo.Name = "LinuxCombo";
            LinuxCombo.Size = new System.Drawing.Size(101, 21);
            LinuxCombo.TabIndex = 30;
            LinuxCombo.Text = "1GB";
            // 
            // LinuxButton
            // 
            LinuxButton.Enabled = false;
            LinuxButton.Location = new System.Drawing.Point(4, 14);
            LinuxButton.Name = "LinuxButton";
            LinuxButton.Size = new System.Drawing.Size(101, 23);
            LinuxButton.TabIndex = 28;
            LinuxButton.Text = "Linux";
            LinuxButton.UseVisualStyleBackColor = true;
            LinuxButton.Click += LinuxButton_Click;
            // 
            // DisableASLRButton
            // 
            DisableASLRButton.Location = new System.Drawing.Point(438, 84);
            DisableASLRButton.Name = "DisableASLRButton";
            DisableASLRButton.Size = new System.Drawing.Size(101, 23);
            DisableASLRButton.TabIndex = 22;
            DisableASLRButton.Text = "Disable ASLR";
            DisableASLRButton.UseVisualStyleBackColor = true;
            DisableASLRButton.Click += DisableASLRButton_Click;
            // 
            // FakeUSBButton
            // 
            FakeUSBButton.Location = new System.Drawing.Point(551, 109);
            FakeUSBButton.Name = "FakeUSBButton";
            FakeUSBButton.Size = new System.Drawing.Size(101, 23);
            FakeUSBButton.TabIndex = 21;
            FakeUSBButton.Text = "FakeUSB";
            FakeUSBButton.UseVisualStyleBackColor = true;
            FakeUSBButton.Click += FakeUSBButton_Click;
            // 
            // EnableBrowserButton
            // 
            EnableBrowserButton.Location = new System.Drawing.Point(335, 84);
            EnableBrowserButton.Name = "EnableBrowserButton";
            EnableBrowserButton.Size = new System.Drawing.Size(101, 23);
            EnableBrowserButton.TabIndex = 20;
            EnableBrowserButton.Text = "Enable Browser";
            EnableBrowserButton.UseVisualStyleBackColor = true;
            EnableBrowserButton.Click += EnableBrowserButton_Click;
            // 
            // RifRenamerButton
            // 
            RifRenamerButton.Location = new System.Drawing.Point(654, 84);
            RifRenamerButton.Name = "RifRenamerButton";
            RifRenamerButton.Size = new System.Drawing.Size(101, 23);
            RifRenamerButton.TabIndex = 18;
            RifRenamerButton.Text = "Rif Renamer";
            RifRenamerButton.UseVisualStyleBackColor = true;
            RifRenamerButton.Click += RifRenamerButton_Click;
            // 
            // PermanentUartButton
            // 
            PermanentUartButton.Location = new System.Drawing.Point(654, 109);
            PermanentUartButton.Name = "PermanentUartButton";
            PermanentUartButton.Size = new System.Drawing.Size(101, 23);
            PermanentUartButton.TabIndex = 15;
            PermanentUartButton.Text = "Permanent Uart";
            PermanentUartButton.UseVisualStyleBackColor = true;
            PermanentUartButton.Click += PermanentUartButton_Click;
            // 
            // ToDexButton
            // 
            ToDexButton.Location = new System.Drawing.Point(335, 109);
            ToDexButton.Name = "ToDexButton";
            ToDexButton.Size = new System.Drawing.Size(101, 23);
            ToDexButton.TabIndex = 11;
            ToDexButton.Text = "ToDex";
            ToDexButton.UseVisualStyleBackColor = true;
            ToDexButton.Click += ToDexButton_Click;
            // 
            // DeConPS4Debug
            // 
            DeConPS4Debug.Location = new System.Drawing.Point(159, 30);
            DeConPS4Debug.Name = "DeConPS4Debug";
            DeConPS4Debug.Size = new System.Drawing.Size(140, 23);
            DeConPS4Debug.TabIndex = 4;
            DeConPS4Debug.TabStop = false;
            DeConPS4Debug.Text = "Connect to PS4Debug";
            DeConPS4Debug.UseVisualStyleBackColor = true;
            DeConPS4Debug.Visible = false;
            DeConPS4Debug.Click += DeConPS4Debug_Click;
            // 
            // ConnectionTestTimer
            // 
            ConnectionTestTimer.Interval = 500;
            ConnectionTestTimer.Tick += ConnectionTestTimer_Tick;
            // 
            // Tool
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(779, 219);
            Controls.Add(DeConPS4Debug);
            Controls.Add(PayloadGroupB);
            Controls.Add(InjectPayload_Button);
            Controls.Add(FilePathBox);
            Controls.Add(SelectPayload_Button);
            Controls.Add(Status_Label);
            Controls.Add(CurrentStatus_Label);
            Controls.Add(Port_TextBox);
            Controls.Add(IP_TextBox);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(795, 258);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(795, 258);
            Name = "Tool";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PayloadAIO";
            Load += Tool_Load;
            PayloadGroupB.ResumeLayout(false);
            DumperGB.ResumeLayout(false);
            MainGB.ResumeLayout(false);
            LinuxGroup.ResumeLayout(false);
            LinuxGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button DeConPS4Debug;
        private System.Windows.Forms.Timer ConnectionTestTimer;
        private System.Windows.Forms.Button DisableToDexButton;
    }
}
