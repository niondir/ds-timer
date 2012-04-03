namespace DS_Timer.Gui
{
	partial class FormSettings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
			this.btnResetSettings = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenAlarmFile = new System.Windows.Forms.Button();
			this.btnTestSound = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCheckUpdate = new System.Windows.Forms.Button();
			this.btnConfigDir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lblUnitSpeed = new System.Windows.Forms.Label();
			this.worldConfigFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.lblWorldSpeed = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblLastWorldUpdate = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnLoadWorldData = new System.Windows.Forms.Button();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbDSWorld = new System.Windows.Forms.ComboBox();
			this.worldInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.numTimeShift = new System.Windows.Forms.NumericUpDown();
			this.BtnSetLanguage = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.cbLanguage = new System.Windows.Forms.ComboBox();
			this.cbAutoBlink = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.numClockAdjustment = new System.Windows.Forms.NumericUpDown();
			this.cbAutoSync = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtAlarmSound = new System.Windows.Forms.TextBox();
			this.cbDownloadBetaUpdates = new System.Windows.Forms.CheckBox();
			this.pbDownloadPercentage = new System.Windows.Forms.ProgressBar();
			this.worldDownloaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblDownloadstatus = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.worldConfigFileBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.worldInfoBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTimeShift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numClockAdjustment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.worldDownloaderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnResetSettings
			// 
			resources.ApplyResources(this.btnResetSettings, "btnResetSettings");
			this.btnResetSettings.Name = "btnResetSettings";
			this.btnResetSettings.UseVisualStyleBackColor = true;
			this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// btnSave
			// 
			resources.ApplyResources(this.btnSave, "btnSave");
			this.btnSave.Name = "btnSave";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// btnOpenAlarmFile
			// 
			resources.ApplyResources(this.btnOpenAlarmFile, "btnOpenAlarmFile");
			this.btnOpenAlarmFile.Name = "btnOpenAlarmFile";
			this.toolTip.SetToolTip(this.btnOpenAlarmFile, resources.GetString("btnOpenAlarmFile.ToolTip"));
			this.btnOpenAlarmFile.UseVisualStyleBackColor = true;
			this.btnOpenAlarmFile.Click += new System.EventHandler(this.btnOpenAlarmFile_Click);
			// 
			// btnTestSound
			// 
			resources.ApplyResources(this.btnTestSound, "btnTestSound");
			this.btnTestSound.Name = "btnTestSound";
			this.toolTip.SetToolTip(this.btnTestSound, resources.GetString("btnTestSound.ToolTip"));
			this.btnTestSound.UseVisualStyleBackColor = true;
			this.btnTestSound.Click += new System.EventHandler(this.btnTestSound_Click);
			// 
			// btnAccept
			// 
			resources.ApplyResources(this.btnAccept, "btnAccept");
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnCheckUpdate
			// 
			resources.ApplyResources(this.btnCheckUpdate, "btnCheckUpdate");
			this.btnCheckUpdate.Name = "btnCheckUpdate";
			this.btnCheckUpdate.UseVisualStyleBackColor = true;
			this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
			// 
			// btnConfigDir
			// 
			resources.ApplyResources(this.btnConfigDir, "btnConfigDir");
			this.btnConfigDir.Image = global::DS_Timer.Properties.Resources.folder_go;
			this.btnConfigDir.Name = "btnConfigDir";
			this.btnConfigDir.UseVisualStyleBackColor = true;
			this.btnConfigDir.Click += new System.EventHandler(this.btnConfigDir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.lblUnitSpeed);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.lblWorldSpeed);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lblLastWorldUpdate);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.btnLoadWorldData);
			this.groupBox1.Controls.Add(this.txtServer);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbDSWorld);
			this.groupBox1.Controls.Add(this.label4);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.BackColor = System.Drawing.Color.LightGreen;
			this.label13.Name = "label13";
			// 
			// lblUnitSpeed
			// 
			resources.ApplyResources(this.lblUnitSpeed, "lblUnitSpeed");
			this.lblUnitSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldConfigFileBindingSource, "WorldUnitSpeed", true));
			this.lblUnitSpeed.Name = "lblUnitSpeed";
			// 
			// worldConfigFileBindingSource
			// 
			this.worldConfigFileBindingSource.DataSource = typeof(DS_Timer.World.WorldConfigFile);
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.BackColor = System.Drawing.Color.LimeGreen;
			this.label12.Name = "label12";
			// 
			// lblWorldSpeed
			// 
			resources.ApplyResources(this.lblWorldSpeed, "lblWorldSpeed");
			this.lblWorldSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldConfigFileBindingSource, "WorldSpeed", true));
			this.lblWorldSpeed.Name = "lblWorldSpeed";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.BackColor = System.Drawing.Color.Orange;
			this.label11.Name = "label11";
			// 
			// lblLastWorldUpdate
			// 
			resources.ApplyResources(this.lblLastWorldUpdate, "lblLastWorldUpdate");
			this.lblLastWorldUpdate.Name = "lblLastWorldUpdate";
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.BackColor = System.Drawing.Color.LightCoral;
			this.label10.Name = "label10";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// btnLoadWorldData
			// 
			this.btnLoadWorldData.Image = global::DS_Timer.Properties.Resources.world_go;
			resources.ApplyResources(this.btnLoadWorldData, "btnLoadWorldData");
			this.btnLoadWorldData.Name = "btnLoadWorldData";
			this.toolTip.SetToolTip(this.btnLoadWorldData, resources.GetString("btnLoadWorldData.ToolTip"));
			this.btnLoadWorldData.UseVisualStyleBackColor = true;
			this.btnLoadWorldData.Click += new System.EventHandler(this.btnLoadWorldData_Click);
			// 
			// txtServer
			// 
			this.txtServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DS_Timer.Properties.Settings.Default, "DSServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			resources.ApplyResources(this.txtServer, "txtServer");
			this.txtServer.Name = "txtServer";
			this.txtServer.Text = global::DS_Timer.Properties.Settings.Default.DSServer;
			this.txtServer.Validated += new System.EventHandler(this.txtServer_Validated);
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// cbDSWorld
			// 
			this.cbDSWorld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbDSWorld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbDSWorld.DataSource = this.worldInfoBindingSource;
			this.cbDSWorld.DisplayMember = "Name";
			this.cbDSWorld.FormattingEnabled = true;
			resources.ApplyResources(this.cbDSWorld, "cbDSWorld");
			this.cbDSWorld.Name = "cbDSWorld";
			this.toolTip.SetToolTip(this.cbDSWorld, resources.GetString("cbDSWorld.ToolTip"));
			this.cbDSWorld.ValueMember = "Server";
			this.cbDSWorld.SelectedIndexChanged += new System.EventHandler(this.cbDSWorld_SelectedIndexChanged);
			this.cbDSWorld.SelectionChangeCommitted += new System.EventHandler(this.cbDSWorld_SelectionChangeCommitted);
			this.cbDSWorld.Validated += new System.EventHandler(this.cbDSWorld_Validated);
			// 
			// worldInfoBindingSource
			// 
			this.worldInfoBindingSource.DataSource = typeof(DS_Timer.World.WorldInfo);
			this.worldInfoBindingSource.CurrentItemChanged += new System.EventHandler(this.worldInfoBindingSource_CurrentItemChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.numTimeShift);
			this.groupBox2.Controls.Add(this.BtnSetLanguage);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.cbLanguage);
			this.groupBox2.Controls.Add(this.cbAutoBlink);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.numClockAdjustment);
			this.groupBox2.Controls.Add(this.cbAutoSync);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.btnConfigDir);
			this.groupBox2.Controls.Add(this.txtAlarmSound);
			this.groupBox2.Controls.Add(this.cbDownloadBetaUpdates);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnCheckUpdate);
			this.groupBox2.Controls.Add(this.btnOpenAlarmFile);
			this.groupBox2.Controls.Add(this.btnTestSound);
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.Name = "label16";
			// 
			// numTimeShift
			// 
			this.numTimeShift.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DS_Timer.Properties.Settings.Default, "TimeZoneOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			resources.ApplyResources(this.numTimeShift, "numTimeShift");
			this.numTimeShift.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.numTimeShift.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
			this.numTimeShift.Name = "numTimeShift";
			this.toolTip.SetToolTip(this.numTimeShift, resources.GetString("numTimeShift.ToolTip"));
			this.numTimeShift.Value = global::DS_Timer.Properties.Settings.Default.TimeZoneOffset;
			// 
			// BtnSetLanguage
			// 
			resources.ApplyResources(this.BtnSetLanguage, "BtnSetLanguage");
			this.BtnSetLanguage.Name = "BtnSetLanguage";
			this.BtnSetLanguage.UseVisualStyleBackColor = true;
			this.BtnSetLanguage.Click += new System.EventHandler(this.BtnSetLanguage_Click);
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// cbLanguage
			// 
			this.cbLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DS_Timer.Properties.Settings.Default, "Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbLanguage.FormattingEnabled = true;
			this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
			resources.ApplyResources(this.cbLanguage, "cbLanguage");
			this.cbLanguage.Name = "cbLanguage";
			this.cbLanguage.Text = global::DS_Timer.Properties.Settings.Default.Language;
			// 
			// cbAutoBlink
			// 
			resources.ApplyResources(this.cbAutoBlink, "cbAutoBlink");
			this.cbAutoBlink.Checked = global::DS_Timer.Properties.Settings.Default.AutoBlink;
			this.cbAutoBlink.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DS_Timer.Properties.Settings.Default, "AutoBlink", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbAutoBlink.Name = "cbAutoBlink";
			this.cbAutoBlink.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// numClockAdjustment
			// 
			this.numClockAdjustment.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DS_Timer.Properties.Settings.Default, "ClockAdjustment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			resources.ApplyResources(this.numClockAdjustment, "numClockAdjustment");
			this.numClockAdjustment.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numClockAdjustment.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numClockAdjustment.Name = "numClockAdjustment";
			this.toolTip.SetToolTip(this.numClockAdjustment, resources.GetString("numClockAdjustment.ToolTip"));
			this.numClockAdjustment.Value = global::DS_Timer.Properties.Settings.Default.ClockAdjustment;
			// 
			// cbAutoSync
			// 
			resources.ApplyResources(this.cbAutoSync, "cbAutoSync");
			this.cbAutoSync.Checked = global::DS_Timer.Properties.Settings.Default.AutoSync;
			this.cbAutoSync.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DS_Timer.Properties.Settings.Default, "AutoSync", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbAutoSync.Name = "cbAutoSync";
			this.toolTip.SetToolTip(this.cbAutoSync, resources.GetString("cbAutoSync.ToolTip"));
			this.cbAutoSync.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DS_Timer.Properties.Settings.Default, "TimeServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items")});
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Text = global::DS_Timer.Properties.Settings.Default.TimeServer;
			// 
			// txtAlarmSound
			// 
			this.txtAlarmSound.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DS_Timer.Properties.Settings.Default, "AlarmSoundFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			resources.ApplyResources(this.txtAlarmSound, "txtAlarmSound");
			this.txtAlarmSound.Name = "txtAlarmSound";
			this.txtAlarmSound.Text = global::DS_Timer.Properties.Settings.Default.AlarmSoundFile;
			// 
			// cbDownloadBetaUpdates
			// 
			resources.ApplyResources(this.cbDownloadBetaUpdates, "cbDownloadBetaUpdates");
			this.cbDownloadBetaUpdates.Checked = global::DS_Timer.Properties.Settings.Default.DownloadBeta;
			this.cbDownloadBetaUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DS_Timer.Properties.Settings.Default, "DownloadBeta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbDownloadBetaUpdates.Name = "cbDownloadBetaUpdates";
			this.toolTip.SetToolTip(this.cbDownloadBetaUpdates, resources.GetString("cbDownloadBetaUpdates.ToolTip"));
			this.cbDownloadBetaUpdates.UseVisualStyleBackColor = true;
			// 
			// pbDownloadPercentage
			// 
			resources.ApplyResources(this.pbDownloadPercentage, "pbDownloadPercentage");
			this.pbDownloadPercentage.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.worldDownloaderBindingSource, "ProcessPercentage", true));
			this.pbDownloadPercentage.Name = "pbDownloadPercentage";
			this.pbDownloadPercentage.Click += new System.EventHandler(this.pbDownloadPercentage_Click);
			// 
			// worldDownloaderBindingSource
			// 
			this.worldDownloaderBindingSource.DataSource = typeof(DS_Timer.World.WorldDownloader);
			// 
			// lblDownloadstatus
			// 
			resources.ApplyResources(this.lblDownloadstatus, "lblDownloadstatus");
			this.lblDownloadstatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldDownloaderBindingSource, "InfoString", true));
			this.lblDownloadstatus.Name = "lblDownloadstatus";
			// 
			// FormSettings
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblDownloadstatus);
			this.Controls.Add(this.pbDownloadPercentage);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnResetSettings);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "FormSettings";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyUp);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.worldConfigFileBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.worldInfoBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTimeShift)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numClockAdjustment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.worldDownloaderBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnResetSettings;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbDSWorld;
		private System.Windows.Forms.TextBox txtAlarmSound;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpenAlarmFile;
		private System.Windows.Forms.Button btnTestSound;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCheckUpdate;
		private System.Windows.Forms.CheckBox cbDownloadBetaUpdates;
		private System.Windows.Forms.Button btnConfigDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource worldInfoBindingSource;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastWorldUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadWorldData;
        private System.Windows.Forms.ProgressBar pbDownloadPercentage;
        private System.Windows.Forms.Label lblDownloadstatus;
        private System.Windows.Forms.BindingSource worldDownloaderBindingSource;
		private System.Windows.Forms.CheckBox cbAutoSync;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numClockAdjustment;
        private System.Windows.Forms.BindingSource worldConfigFileBindingSource;
        private System.Windows.Forms.Label lblUnitSpeed;
        private System.Windows.Forms.Label lblWorldSpeed;
        private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox cbAutoBlink;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbLanguage;
		private System.Windows.Forms.Button BtnSetLanguage;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown numTimeShift;
	}
}