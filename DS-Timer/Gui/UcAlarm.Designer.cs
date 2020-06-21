namespace DS_Timer.Gui
{
	partial class UcAlarm
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAlarm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEditAlarm = new System.Windows.Forms.GroupBox();
            this.dtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.txtAlarmMessage = new System.Windows.Forms.TextBox();
            this.btnSaveAlarm = new System.Windows.Forms.Button();
            this.cbAlarmEnabled = new System.Windows.Forms.CheckBox();
            this.cbBaloon = new System.Windows.Forms.CheckBox();
            this.cbAlarmSound = new System.Windows.Forms.CheckBox();
            this.btnTestSound = new System.Windows.Forms.Button();
            this.cbPopup = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.balloonTipDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soundDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.popupDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balloonTipDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soundDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.popupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveOldAlarms = new System.Windows.Forms.Button();
            this.btnSaveAlarms = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNextAlarm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeLeft = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.balloonTipDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soundDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.popupDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alarmTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.balloonTipDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soundDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.popupDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbEditAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditAlarm
            // 
            resources.ApplyResources(this.gbEditAlarm, "gbEditAlarm");
            this.gbEditAlarm.Controls.Add(this.dtpAlarmTime);
            this.gbEditAlarm.Controls.Add(this.txtAlarmMessage);
            this.gbEditAlarm.Controls.Add(this.btnSaveAlarm);
            this.gbEditAlarm.Controls.Add(this.cbAlarmEnabled);
            this.gbEditAlarm.Controls.Add(this.cbBaloon);
            this.gbEditAlarm.Controls.Add(this.cbAlarmSound);
            this.gbEditAlarm.Controls.Add(this.btnTestSound);
            this.gbEditAlarm.Controls.Add(this.cbPopup);
            this.gbEditAlarm.Controls.Add(this.label2);
            this.gbEditAlarm.Controls.Add(this.label1);
            this.gbEditAlarm.Name = "gbEditAlarm";
            this.gbEditAlarm.TabStop = false;
            this.toolTip.SetToolTip(this.gbEditAlarm, resources.GetString("gbEditAlarm.ToolTip"));
            // 
            // dtpAlarmTime
            // 
            resources.ApplyResources(this.dtpAlarmTime, "dtpAlarmTime");
            this.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlarmTime.Name = "dtpAlarmTime";
            this.toolTip.SetToolTip(this.dtpAlarmTime, resources.GetString("dtpAlarmTime.ToolTip"));
            this.dtpAlarmTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpAlarmTime_KeyDown);
            // 
            // txtAlarmMessage
            // 
            resources.ApplyResources(this.txtAlarmMessage, "txtAlarmMessage");
            this.txtAlarmMessage.Name = "txtAlarmMessage";
            this.toolTip.SetToolTip(this.txtAlarmMessage, resources.GetString("txtAlarmMessage.ToolTip"));
            // 
            // btnSaveAlarm
            // 
            resources.ApplyResources(this.btnSaveAlarm, "btnSaveAlarm");
            this.btnSaveAlarm.Image = global::DS_Timer.Properties.Resources.clock_add;
            this.btnSaveAlarm.Name = "btnSaveAlarm";
            this.toolTip.SetToolTip(this.btnSaveAlarm, resources.GetString("btnSaveAlarm.ToolTip"));
            this.btnSaveAlarm.UseVisualStyleBackColor = true;
            this.btnSaveAlarm.Click += new System.EventHandler(this.btnSaveAlarm_Click);
            // 
            // cbAlarmEnabled
            // 
            resources.ApplyResources(this.cbAlarmEnabled, "cbAlarmEnabled");
            this.cbAlarmEnabled.Checked = true;
            this.cbAlarmEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlarmEnabled.Name = "cbAlarmEnabled";
            this.toolTip.SetToolTip(this.cbAlarmEnabled, resources.GetString("cbAlarmEnabled.ToolTip"));
            this.cbAlarmEnabled.UseVisualStyleBackColor = true;
            // 
            // cbBaloon
            // 
            resources.ApplyResources(this.cbBaloon, "cbBaloon");
            this.cbBaloon.Checked = true;
            this.cbBaloon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBaloon.Name = "cbBaloon";
            this.toolTip.SetToolTip(this.cbBaloon, resources.GetString("cbBaloon.ToolTip"));
            this.cbBaloon.UseVisualStyleBackColor = true;
            // 
            // cbAlarmSound
            // 
            resources.ApplyResources(this.cbAlarmSound, "cbAlarmSound");
            this.cbAlarmSound.Checked = true;
            this.cbAlarmSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlarmSound.Name = "cbAlarmSound";
            this.toolTip.SetToolTip(this.cbAlarmSound, resources.GetString("cbAlarmSound.ToolTip"));
            this.cbAlarmSound.UseVisualStyleBackColor = true;
            // 
            // btnTestSound
            // 
            resources.ApplyResources(this.btnTestSound, "btnTestSound");
            this.btnTestSound.Image = global::DS_Timer.Properties.Resources.sound;
            this.btnTestSound.Name = "btnTestSound";
            this.toolTip.SetToolTip(this.btnTestSound, resources.GetString("btnTestSound.ToolTip"));
            this.btnTestSound.UseVisualStyleBackColor = true;
            this.btnTestSound.Click += new System.EventHandler(this.btnTestSound_Click);
            // 
            // cbPopup
            // 
            resources.ApplyResources(this.cbPopup, "cbPopup");
            this.cbPopup.Name = "cbPopup";
            this.toolTip.SetToolTip(this.cbPopup, resources.GetString("cbPopup.ToolTip"));
            this.cbPopup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // dgvAlarms
            // 
            resources.ApplyResources(this.dgvAlarms, "dgvAlarms");
            this.dgvAlarms.AutoGenerateColumns = false;
            this.dgvAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn2,
            this.messageDataGridViewTextBoxColumn3,
            this.activeDataGridViewCheckBoxColumn3,
            this.balloonTipDataGridViewCheckBoxColumn3,
            this.soundDataGridViewCheckBoxColumn3,
            this.popupDataGridViewCheckBoxColumn3});
            this.dgvAlarms.DataSource = this.alarmTimeBindingSource;
            this.dgvAlarms.Name = "dgvAlarms";
            this.toolTip.SetToolTip(this.dgvAlarms, resources.GetString("dgvAlarms.ToolTip"));
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            resources.ApplyResources(this.timeDataGridViewTextBoxColumn1, "timeDataGridViewTextBoxColumn1");
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // messageDataGridViewTextBoxColumn2
            // 
            this.messageDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn2.DataPropertyName = "Message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn2, "messageDataGridViewTextBoxColumn2");
            this.messageDataGridViewTextBoxColumn2.Name = "messageDataGridViewTextBoxColumn2";
            // 
            // activeDataGridViewCheckBoxColumn2
            // 
            this.activeDataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.activeDataGridViewCheckBoxColumn2.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn2, "activeDataGridViewCheckBoxColumn2");
            this.activeDataGridViewCheckBoxColumn2.Name = "activeDataGridViewCheckBoxColumn2";
            // 
            // balloonTipDataGridViewCheckBoxColumn2
            // 
            this.balloonTipDataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balloonTipDataGridViewCheckBoxColumn2.DataPropertyName = "BalloonTip";
            resources.ApplyResources(this.balloonTipDataGridViewCheckBoxColumn2, "balloonTipDataGridViewCheckBoxColumn2");
            this.balloonTipDataGridViewCheckBoxColumn2.Name = "balloonTipDataGridViewCheckBoxColumn2";
            // 
            // soundDataGridViewCheckBoxColumn2
            // 
            this.soundDataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soundDataGridViewCheckBoxColumn2.DataPropertyName = "Sound";
            resources.ApplyResources(this.soundDataGridViewCheckBoxColumn2, "soundDataGridViewCheckBoxColumn2");
            this.soundDataGridViewCheckBoxColumn2.Name = "soundDataGridViewCheckBoxColumn2";
            // 
            // popupDataGridViewCheckBoxColumn2
            // 
            this.popupDataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popupDataGridViewCheckBoxColumn2.DataPropertyName = "Popup";
            resources.ApplyResources(this.popupDataGridViewCheckBoxColumn2, "popupDataGridViewCheckBoxColumn2");
            this.popupDataGridViewCheckBoxColumn2.Name = "popupDataGridViewCheckBoxColumn2";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn, "activeDataGridViewCheckBoxColumn");
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // time
            // 
            this.time.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            this.time.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn, "messageDataGridViewTextBoxColumn");
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // balloonTipDataGridViewCheckBoxColumn
            // 
            this.balloonTipDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balloonTipDataGridViewCheckBoxColumn.DataPropertyName = "BalloonTip";
            resources.ApplyResources(this.balloonTipDataGridViewCheckBoxColumn, "balloonTipDataGridViewCheckBoxColumn");
            this.balloonTipDataGridViewCheckBoxColumn.Name = "balloonTipDataGridViewCheckBoxColumn";
            // 
            // soundDataGridViewCheckBoxColumn
            // 
            this.soundDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soundDataGridViewCheckBoxColumn.DataPropertyName = "Sound";
            resources.ApplyResources(this.soundDataGridViewCheckBoxColumn, "soundDataGridViewCheckBoxColumn");
            this.soundDataGridViewCheckBoxColumn.Name = "soundDataGridViewCheckBoxColumn";
            // 
            // popupDataGridViewCheckBoxColumn
            // 
            this.popupDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popupDataGridViewCheckBoxColumn.DataPropertyName = "Popup";
            resources.ApplyResources(this.popupDataGridViewCheckBoxColumn, "popupDataGridViewCheckBoxColumn");
            this.popupDataGridViewCheckBoxColumn.Name = "popupDataGridViewCheckBoxColumn";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.gbEditAlarm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAlarms, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnRemoveOldAlarms);
            this.panel1.Controls.Add(this.btnSaveAlarms);
            this.panel1.Name = "panel1";
            this.toolTip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // btnRemoveOldAlarms
            // 
            resources.ApplyResources(this.btnRemoveOldAlarms, "btnRemoveOldAlarms");
            this.btnRemoveOldAlarms.Image = global::DS_Timer.Properties.Resources.clock_delete;
            this.btnRemoveOldAlarms.Name = "btnRemoveOldAlarms";
            this.toolTip.SetToolTip(this.btnRemoveOldAlarms, resources.GetString("btnRemoveOldAlarms.ToolTip"));
            this.btnRemoveOldAlarms.UseVisualStyleBackColor = true;
            this.btnRemoveOldAlarms.Click += new System.EventHandler(this.btnRemoveOldAlarms_Click);
            // 
            // btnSaveAlarms
            // 
            resources.ApplyResources(this.btnSaveAlarms, "btnSaveAlarms");
            this.btnSaveAlarms.Image = global::DS_Timer.Properties.Resources.disk;
            this.btnSaveAlarms.Name = "btnSaveAlarms";
            this.toolTip.SetToolTip(this.btnSaveAlarms, resources.GetString("btnSaveAlarms.ToolTip"));
            this.btnSaveAlarms.UseVisualStyleBackColor = true;
            this.btnSaveAlarms.Click += new System.EventHandler(this.btnSaveAlarms_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNextAlarm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTimeLeft);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // txtNextAlarm
            // 
            resources.ApplyResources(this.txtNextAlarm, "txtNextAlarm");
            this.txtNextAlarm.Name = "txtNextAlarm";
            this.txtNextAlarm.ReadOnly = true;
            this.txtNextAlarm.TabStop = false;
            this.toolTip.SetToolTip(this.txtNextAlarm, resources.GetString("txtNextAlarm.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtTimeLeft
            // 
            resources.ApplyResources(this.txtTimeLeft, "txtTimeLeft");
            this.txtTimeLeft.Name = "txtTimeLeft";
            this.txtTimeLeft.ReadOnly = true;
            this.txtTimeLeft.TabStop = false;
            this.toolTip.SetToolTip(this.txtTimeLeft, resources.GetString("txtTimeLeft.ToolTip"));
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            resources.ApplyResources(this.timeDataGridViewTextBoxColumn, "timeDataGridViewTextBoxColumn");
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn1
            // 
            this.messageDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn1.DataPropertyName = "Message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn1, "messageDataGridViewTextBoxColumn1");
            this.messageDataGridViewTextBoxColumn1.Name = "messageDataGridViewTextBoxColumn1";
            // 
            // activeDataGridViewCheckBoxColumn1
            // 
            this.activeDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.activeDataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn1, "activeDataGridViewCheckBoxColumn1");
            this.activeDataGridViewCheckBoxColumn1.Name = "activeDataGridViewCheckBoxColumn1";
            // 
            // balloonTipDataGridViewCheckBoxColumn1
            // 
            this.balloonTipDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.balloonTipDataGridViewCheckBoxColumn1.DataPropertyName = "BalloonTip";
            resources.ApplyResources(this.balloonTipDataGridViewCheckBoxColumn1, "balloonTipDataGridViewCheckBoxColumn1");
            this.balloonTipDataGridViewCheckBoxColumn1.Name = "balloonTipDataGridViewCheckBoxColumn1";
            // 
            // soundDataGridViewCheckBoxColumn1
            // 
            this.soundDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soundDataGridViewCheckBoxColumn1.DataPropertyName = "Sound";
            resources.ApplyResources(this.soundDataGridViewCheckBoxColumn1, "soundDataGridViewCheckBoxColumn1");
            this.soundDataGridViewCheckBoxColumn1.Name = "soundDataGridViewCheckBoxColumn1";
            // 
            // popupDataGridViewCheckBoxColumn1
            // 
            this.popupDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.popupDataGridViewCheckBoxColumn1.DataPropertyName = "Popup";
            resources.ApplyResources(this.popupDataGridViewCheckBoxColumn1, "popupDataGridViewCheckBoxColumn1");
            this.popupDataGridViewCheckBoxColumn1.Name = "popupDataGridViewCheckBoxColumn1";
            // 
            // alarmTimeBindingSource
            // 
            this.alarmTimeBindingSource.DataSource = typeof(DS_Timer.Alarm.AlarmTime);
            // 
            // timeDataGridViewTextBoxColumn2
            // 
            this.timeDataGridViewTextBoxColumn2.DataPropertyName = "Time";
            resources.ApplyResources(this.timeDataGridViewTextBoxColumn2, "timeDataGridViewTextBoxColumn2");
            this.timeDataGridViewTextBoxColumn2.Name = "timeDataGridViewTextBoxColumn2";
            // 
            // messageDataGridViewTextBoxColumn3
            // 
            this.messageDataGridViewTextBoxColumn3.DataPropertyName = "Message";
            resources.ApplyResources(this.messageDataGridViewTextBoxColumn3, "messageDataGridViewTextBoxColumn3");
            this.messageDataGridViewTextBoxColumn3.Name = "messageDataGridViewTextBoxColumn3";
            // 
            // activeDataGridViewCheckBoxColumn3
            // 
            this.activeDataGridViewCheckBoxColumn3.DataPropertyName = "Active";
            resources.ApplyResources(this.activeDataGridViewCheckBoxColumn3, "activeDataGridViewCheckBoxColumn3");
            this.activeDataGridViewCheckBoxColumn3.Name = "activeDataGridViewCheckBoxColumn3";
            // 
            // balloonTipDataGridViewCheckBoxColumn3
            // 
            this.balloonTipDataGridViewCheckBoxColumn3.DataPropertyName = "Notification";
            resources.ApplyResources(this.balloonTipDataGridViewCheckBoxColumn3, "balloonTipDataGridViewCheckBoxColumn3");
            this.balloonTipDataGridViewCheckBoxColumn3.Name = "balloonTipDataGridViewCheckBoxColumn3";
            // 
            // soundDataGridViewCheckBoxColumn3
            // 
            this.soundDataGridViewCheckBoxColumn3.DataPropertyName = "Sound";
            resources.ApplyResources(this.soundDataGridViewCheckBoxColumn3, "soundDataGridViewCheckBoxColumn3");
            this.soundDataGridViewCheckBoxColumn3.Name = "soundDataGridViewCheckBoxColumn3";
            // 
            // popupDataGridViewCheckBoxColumn3
            // 
            this.popupDataGridViewCheckBoxColumn3.DataPropertyName = "Popup";
            resources.ApplyResources(this.popupDataGridViewCheckBoxColumn3, "popupDataGridViewCheckBoxColumn3");
            this.popupDataGridViewCheckBoxColumn3.Name = "popupDataGridViewCheckBoxColumn3";
            // 
            // UcAlarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcAlarm";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.gbEditAlarm.ResumeLayout(false);
            this.gbEditAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmTimeBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbEditAlarm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpAlarmTime;
		private System.Windows.Forms.TextBox txtAlarmMessage;
		private System.Windows.Forms.CheckBox cbPopup;
		private System.Windows.Forms.CheckBox cbAlarmSound;
		private System.Windows.Forms.CheckBox cbBaloon;
		private System.Windows.Forms.CheckBox cbAlarmEnabled;
		private System.Windows.Forms.Button btnSaveAlarm;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnTestSound;
		private System.Windows.Forms.DataGridView dgvAlarms;
		private System.Windows.Forms.BindingSource alarmTimeBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTimeLeft;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNextAlarm;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAlarms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn balloonTipDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn soundDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn popupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnRemoveOldAlarms;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn balloonTipDataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn soundDataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn popupDataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn balloonTipDataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn soundDataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn popupDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn balloonTipDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn soundDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn popupDataGridViewCheckBoxColumn3;
    }
}
