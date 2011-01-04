namespace SICAT
{
    partial class formConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfiguration));
            this.groupboxFTPSettings = new System.Windows.Forms.GroupBox();
            this.passive_on = new System.Windows.Forms.CheckBox();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textboxPath = new System.Windows.Forms.TextBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxServerAddress = new System.Windows.Forms.TextBox();
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.groupboxHotkey = new System.Windows.Forms.GroupBox();
            this.buttonSetHotkey = new System.Windows.Forms.Button();
            this.labelCurrentHotkey = new System.Windows.Forms.Label();
            this.labelCurrentHotkeyTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxBrowserURL = new System.Windows.Forms.GroupBox();
            this.textboxNote = new System.Windows.Forms.TextBox();
            this.textboxURLToImages = new System.Windows.Forms.TextBox();
            this.labelURLToImages = new System.Windows.Forms.Label();
            this.checkboxEnable = new System.Windows.Forms.CheckBox();
            this.groupboxImageCount = new System.Windows.Forms.GroupBox();
            this.textboxChangeICValue = new System.Windows.Forms.TextBox();
            this.labelChangeICValue = new System.Windows.Forms.Label();
            this.labelImageCount = new System.Windows.Forms.Label();
            this.buttonChangeICValue = new System.Windows.Forms.Button();
            this.labelImageCountTitle = new System.Windows.Forms.Label();
            this.groupboxImageSettings = new System.Windows.Forms.GroupBox();
            this.groupboxCaptureArea = new System.Windows.Forms.GroupBox();
            this.radioButtonActiveForm = new System.Windows.Forms.RadioButton();
            this.radiobuttonAllMonitorsMultiple = new System.Windows.Forms.RadioButton();
            this.radiobuttonAllMonitorsSingle = new System.Windows.Forms.RadioButton();
            this.radiobuttonPrimaryMonitor = new System.Windows.Forms.RadioButton();
            this.groupboxImageType = new System.Windows.Forms.GroupBox();
            this.radiobuttonGIF = new System.Windows.Forms.RadioButton();
            this.radiobuttonBMP = new System.Windows.Forms.RadioButton();
            this.radiobuttonPNG = new System.Windows.Forms.RadioButton();
            this.radiobuttonJPG = new System.Windows.Forms.RadioButton();
            this.groupboxNamePrefix = new System.Windows.Forms.GroupBox();
            this.textboxPrefix = new System.Windows.Forms.TextBox();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.linklabelWebsite = new System.Windows.Forms.LinkLabel();
            this.groupboxFTPSettings.SuspendLayout();
            this.groupboxHotkey.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupboxBrowserURL.SuspendLayout();
            this.groupboxImageCount.SuspendLayout();
            this.groupboxImageSettings.SuspendLayout();
            this.groupboxCaptureArea.SuspendLayout();
            this.groupboxImageType.SuspendLayout();
            this.groupboxNamePrefix.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxFTPSettings
            // 
            this.groupboxFTPSettings.Controls.Add(this.passive_on);
            this.groupboxFTPSettings.Controls.Add(this.textboxPort);
            this.groupboxFTPSettings.Controls.Add(this.labelPort);
            this.groupboxFTPSettings.Controls.Add(this.labelPath);
            this.groupboxFTPSettings.Controls.Add(this.textboxPath);
            this.groupboxFTPSettings.Controls.Add(this.labelConnectionStatus);
            this.groupboxFTPSettings.Controls.Add(this.buttonTestConnection);
            this.groupboxFTPSettings.Controls.Add(this.labelPassword);
            this.groupboxFTPSettings.Controls.Add(this.labelUsername);
            this.groupboxFTPSettings.Controls.Add(this.textboxPassword);
            this.groupboxFTPSettings.Controls.Add(this.textboxUsername);
            this.groupboxFTPSettings.Controls.Add(this.textboxServerAddress);
            this.groupboxFTPSettings.Controls.Add(this.labelServerAddress);
            this.groupboxFTPSettings.Location = new System.Drawing.Point(12, 11);
            this.groupboxFTPSettings.Name = "groupboxFTPSettings";
            this.groupboxFTPSettings.Size = new System.Drawing.Size(268, 134);
            this.groupboxFTPSettings.TabIndex = 0;
            this.groupboxFTPSettings.TabStop = false;
            this.groupboxFTPSettings.Text = "FTP設定";
            this.groupboxFTPSettings.Enter += new System.EventHandler(this.groupboxFTPSettings_Enter);
            // 
            // passive_on
            // 
            this.passive_on.AutoSize = true;
            this.passive_on.Location = new System.Drawing.Point(210, 113);
            this.passive_on.Name = "passive_on";
            this.passive_on.Size = new System.Drawing.Size(54, 16);
            this.passive_on.TabIndex = 3;
            this.passive_on.Text = "PASV";
            this.passive_on.UseVisualStyleBackColor = true;
            // 
            // textboxPort
            // 
            this.textboxPort.Location = new System.Drawing.Point(236, 12);
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(24, 19);
            this.textboxPort.TabIndex = 9;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(204, 15);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(33, 12);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "ポート";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 87);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(84, 12);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "画像転送先パス";
            // 
            // textboxPath
            // 
            this.textboxPath.Location = new System.Drawing.Point(91, 84);
            this.textboxPath.Name = "textboxPath";
            this.textboxPath.Size = new System.Drawing.Size(169, 19);
            this.textboxPath.TabIndex = 4;
            this.textboxPath.Leave += new System.EventHandler(this.textboxPath_Leave);
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(109, 113);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(0, 12);
            this.labelConnectionStatus.TabIndex = 7;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(9, 108);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(64, 21);
            this.buttonTestConnection.TabIndex = 5;
            this.buttonTestConnection.Text = "接続テスト";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 63);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 12);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "パスワード";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(6, 39);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(47, 12);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "ユーザ名";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(91, 60);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(169, 19);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(91, 36);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(169, 19);
            this.textboxUsername.TabIndex = 2;
            // 
            // textboxServerAddress
            // 
            this.textboxServerAddress.Location = new System.Drawing.Point(91, 12);
            this.textboxServerAddress.Name = "textboxServerAddress";
            this.textboxServerAddress.Size = new System.Drawing.Size(107, 19);
            this.textboxServerAddress.TabIndex = 1;
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.AutoSize = true;
            this.labelServerAddress.Location = new System.Drawing.Point(6, 15);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(44, 12);
            this.labelServerAddress.TabIndex = 0;
            this.labelServerAddress.Text = "ホスト名";
            // 
            // groupboxHotkey
            // 
            this.groupboxHotkey.Controls.Add(this.buttonSetHotkey);
            this.groupboxHotkey.Controls.Add(this.labelCurrentHotkey);
            this.groupboxHotkey.Controls.Add(this.labelCurrentHotkeyTitle);
            this.groupboxHotkey.Location = new System.Drawing.Point(12, 264);
            this.groupboxHotkey.Name = "groupboxHotkey";
            this.groupboxHotkey.Size = new System.Drawing.Size(268, 57);
            this.groupboxHotkey.TabIndex = 2;
            this.groupboxHotkey.TabStop = false;
            this.groupboxHotkey.Text = "ホットキーの設定";
            // 
            // buttonSetHotkey
            // 
            this.buttonSetHotkey.Location = new System.Drawing.Point(220, 30);
            this.buttonSetHotkey.Name = "buttonSetHotkey";
            this.buttonSetHotkey.Size = new System.Drawing.Size(40, 21);
            this.buttonSetHotkey.TabIndex = 2;
            this.buttonSetHotkey.Text = "変更";
            this.buttonSetHotkey.UseVisualStyleBackColor = true;
            this.buttonSetHotkey.Click += new System.EventHandler(this.buttonSetHotkey_Click);
            this.buttonSetHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSetHotkey_KeyUp);
            // 
            // labelCurrentHotkey
            // 
            this.labelCurrentHotkey.AutoSize = true;
            this.labelCurrentHotkey.Location = new System.Drawing.Point(93, 15);
            this.labelCurrentHotkey.Name = "labelCurrentHotkey";
            this.labelCurrentHotkey.Size = new System.Drawing.Size(48, 12);
            this.labelCurrentHotkey.TabIndex = 1;
            this.labelCurrentHotkey.Text = "設定なし";
            // 
            // labelCurrentHotkeyTitle
            // 
            this.labelCurrentHotkeyTitle.AutoSize = true;
            this.labelCurrentHotkeyTitle.Location = new System.Drawing.Point(6, 15);
            this.labelCurrentHotkeyTitle.Name = "labelCurrentHotkeyTitle";
            this.labelCurrentHotkeyTitle.Size = new System.Drawing.Size(63, 12);
            this.labelCurrentHotkeyTitle.TabIndex = 0;
            this.labelCurrentHotkeyTitle.Text = "現在の設定";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(403, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 21);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(491, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(61, 21);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SICAT";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.logToolStripMenuItem,
            this.resetSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 98);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.configurationToolStripMenuItem.Text = "設定...";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.logToolStripMenuItem.Text = "ログを見る...";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.resetSettingsToolStripMenuItem.Text = "設定をクリア";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hideToolStripMenuItem.Text = "SICATを終了";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // groupboxBrowserURL
            // 
            this.groupboxBrowserURL.Controls.Add(this.textboxNote);
            this.groupboxBrowserURL.Controls.Add(this.textboxURLToImages);
            this.groupboxBrowserURL.Controls.Add(this.labelURLToImages);
            this.groupboxBrowserURL.Controls.Add(this.checkboxEnable);
            this.groupboxBrowserURL.Location = new System.Drawing.Point(12, 150);
            this.groupboxBrowserURL.Name = "groupboxBrowserURL";
            this.groupboxBrowserURL.Size = new System.Drawing.Size(268, 107);
            this.groupboxBrowserURL.TabIndex = 1;
            this.groupboxBrowserURL.TabStop = false;
            this.groupboxBrowserURL.Text = "画像用URL出力 (オプション)";
            // 
            // textboxNote
            // 
            this.textboxNote.BackColor = System.Drawing.SystemColors.Control;
            this.textboxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxNote.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textboxNote.Location = new System.Drawing.Point(9, 55);
            this.textboxNote.Multiline = true;
            this.textboxNote.Name = "textboxNote";
            this.textboxNote.Size = new System.Drawing.Size(251, 50);
            this.textboxNote.TabIndex = 0;
            this.textboxNote.Text = "ブログなどの貼り付け用の画像ＵＲＬを生成し、キャプチャ実行時にＵＲＬをクリップボードにコピーします。画像ファイルの設置先ＵＲＬを入力してください。";
            // 
            // textboxURLToImages
            // 
            this.textboxURLToImages.Location = new System.Drawing.Point(91, 33);
            this.textboxURLToImages.Name = "textboxURLToImages";
            this.textboxURLToImages.Size = new System.Drawing.Size(169, 19);
            this.textboxURLToImages.TabIndex = 2;
            // 
            // labelURLToImages
            // 
            this.labelURLToImages.AutoSize = true;
            this.labelURLToImages.Location = new System.Drawing.Point(6, 36);
            this.labelURLToImages.Name = "labelURLToImages";
            this.labelURLToImages.Size = new System.Drawing.Size(67, 12);
            this.labelURLToImages.TabIndex = 1;
            this.labelURLToImages.Text = "画像用ＵＲＬ";
            // 
            // checkboxEnable
            // 
            this.checkboxEnable.AutoSize = true;
            this.checkboxEnable.Location = new System.Drawing.Point(9, 18);
            this.checkboxEnable.Name = "checkboxEnable";
            this.checkboxEnable.Size = new System.Drawing.Size(48, 16);
            this.checkboxEnable.TabIndex = 0;
            this.checkboxEnable.Text = "有効";
            this.checkboxEnable.UseVisualStyleBackColor = true;
            this.checkboxEnable.CheckedChanged += new System.EventHandler(this.checkboxEnable_CheckedChanged);
            // 
            // groupboxImageCount
            // 
            this.groupboxImageCount.Controls.Add(this.textboxChangeICValue);
            this.groupboxImageCount.Controls.Add(this.labelChangeICValue);
            this.groupboxImageCount.Controls.Add(this.labelImageCount);
            this.groupboxImageCount.Controls.Add(this.buttonChangeICValue);
            this.groupboxImageCount.Controls.Add(this.labelImageCountTitle);
            this.groupboxImageCount.Location = new System.Drawing.Point(6, 60);
            this.groupboxImageCount.Name = "groupboxImageCount";
            this.groupboxImageCount.Size = new System.Drawing.Size(267, 56);
            this.groupboxImageCount.TabIndex = 5;
            this.groupboxImageCount.TabStop = false;
            this.groupboxImageCount.Text = "画像のカウント";
            // 
            // textboxChangeICValue
            // 
            this.textboxChangeICValue.Location = new System.Drawing.Point(164, 31);
            this.textboxChangeICValue.Name = "textboxChangeICValue";
            this.textboxChangeICValue.Size = new System.Drawing.Size(38, 19);
            this.textboxChangeICValue.TabIndex = 4;
            // 
            // labelChangeICValue
            // 
            this.labelChangeICValue.AutoSize = true;
            this.labelChangeICValue.Location = new System.Drawing.Point(6, 34);
            this.labelChangeICValue.Name = "labelChangeICValue";
            this.labelChangeICValue.Size = new System.Drawing.Size(105, 12);
            this.labelChangeICValue.TabIndex = 3;
            this.labelChangeICValue.Text = "新しい画像のカウント";
            this.labelChangeICValue.Click += new System.EventHandler(this.labelChangeICValue_Click);
            // 
            // labelImageCount
            // 
            this.labelImageCount.AutoSize = true;
            this.labelImageCount.Location = new System.Drawing.Point(149, 15);
            this.labelImageCount.Name = "labelImageCount";
            this.labelImageCount.Size = new System.Drawing.Size(23, 12);
            this.labelImageCount.TabIndex = 2;
            this.labelImageCount.Text = "---";
            // 
            // buttonChangeICValue
            // 
            this.buttonChangeICValue.Location = new System.Drawing.Point(221, 30);
            this.buttonChangeICValue.Name = "buttonChangeICValue";
            this.buttonChangeICValue.Size = new System.Drawing.Size(39, 21);
            this.buttonChangeICValue.TabIndex = 1;
            this.buttonChangeICValue.Text = "変更";
            this.buttonChangeICValue.UseVisualStyleBackColor = true;
            this.buttonChangeICValue.Click += new System.EventHandler(this.buttonChangeICValue_Click);
            // 
            // labelImageCountTitle
            // 
            this.labelImageCountTitle.AutoSize = true;
            this.labelImageCountTitle.Location = new System.Drawing.Point(6, 15);
            this.labelImageCountTitle.Name = "labelImageCountTitle";
            this.labelImageCountTitle.Size = new System.Drawing.Size(86, 12);
            this.labelImageCountTitle.TabIndex = 0;
            this.labelImageCountTitle.Text = "現在のカウント数";
            // 
            // groupboxImageSettings
            // 
            this.groupboxImageSettings.Controls.Add(this.groupboxCaptureArea);
            this.groupboxImageSettings.Controls.Add(this.groupboxImageType);
            this.groupboxImageSettings.Controls.Add(this.groupboxNamePrefix);
            this.groupboxImageSettings.Controls.Add(this.groupboxImageCount);
            this.groupboxImageSettings.Location = new System.Drawing.Point(286, 11);
            this.groupboxImageSettings.Name = "groupboxImageSettings";
            this.groupboxImageSettings.Size = new System.Drawing.Size(281, 235);
            this.groupboxImageSettings.TabIndex = 6;
            this.groupboxImageSettings.TabStop = false;
            this.groupboxImageSettings.Text = "画像設定";
            // 
            // groupboxCaptureArea
            // 
            this.groupboxCaptureArea.Controls.Add(this.radioButtonActiveForm);
            this.groupboxCaptureArea.Controls.Add(this.radiobuttonAllMonitorsMultiple);
            this.groupboxCaptureArea.Controls.Add(this.radiobuttonAllMonitorsSingle);
            this.groupboxCaptureArea.Controls.Add(this.radiobuttonPrimaryMonitor);
            this.groupboxCaptureArea.Location = new System.Drawing.Point(6, 166);
            this.groupboxCaptureArea.Name = "groupboxCaptureArea";
            this.groupboxCaptureArea.Size = new System.Drawing.Size(260, 60);
            this.groupboxCaptureArea.TabIndex = 8;
            this.groupboxCaptureArea.TabStop = false;
            this.groupboxCaptureArea.Text = "キャプチャの範囲";
            // 
            // radioButtonActiveForm
            // 
            this.radioButtonActiveForm.AutoSize = true;
            this.radioButtonActiveForm.Checked = true;
            this.radioButtonActiveForm.Location = new System.Drawing.Point(6, 17);
            this.radioButtonActiveForm.Name = "radioButtonActiveForm";
            this.radioButtonActiveForm.Size = new System.Drawing.Size(108, 16);
            this.radioButtonActiveForm.TabIndex = 3;
            this.radioButtonActiveForm.TabStop = true;
            this.radioButtonActiveForm.Text = "アクティブウィンドウ";
            this.radioButtonActiveForm.UseVisualStyleBackColor = true;
            this.radioButtonActiveForm.CheckedChanged += new System.EventHandler(this.radioButtonActiveForm_CheckedChanged);
            // 
            // radiobuttonAllMonitorsMultiple
            // 
            this.radiobuttonAllMonitorsMultiple.AutoSize = true;
            this.radiobuttonAllMonitorsMultiple.Location = new System.Drawing.Point(6, 39);
            this.radiobuttonAllMonitorsMultiple.Name = "radiobuttonAllMonitorsMultiple";
            this.radiobuttonAllMonitorsMultiple.Size = new System.Drawing.Size(129, 16);
            this.radiobuttonAllMonitorsMultiple.TabIndex = 2;
            this.radiobuttonAllMonitorsMultiple.Text = "複数モニタ(複数画像)";
            this.radiobuttonAllMonitorsMultiple.UseVisualStyleBackColor = true;
            this.radiobuttonAllMonitorsMultiple.CheckedChanged += new System.EventHandler(this.radiobuttonAllMonitorsMultiple_CheckedChanged);
            // 
            // radiobuttonAllMonitorsSingle
            // 
            this.radiobuttonAllMonitorsSingle.AutoSize = true;
            this.radiobuttonAllMonitorsSingle.Location = new System.Drawing.Point(141, 39);
            this.radiobuttonAllMonitorsSingle.Name = "radiobuttonAllMonitorsSingle";
            this.radiobuttonAllMonitorsSingle.Size = new System.Drawing.Size(113, 16);
            this.radiobuttonAllMonitorsSingle.TabIndex = 1;
            this.radiobuttonAllMonitorsSingle.Text = "複数モニタ(１画像)";
            this.radiobuttonAllMonitorsSingle.UseVisualStyleBackColor = true;
            this.radiobuttonAllMonitorsSingle.CheckedChanged += new System.EventHandler(this.radiobuttonAllMonitorsSingle_CheckedChanged);
            // 
            // radiobuttonPrimaryMonitor
            // 
            this.radiobuttonPrimaryMonitor.AutoSize = true;
            this.radiobuttonPrimaryMonitor.Location = new System.Drawing.Point(141, 17);
            this.radiobuttonPrimaryMonitor.Name = "radiobuttonPrimaryMonitor";
            this.radiobuttonPrimaryMonitor.Size = new System.Drawing.Size(73, 16);
            this.radiobuttonPrimaryMonitor.TabIndex = 0;
            this.radiobuttonPrimaryMonitor.Text = "モニタ全体";
            this.radiobuttonPrimaryMonitor.UseVisualStyleBackColor = true;
            this.radiobuttonPrimaryMonitor.CheckedChanged += new System.EventHandler(this.radiobuttonPrimaryMonitor_CheckedChanged);
            // 
            // groupboxImageType
            // 
            this.groupboxImageType.Controls.Add(this.radiobuttonGIF);
            this.groupboxImageType.Controls.Add(this.radiobuttonBMP);
            this.groupboxImageType.Controls.Add(this.radiobuttonPNG);
            this.groupboxImageType.Controls.Add(this.radiobuttonJPG);
            this.groupboxImageType.Location = new System.Drawing.Point(6, 122);
            this.groupboxImageType.Name = "groupboxImageType";
            this.groupboxImageType.Size = new System.Drawing.Size(267, 39);
            this.groupboxImageType.TabIndex = 7;
            this.groupboxImageType.TabStop = false;
            this.groupboxImageType.Text = "画像の形式";
            // 
            // radiobuttonGIF
            // 
            this.radiobuttonGIF.AutoSize = true;
            this.radiobuttonGIF.Location = new System.Drawing.Point(165, 18);
            this.radiobuttonGIF.Name = "radiobuttonGIF";
            this.radiobuttonGIF.Size = new System.Drawing.Size(41, 16);
            this.radiobuttonGIF.TabIndex = 3;
            this.radiobuttonGIF.TabStop = true;
            this.radiobuttonGIF.Text = "GIF";
            this.radiobuttonGIF.UseVisualStyleBackColor = true;
            this.radiobuttonGIF.CheckedChanged += new System.EventHandler(this.radiobuttonGIF_CheckedChanged);
            // 
            // radiobuttonBMP
            // 
            this.radiobuttonBMP.AutoSize = true;
            this.radiobuttonBMP.Location = new System.Drawing.Point(111, 18);
            this.radiobuttonBMP.Name = "radiobuttonBMP";
            this.radiobuttonBMP.Size = new System.Drawing.Size(47, 16);
            this.radiobuttonBMP.TabIndex = 2;
            this.radiobuttonBMP.TabStop = true;
            this.radiobuttonBMP.Text = "BMP";
            this.radiobuttonBMP.UseVisualStyleBackColor = true;
            this.radiobuttonBMP.CheckedChanged += new System.EventHandler(this.radiobuttonBMP_CheckedChanged);
            // 
            // radiobuttonPNG
            // 
            this.radiobuttonPNG.AutoSize = true;
            this.radiobuttonPNG.Location = new System.Drawing.Point(57, 18);
            this.radiobuttonPNG.Name = "radiobuttonPNG";
            this.radiobuttonPNG.Size = new System.Drawing.Size(46, 16);
            this.radiobuttonPNG.TabIndex = 1;
            this.radiobuttonPNG.TabStop = true;
            this.radiobuttonPNG.Text = "PNG";
            this.radiobuttonPNG.UseVisualStyleBackColor = true;
            this.radiobuttonPNG.CheckedChanged += new System.EventHandler(this.radiobuttonPNG_CheckedChanged);
            // 
            // radiobuttonJPG
            // 
            this.radiobuttonJPG.AutoSize = true;
            this.radiobuttonJPG.Checked = true;
            this.radiobuttonJPG.Location = new System.Drawing.Point(6, 18);
            this.radiobuttonJPG.Name = "radiobuttonJPG";
            this.radiobuttonJPG.Size = new System.Drawing.Size(45, 16);
            this.radiobuttonJPG.TabIndex = 0;
            this.radiobuttonJPG.TabStop = true;
            this.radiobuttonJPG.Text = "JPG";
            this.radiobuttonJPG.UseVisualStyleBackColor = true;
            this.radiobuttonJPG.CheckedChanged += new System.EventHandler(this.radiobuttonJPG_CheckedChanged);
            // 
            // groupboxNamePrefix
            // 
            this.groupboxNamePrefix.Controls.Add(this.textboxPrefix);
            this.groupboxNamePrefix.Controls.Add(this.labelPrefix);
            this.groupboxNamePrefix.Location = new System.Drawing.Point(6, 18);
            this.groupboxNamePrefix.Name = "groupboxNamePrefix";
            this.groupboxNamePrefix.Size = new System.Drawing.Size(267, 37);
            this.groupboxNamePrefix.TabIndex = 6;
            this.groupboxNamePrefix.TabStop = false;
            this.groupboxNamePrefix.Text = "画像ファイルに付与する共通名称";
            // 
            // textboxPrefix
            // 
            this.textboxPrefix.Location = new System.Drawing.Point(59, 12);
            this.textboxPrefix.Name = "textboxPrefix";
            this.textboxPrefix.Size = new System.Drawing.Size(201, 19);
            this.textboxPrefix.TabIndex = 1;
            this.textboxPrefix.Leave += new System.EventHandler(this.textboxPrefix_Leave);
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(6, 15);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(29, 12);
            this.labelPrefix.TabIndex = 0;
            this.labelPrefix.Text = "名称";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAbout.Location = new System.Drawing.Point(321, 264);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(246, 12);
            this.labelAbout.TabIndex = 7;
            this.labelAbout.Text = "SSICAT Ver0.1 (Forked from SICAT) SS分科会";
            // 
            // linklabelWebsite
            // 
            this.linklabelWebsite.AutoSize = true;
            this.linklabelWebsite.LinkColor = System.Drawing.Color.DarkGray;
            this.linklabelWebsite.Location = new System.Drawing.Point(441, 279);
            this.linklabelWebsite.Name = "linklabelWebsite";
            this.linklabelWebsite.Size = new System.Drawing.Size(124, 12);
            this.linklabelWebsite.TabIndex = 8;
            this.linklabelWebsite.TabStop = true;
            this.linklabelWebsite.Text = "http://systemsoft.co.cc";
            this.linklabelWebsite.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.linklabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelWebsite_LinkClicked);
            // 
            // formConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(575, 341);
            this.ControlBox = false;
            this.Controls.Add(this.groupboxImageSettings);
            this.Controls.Add(this.groupboxBrowserURL);
            this.Controls.Add(this.groupboxHotkey);
            this.Controls.Add(this.groupboxFTPSettings);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.linklabelWebsite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formConfiguration";
            this.Text = "SSICAT 設定";
            this.Load += new System.EventHandler(this.formConfiguration_Load);
            this.groupboxFTPSettings.ResumeLayout(false);
            this.groupboxFTPSettings.PerformLayout();
            this.groupboxHotkey.ResumeLayout(false);
            this.groupboxHotkey.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupboxBrowserURL.ResumeLayout(false);
            this.groupboxBrowserURL.PerformLayout();
            this.groupboxImageCount.ResumeLayout(false);
            this.groupboxImageCount.PerformLayout();
            this.groupboxImageSettings.ResumeLayout(false);
            this.groupboxCaptureArea.ResumeLayout(false);
            this.groupboxCaptureArea.PerformLayout();
            this.groupboxImageType.ResumeLayout(false);
            this.groupboxImageType.PerformLayout();
            this.groupboxNamePrefix.ResumeLayout(false);
            this.groupboxNamePrefix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxFTPSettings;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxServerAddress;
        private System.Windows.Forms.Label labelServerAddress;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.GroupBox groupboxHotkey;
        private System.Windows.Forms.Label labelCurrentHotkeyTitle;
        private System.Windows.Forms.Button buttonSetHotkey;
        private System.Windows.Forms.Label labelCurrentHotkey;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.TextBox textboxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupboxBrowserURL;
        private System.Windows.Forms.CheckBox checkboxEnable;
        private System.Windows.Forms.TextBox textboxURLToImages;
        private System.Windows.Forms.Label labelURLToImages;
        private System.Windows.Forms.TextBox textboxNote;
        private System.Windows.Forms.GroupBox groupboxImageCount;
        private System.Windows.Forms.Button buttonChangeICValue;
        private System.Windows.Forms.Label labelImageCountTitle;
        private System.Windows.Forms.Label labelImageCount;
        private System.Windows.Forms.Label labelChangeICValue;
        private System.Windows.Forms.TextBox textboxChangeICValue;
        private System.Windows.Forms.GroupBox groupboxImageSettings;
        private System.Windows.Forms.GroupBox groupboxNamePrefix;
        private System.Windows.Forms.TextBox textboxPrefix;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.GroupBox groupboxImageType;
        private System.Windows.Forms.RadioButton radiobuttonJPG;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.RadioButton radiobuttonPNG;
        private System.Windows.Forms.RadioButton radiobuttonBMP;
        private System.Windows.Forms.RadioButton radiobuttonGIF;
        private System.Windows.Forms.LinkLabel linklabelWebsite;
        private System.Windows.Forms.GroupBox groupboxCaptureArea;
        private System.Windows.Forms.RadioButton radiobuttonAllMonitorsMultiple;
        private System.Windows.Forms.RadioButton radiobuttonAllMonitorsSingle;
        private System.Windows.Forms.RadioButton radiobuttonPrimaryMonitor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.RadioButton radioButtonActiveForm;
        private System.Windows.Forms.CheckBox passive_on;
    }
}

