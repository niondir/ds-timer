namespace DS_Timer
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtAdjust = new System.Windows.Forms.TextBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnSystemTimeSync = new System.Windows.Forms.Button();
			this.txtSystemTimeDelay = new System.Windows.Forms.TextBox();
			this.lblSystemtimeDelay = new System.Windows.Forms.Label();
			this.btnCheckSystemTime = new System.Windows.Forms.Button();
			this.btnPingDS = new System.Windows.Forms.Button();
			this.txtRTT = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.donateButton1 = new DS_Timer.Gui.DonateButton();
			this.btnDetectReactionTime = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tsbMiniClock = new System.Windows.Forms.ToolStripButton();
			this.tsbAlarm = new System.Windows.Forms.ToolStripButton();
			this.tsbAttackPlaner = new System.Windows.Forms.ToolStripButton();
			this.tsbHelp = new System.Windows.Forms.ToolStripButton();
			this.tsbUnitCalc = new System.Windows.Forms.ToolStripButton();
			this.tsbSettings = new System.Windows.Forms.ToolStripButton();
			this.groupBox2.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTime
			// 
			resources.ApplyResources(this.txtTime, "txtTime");
			this.txtTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			// 
			// txtAdjust
			// 
			resources.ApplyResources(this.txtAdjust, "txtAdjust");
			this.txtAdjust.Name = "txtAdjust";
			// 
			// btnTest
			// 
			resources.ApplyResources(this.btnTest, "btnTest");
			this.btnTest.Name = "btnTest";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnSystemTimeSync
			// 
			resources.ApplyResources(this.btnSystemTimeSync, "btnSystemTimeSync");
			this.btnSystemTimeSync.Name = "btnSystemTimeSync";
			this.btnSystemTimeSync.UseVisualStyleBackColor = true;
			this.btnSystemTimeSync.Click += new System.EventHandler(this.btnSystemTimeSync_Click);
			// 
			// txtSystemTimeDelay
			// 
			resources.ApplyResources(this.txtSystemTimeDelay, "txtSystemTimeDelay");
			this.txtSystemTimeDelay.Name = "txtSystemTimeDelay";
			this.txtSystemTimeDelay.ReadOnly = true;
			this.txtSystemTimeDelay.TextChanged += new System.EventHandler(this.txtSystemTimeDelay_TextChanged);
			// 
			// lblSystemtimeDelay
			// 
			resources.ApplyResources(this.lblSystemtimeDelay, "lblSystemtimeDelay");
			this.lblSystemtimeDelay.Name = "lblSystemtimeDelay";
			// 
			// btnCheckSystemTime
			// 
			resources.ApplyResources(this.btnCheckSystemTime, "btnCheckSystemTime");
			this.btnCheckSystemTime.Name = "btnCheckSystemTime";
			this.btnCheckSystemTime.UseVisualStyleBackColor = true;
			this.btnCheckSystemTime.Click += new System.EventHandler(this.btnCheckSystemTime_Click);
			// 
			// btnPingDS
			// 
			resources.ApplyResources(this.btnPingDS, "btnPingDS");
			this.btnPingDS.Name = "btnPingDS";
			this.btnPingDS.UseVisualStyleBackColor = true;
			this.btnPingDS.Click += new System.EventHandler(this.btnPingDS_Click);
			// 
			// txtRTT
			// 
			resources.ApplyResources(this.txtRTT, "txtRTT");
			this.txtRTT.Name = "txtRTT";
			this.txtRTT.ReadOnly = true;
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.donateButton1);
			this.groupBox2.Controls.Add(this.btnDetectReactionTime);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnSystemTimeSync);
			this.groupBox2.Controls.Add(this.txtRTT);
			this.groupBox2.Controls.Add(this.lblSystemtimeDelay);
			this.groupBox2.Controls.Add(this.btnPingDS);
			this.groupBox2.Controls.Add(this.btnCheckSystemTime);
			this.groupBox2.Controls.Add(this.txtSystemTimeDelay);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// donateButton1
			// 
			resources.ApplyResources(this.donateButton1, "donateButton1");
			this.donateButton1.Name = "donateButton1";
			this.donateButton1.UseVisualStyleBackColor = true;
			// 
			// btnDetectReactionTime
			// 
			resources.ApplyResources(this.btnDetectReactionTime, "btnDetectReactionTime");
			this.btnDetectReactionTime.Name = "btnDetectReactionTime";
			this.btnDetectReactionTime.UseVisualStyleBackColor = true;
			this.btnDetectReactionTime.Click += new System.EventHandler(this.btnDetectReactionTime_Click);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// toolStrip
			// 
			resources.ApplyResources(this.toolStrip, "toolStrip");
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMiniClock,
            this.tsbAlarm,
            this.tsbAttackPlaner,
            this.tsbHelp,
            this.tsbUnitCalc,
            this.tsbSettings});
			this.toolStrip.Name = "toolStrip";
			// 
			// tsbMiniClock
			// 
			resources.ApplyResources(this.tsbMiniClock, "tsbMiniClock");
			this.tsbMiniClock.Image = global::DS_Timer.Properties.Resources.clock;
			this.tsbMiniClock.Name = "tsbMiniClock";
			this.tsbMiniClock.Click += new System.EventHandler(this.tsbMiniClock_Click);
			// 
			// tsbAlarm
			// 
			resources.ApplyResources(this.tsbAlarm, "tsbAlarm");
			this.tsbAlarm.Image = global::DS_Timer.Properties.Resources.clock_red;
			this.tsbAlarm.Name = "tsbAlarm";
			this.tsbAlarm.Click += new System.EventHandler(this.tsbAlarm_Click);
			// 
			// tsbAttackPlaner
			// 
			resources.ApplyResources(this.tsbAttackPlaner, "tsbAttackPlaner");
			this.tsbAttackPlaner.Image = global::DS_Timer.Properties.Resources.bomb;
			this.tsbAttackPlaner.Name = "tsbAttackPlaner";
			this.tsbAttackPlaner.Click += new System.EventHandler(this.tsbAttackPlaner_Click);
			// 
			// tsbHelp
			// 
			resources.ApplyResources(this.tsbHelp, "tsbHelp");
			this.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbHelp.Image = global::DS_Timer.Properties.Resources.help;
			this.tsbHelp.Name = "tsbHelp";
			this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
			// 
			// tsbUnitCalc
			// 
			resources.ApplyResources(this.tsbUnitCalc, "tsbUnitCalc");
			this.tsbUnitCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbUnitCalc.Image = global::DS_Timer.Properties.Resources.unit_light;
			this.tsbUnitCalc.Name = "tsbUnitCalc";
			this.tsbUnitCalc.Click += new System.EventHandler(this.tsbUnitCalc_Click);
			// 
			// tsbSettings
			// 
			resources.ApplyResources(this.tsbSettings, "tsbSettings");
			this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSettings.Image = global::DS_Timer.Properties.Resources.cog;
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtAdjust);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.txtTime);
			this.Name = "FormMain";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnCheckSystemTime;
		private System.Windows.Forms.Label lblSystemtimeDelay;
		private System.Windows.Forms.TextBox txtSystemTimeDelay;
		private System.Windows.Forms.Button btnSystemTimeSync;
		private System.Windows.Forms.Button btnPingDS;
		private System.Windows.Forms.TextBox txtRTT;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAdjust;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton tsbMiniClock;
		private System.Windows.Forms.ToolStripButton tsbSettings;
		private System.Windows.Forms.ToolStripButton tsbHelp;
		private System.Windows.Forms.Button btnDetectReactionTime;
		private System.Windows.Forms.ToolStripButton tsbAttackPlaner;
		private DS_Timer.Gui.DonateButton donateButton1;
		private System.Windows.Forms.ToolStripButton tsbAlarm;
		private System.Windows.Forms.ToolStripButton tsbUnitCalc;
	}
}

