namespace DS_Timer.Gui
{
	partial class UcAttackPlaner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAttackPlaner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAttacks = new System.Windows.Forms.DataGridView();
            this.RemainingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitSpeed = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackPlanHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAttacks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOrderAsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeToTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUrlToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.attackOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucStartVillageSelector = new DS_Timer.Gui.UcVillageSelector();
            this.ucTargetVillageSelector = new DS_Timer.Gui.UcVillageSelector();
            this.rbArrivle = new System.Windows.Forms.RadioButton();
            this.rbSend = new System.Windows.Forms.RadioButton();
            this.dtpArrivle = new System.Windows.Forms.DateTimePicker();
            this.numMs = new System.Windows.Forms.NumericUpDown();
            this.cbSlowestUnit = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.villageListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnAddVillage = new System.Windows.Forms.Button();
            this.ucVillageSelector = new DS_Timer.Gui.UcVillageSelector();
            this.btnImportVillages = new System.Windows.Forms.Button();
            this.btnNewVillageList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVillageList = new System.Windows.Forms.ComboBox();
            this.lbVillages = new System.Windows.Forms.ListBox();
            this.cmsVillages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVillageAsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVillageAsTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.villagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelAttackPlan = new System.Windows.Forms.Button();
            this.btnNewAttackPlan = new System.Windows.Forms.Button();
            this.cbAttackPlans = new System.Windows.Forms.ComboBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numMoveMs = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveAttackPlan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numAlarmTimeOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbDisplayInMiniTimer = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackPlanHandlerBindingSource)).BeginInit();
            this.cmsAttacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackPlansBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageListsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmsVillages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villagesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoveMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlarmTimeOffset)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttacks
            // 
            this.dgvAttacks.AllowUserToAddRows = false;
            this.dgvAttacks.AllowUserToResizeRows = false;
            this.dgvAttacks.AutoGenerateColumns = false;
            this.dgvAttacks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAttacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttacks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemainingTime,
            this.StartLocation,
            this.StartPlayer,
            this.TargetLocation,
            this.TargetPlayer,
            this.SendTime,
            this.ArrivleTime,
            this.UnitSpeed,
            this.commentDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAttacks, 3);
            this.dgvAttacks.ContextMenuStrip = this.cmsAttacks;
            this.dgvAttacks.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.attackOrderBindingSource, "ArrivleTime", true));
            this.dgvAttacks.DataSource = this.attackOrderBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttacks.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dgvAttacks, "dgvAttacks");
            this.dgvAttacks.Name = "dgvAttacks";
            this.dgvAttacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttacks.TabStop = false;
            this.dgvAttacks.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAttacks_CellBeginEdit);
            this.dgvAttacks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttacks_CellEndEdit);
            this.dgvAttacks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttacks_CellFormatting);
            this.dgvAttacks.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttacks_CellLeave);
            this.dgvAttacks.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgvAttacks_CellParsing);
            this.dgvAttacks.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttacks_ColumnHeaderMouseClick);
            this.dgvAttacks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAttacks_DataError);
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RemainingTime.DataPropertyName = "RemainingTimeString";
            dataGridViewCellStyle1.NullValue = null;
            this.RemainingTime.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.RemainingTime, "RemainingTime");
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.ReadOnly = true;
            // 
            // StartLocation
            // 
            this.StartLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartLocation.DataPropertyName = "StartLocation";
            resources.ApplyResources(this.StartLocation, "StartLocation");
            this.StartLocation.Name = "StartLocation";
            // 
            // StartPlayer
            // 
            this.StartPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartPlayer.DataPropertyName = "StartPlayer";
            resources.ApplyResources(this.StartPlayer, "StartPlayer");
            this.StartPlayer.Name = "StartPlayer";
            this.StartPlayer.ReadOnly = true;
            // 
            // TargetLocation
            // 
            this.TargetLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TargetLocation.DataPropertyName = "TargetLocation";
            resources.ApplyResources(this.TargetLocation, "TargetLocation");
            this.TargetLocation.Name = "TargetLocation";
            // 
            // TargetPlayer
            // 
            this.TargetPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TargetPlayer.DataPropertyName = "TargetPlayer";
            resources.ApplyResources(this.TargetPlayer, "TargetPlayer");
            this.TargetPlayer.Name = "TargetPlayer";
            this.TargetPlayer.ReadOnly = true;
            // 
            // SendTime
            // 
            this.SendTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SendTime.DataPropertyName = "SendTime";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm:ss.fff";
            this.SendTime.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.SendTime, "SendTime");
            this.SendTime.Name = "SendTime";
            // 
            // ArrivleTime
            // 
            this.ArrivleTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArrivleTime.DataPropertyName = "ArrivleTime";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm:ss.fff";
            this.ArrivleTime.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.ArrivleTime, "ArrivleTime");
            this.ArrivleTime.Name = "ArrivleTime";
            // 
            // UnitSpeed
            // 
            this.UnitSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitSpeed.DataPropertyName = "UnitId";
            this.UnitSpeed.DataSource = this.unitBindingSource;
            this.UnitSpeed.DisplayMember = "AdvancedShortName";
            resources.ApplyResources(this.UnitSpeed, "UnitSpeed");
            this.UnitSpeed.Name = "UnitSpeed";
            this.UnitSpeed.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Units";
            this.unitBindingSource.DataSource = this.attackPlanHandlerBindingSource;
            // 
            // attackPlanHandlerBindingSource
            // 
            this.attackPlanHandlerBindingSource.DataSource = typeof(DS_Timer.AttackPlaner.AttackPlanHandler);
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            resources.ApplyResources(this.commentDataGridViewTextBoxColumn, "commentDataGridViewTextBoxColumn");
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // cmsAttacks
            // 
            this.cmsAttacks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrderAsNew,
            this.tsmiTimeToTimer,
            this.tsmiUrlToClipboard,
            this.toolStripSeparator1,
            this.tsmiOpenInBrowser,
            this.tsmiCreateAlarm,
            this.tsmiExportSelected});
            this.cmsAttacks.Name = "cmsAttacks";
            resources.ApplyResources(this.cmsAttacks, "cmsAttacks");
            // 
            // tsmiOrderAsNew
            // 
            this.tsmiOrderAsNew.Image = global::DS_Timer.Properties.Resources.icons8_add_new_16;
            this.tsmiOrderAsNew.Name = "tsmiOrderAsNew";
            resources.ApplyResources(this.tsmiOrderAsNew, "tsmiOrderAsNew");
            this.tsmiOrderAsNew.Click += new System.EventHandler(this.tsmiOrderAsNew_Click);
            // 
            // tsmiTimeToTimer
            // 
            this.tsmiTimeToTimer.Image = global::DS_Timer.Properties.Resources.icons8_coming_soon_16;
            this.tsmiTimeToTimer.Name = "tsmiTimeToTimer";
            resources.ApplyResources(this.tsmiTimeToTimer, "tsmiTimeToTimer");
            this.tsmiTimeToTimer.Click += new System.EventHandler(this.tsmiTimeToTimer_Click);
            // 
            // tsmiUrlToClipboard
            // 
            this.tsmiUrlToClipboard.Image = global::DS_Timer.Properties.Resources.icons8_copy_16;
            resources.ApplyResources(this.tsmiUrlToClipboard, "tsmiUrlToClipboard");
            this.tsmiUrlToClipboard.Name = "tsmiUrlToClipboard";
            this.tsmiUrlToClipboard.Click += new System.EventHandler(this.tsmiUrlToClipboard_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsmiOpenInBrowser
            // 
            this.tsmiOpenInBrowser.Image = global::DS_Timer.Properties.Resources.icons8_linking_16;
            this.tsmiOpenInBrowser.Name = "tsmiOpenInBrowser";
            resources.ApplyResources(this.tsmiOpenInBrowser, "tsmiOpenInBrowser");
            this.tsmiOpenInBrowser.Click += new System.EventHandler(this.tsmiOpenInBrowser_Click);
            // 
            // tsmiCreateAlarm
            // 
            this.tsmiCreateAlarm.Image = global::DS_Timer.Properties.Resources.icons8_alarm_16;
            this.tsmiCreateAlarm.Name = "tsmiCreateAlarm";
            resources.ApplyResources(this.tsmiCreateAlarm, "tsmiCreateAlarm");
            this.tsmiCreateAlarm.Click += new System.EventHandler(this.tsmiCreateAlarm_Click);
            // 
            // tsmiExportSelected
            // 
            this.tsmiExportSelected.Image = global::DS_Timer.Properties.Resources.icons8_export_16;
            this.tsmiExportSelected.Name = "tsmiExportSelected";
            resources.ApplyResources(this.tsmiExportSelected, "tsmiExportSelected");
            this.tsmiExportSelected.Click += new System.EventHandler(this.tsmiExportSelected_Click);
            // 
            // attackOrderBindingSource
            // 
            this.attackOrderBindingSource.DataMember = "AttackOrders";
            this.attackOrderBindingSource.DataSource = this.attackPlansBindingSource;
            // 
            // attackPlansBindingSource
            // 
            this.attackPlansBindingSource.DataMember = "AttackPlans";
            this.attackPlansBindingSource.DataSource = this.attackPlanHandlerBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucStartVillageSelector);
            this.groupBox1.Controls.Add(this.ucTargetVillageSelector);
            this.groupBox1.Controls.Add(this.rbArrivle);
            this.groupBox1.Controls.Add(this.rbSend);
            this.groupBox1.Controls.Add(this.dtpArrivle);
            this.groupBox1.Controls.Add(this.numMs);
            this.groupBox1.Controls.Add(this.cbSlowestUnit);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ucStartVillageSelector
            // 
            resources.ApplyResources(this.ucStartVillageSelector, "ucStartVillageSelector");
            this.ucStartVillageSelector.Name = "ucStartVillageSelector";
            // 
            // ucTargetVillageSelector
            // 
            resources.ApplyResources(this.ucTargetVillageSelector, "ucTargetVillageSelector");
            this.ucTargetVillageSelector.Name = "ucTargetVillageSelector";
            // 
            // rbArrivle
            // 
            resources.ApplyResources(this.rbArrivle, "rbArrivle");
            this.rbArrivle.Checked = true;
            this.rbArrivle.Name = "rbArrivle";
            this.rbArrivle.TabStop = true;
            this.toolTip.SetToolTip(this.rbArrivle, resources.GetString("rbArrivle.ToolTip"));
            this.rbArrivle.UseVisualStyleBackColor = true;
            // 
            // rbSend
            // 
            resources.ApplyResources(this.rbSend, "rbSend");
            this.rbSend.Name = "rbSend";
            this.rbSend.TabStop = true;
            this.toolTip.SetToolTip(this.rbSend, resources.GetString("rbSend.ToolTip"));
            this.rbSend.UseVisualStyleBackColor = true;
            // 
            // dtpArrivle
            // 
            resources.ApplyResources(this.dtpArrivle, "dtpArrivle");
            this.dtpArrivle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivle.Name = "dtpArrivle";
            this.dtpArrivle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpArrivle_KeyDown);
            // 
            // numMs
            // 
            resources.ApplyResources(this.numMs, "numMs");
            this.numMs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMs.Name = "numMs";
            // 
            // cbSlowestUnit
            // 
            this.cbSlowestUnit.DataSource = this.unitBindingSource;
            this.cbSlowestUnit.DisplayMember = "AdvancedName";
            this.cbSlowestUnit.FormattingEnabled = true;
            resources.ApplyResources(this.cbSlowestUnit, "cbSlowestUnit");
            this.cbSlowestUnit.Name = "cbSlowestUnit";
            this.cbSlowestUnit.ValueMember = "Id";
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Image = global::DS_Timer.Properties.Resources.icons8_add_16;
            resources.ApplyResources(this.btnAddOrder, "btnAddOrder");
            this.btnAddOrder.Name = "btnAddOrder";
            this.toolTip.SetToolTip(this.btnAddOrder, resources.GetString("btnAddOrder.ToolTip"));
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // villageListsBindingSource
            // 
            this.villageListsBindingSource.DataMember = "VillageLists";
            this.villageListsBindingSource.DataSource = this.attackPlanHandlerBindingSource;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAttacks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAttackPlan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteList);
            this.groupBox2.Controls.Add(this.btnAddVillage);
            this.groupBox2.Controls.Add(this.ucVillageSelector);
            this.groupBox2.Controls.Add(this.btnImportVillages);
            this.groupBox2.Controls.Add(this.btnNewVillageList);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbVillageList);
            this.groupBox2.Controls.Add(this.lbVillages);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnDeleteList
            // 
            resources.ApplyResources(this.btnDeleteList, "btnDeleteList");
            this.btnDeleteList.Image = global::DS_Timer.Properties.Resources.icons8_minus_16;
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnAddVillage
            // 
            resources.ApplyResources(this.btnAddVillage, "btnAddVillage");
            this.btnAddVillage.Image = global::DS_Timer.Properties.Resources.icons8_add_16;
            this.btnAddVillage.Name = "btnAddVillage";
            this.toolTip.SetToolTip(this.btnAddVillage, resources.GetString("btnAddVillage.ToolTip"));
            this.btnAddVillage.UseVisualStyleBackColor = true;
            this.btnAddVillage.Click += new System.EventHandler(this.btnAddVillage_Click);
            // 
            // ucVillageSelector
            // 
            resources.ApplyResources(this.ucVillageSelector, "ucVillageSelector");
            this.ucVillageSelector.Name = "ucVillageSelector";
            // 
            // btnImportVillages
            // 
            resources.ApplyResources(this.btnImportVillages, "btnImportVillages");
            this.btnImportVillages.Image = global::DS_Timer.Properties.Resources.icons8_import_16;
            this.btnImportVillages.Name = "btnImportVillages";
            this.toolTip.SetToolTip(this.btnImportVillages, resources.GetString("btnImportVillages.ToolTip"));
            this.btnImportVillages.UseVisualStyleBackColor = true;
            this.btnImportVillages.Click += new System.EventHandler(this.btnImportVillages_Click);
            // 
            // btnNewVillageList
            // 
            resources.ApplyResources(this.btnNewVillageList, "btnNewVillageList");
            this.btnNewVillageList.Image = global::DS_Timer.Properties.Resources.icons8_add_16;
            this.btnNewVillageList.Name = "btnNewVillageList";
            this.toolTip.SetToolTip(this.btnNewVillageList, resources.GetString("btnNewVillageList.ToolTip"));
            this.btnNewVillageList.UseVisualStyleBackColor = true;
            this.btnNewVillageList.Click += new System.EventHandler(this.btnNewVillageList_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbVillageList
            // 
            resources.ApplyResources(this.cbVillageList, "cbVillageList");
            this.cbVillageList.DataSource = this.villageListsBindingSource;
            this.cbVillageList.FormattingEnabled = true;
            this.cbVillageList.Name = "cbVillageList";
            this.toolTip.SetToolTip(this.cbVillageList, resources.GetString("cbVillageList.ToolTip"));
            this.cbVillageList.SelectedIndexChanged += new System.EventHandler(this.cbVillageList_SelectedIndexChanged);
            this.cbVillageList.TextUpdate += new System.EventHandler(this.cbVillageList_TextUpdate);
            // 
            // lbVillages
            // 
            resources.ApplyResources(this.lbVillages, "lbVillages");
            this.lbVillages.ContextMenuStrip = this.cmsVillages;
            this.lbVillages.DataSource = this.villagesBindingSource;
            this.lbVillages.DisplayMember = "LongName";
            this.lbVillages.FormattingEnabled = true;
            this.lbVillages.Name = "lbVillages";
            this.toolTip.SetToolTip(this.lbVillages, resources.GetString("lbVillages.ToolTip"));
            this.lbVillages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbVillages_KeyDown);
            // 
            // cmsVillages
            // 
            this.cmsVillages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVillageAsStart,
            this.tsmiVillageAsTarget});
            this.cmsVillages.Name = "cmsVillages";
            resources.ApplyResources(this.cmsVillages, "cmsVillages");
            // 
            // tsmiVillageAsStart
            // 
            this.tsmiVillageAsStart.Image = global::DS_Timer.Properties.Resources.icons8_arrow_pointing_left_16;
            this.tsmiVillageAsStart.Name = "tsmiVillageAsStart";
            resources.ApplyResources(this.tsmiVillageAsStart, "tsmiVillageAsStart");
            this.tsmiVillageAsStart.Click += new System.EventHandler(this.tsmiVillageAsStart_Click);
            // 
            // tsmiVillageAsTarget
            // 
            this.tsmiVillageAsTarget.Image = global::DS_Timer.Properties.Resources.icons8_arrow_16;
            this.tsmiVillageAsTarget.Name = "tsmiVillageAsTarget";
            resources.ApplyResources(this.tsmiVillageAsTarget, "tsmiVillageAsTarget");
            this.tsmiVillageAsTarget.Click += new System.EventHandler(this.tsmiVillageAsTarget_Click);
            // 
            // villagesBindingSource
            // 
            this.villagesBindingSource.DataMember = "Villages";
            this.villagesBindingSource.DataSource = this.villageListsBindingSource;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnDelAttackPlan);
            this.panel1.Controls.Add(this.btnNewAttackPlan);
            this.panel1.Controls.Add(this.cbAttackPlans);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.numDays);
            this.panel1.Controls.Add(this.btnMoveSelected);
            this.panel1.Controls.Add(this.numHours);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.numMoveMs);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.numSec);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Name = "panel1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnDelAttackPlan
            // 
            this.btnDelAttackPlan.Image = global::DS_Timer.Properties.Resources.icons8_minus_16;
            resources.ApplyResources(this.btnDelAttackPlan, "btnDelAttackPlan");
            this.btnDelAttackPlan.Name = "btnDelAttackPlan";
            this.toolTip.SetToolTip(this.btnDelAttackPlan, resources.GetString("btnDelAttackPlan.ToolTip"));
            this.btnDelAttackPlan.UseVisualStyleBackColor = true;
            this.btnDelAttackPlan.Click += new System.EventHandler(this.btnDelAttackPlan_Click);
            // 
            // btnNewAttackPlan
            // 
            this.btnNewAttackPlan.Image = global::DS_Timer.Properties.Resources.icons8_add_16;
            resources.ApplyResources(this.btnNewAttackPlan, "btnNewAttackPlan");
            this.btnNewAttackPlan.Name = "btnNewAttackPlan";
            this.toolTip.SetToolTip(this.btnNewAttackPlan, resources.GetString("btnNewAttackPlan.ToolTip"));
            this.btnNewAttackPlan.UseVisualStyleBackColor = true;
            this.btnNewAttackPlan.Click += new System.EventHandler(this.btnNewAttackPlan_Click);
            // 
            // cbAttackPlans
            // 
            this.cbAttackPlans.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.attackPlanHandlerBindingSource, "CurrentAttackPlan", true));
            this.cbAttackPlans.DataSource = this.attackPlansBindingSource;
            this.cbAttackPlans.DisplayMember = "Name";
            this.cbAttackPlans.FormattingEnabled = true;
            resources.ApplyResources(this.cbAttackPlans, "cbAttackPlans");
            this.cbAttackPlans.Name = "cbAttackPlans";
            this.cbAttackPlans.TextUpdate += new System.EventHandler(this.cbAttackPlans_TextUpdate);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::DS_Timer.Properties.Resources.icons8_list_16;
            resources.ApplyResources(this.btnSelectAll, "btnSelectAll");
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseCompatibleTextRendering = true;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // numDays
            // 
            resources.ApplyResources(this.numDays, "numDays");
            this.numDays.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDays.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numDays.Name = "numDays";
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.Image = global::DS_Timer.Properties.Resources.icons8_double_right_16;
            resources.ApplyResources(this.btnMoveSelected, "btnMoveSelected");
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.UseCompatibleTextRendering = true;
            this.btnMoveSelected.UseVisualStyleBackColor = true;
            this.btnMoveSelected.Click += new System.EventHandler(this.btnMoveSelected_Click);
            // 
            // numHours
            // 
            resources.ApplyResources(this.numHours, "numHours");
            this.numHours.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numHours.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numHours.Name = "numHours";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // numMin
            // 
            resources.ApplyResources(this.numMin, "numMin");
            this.numMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMin.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numMin.Name = "numMin";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // numMoveMs
            // 
            resources.ApplyResources(this.numMoveMs, "numMoveMs");
            this.numMoveMs.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMoveMs.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numMoveMs.Name = "numMoveMs";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // numSec
            // 
            resources.ApplyResources(this.numSec, "numSec");
            this.numSec.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numSec.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numSec.Name = "numSec";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnSaveAttackPlan
            // 
            resources.ApplyResources(this.btnSaveAttackPlan, "btnSaveAttackPlan");
            this.tableLayoutPanel1.SetColumnSpan(this.btnSaveAttackPlan, 2);
            this.btnSaveAttackPlan.Image = global::DS_Timer.Properties.Resources.icons8_save_16;
            this.btnSaveAttackPlan.Name = "btnSaveAttackPlan";
            this.btnSaveAttackPlan.UseVisualStyleBackColor = true;
            this.btnSaveAttackPlan.Click += new System.EventHandler(this.btnSaveAttackPlan_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.numAlarmTimeOffset);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // numAlarmTimeOffset
            // 
            this.numAlarmTimeOffset.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DS_Timer.Properties.Settings.Default, "CreateAlarmOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.numAlarmTimeOffset, "numAlarmTimeOffset");
            this.numAlarmTimeOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAlarmTimeOffset.Name = "numAlarmTimeOffset";
            this.numAlarmTimeOffset.Value = global::DS_Timer.Properties.Settings.Default.CreateAlarmOffset;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDisplayInMiniTimer,
            this.tsbImport});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // tsbDisplayInMiniTimer
            // 
            this.tsbDisplayInMiniTimer.Image = global::DS_Timer.Properties.Resources.icons8_coming_soon_16;
            resources.ApplyResources(this.tsbDisplayInMiniTimer, "tsbDisplayInMiniTimer");
            this.tsbDisplayInMiniTimer.Name = "tsbDisplayInMiniTimer";
            this.tsbDisplayInMiniTimer.Click += new System.EventHandler(this.tsbDisplayInMiniTimer_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::DS_Timer.Properties.Resources.icons8_import_16;
            resources.ApplyResources(this.tsbImport, "tsbImport");
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // UcAttackPlaner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "UcAttackPlaner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackPlanHandlerBindingSource)).EndInit();
            this.cmsAttacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attackOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackPlansBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageListsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsVillages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.villagesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoveMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlarmTimeOffset)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAttacks;
		private System.Windows.Forms.BindingSource attackOrderBindingSource;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbSlowestUnit;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpArrivle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Button btnAddOrder;
		private System.Windows.Forms.BindingSource unitBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMs;
        private System.Windows.Forms.Button btnSaveAttackPlan;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAlarmTimeOffset;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHours;
		private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMoveSelected;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMoveMs;
        private System.Windows.Forms.RadioButton rbArrivle;
        private System.Windows.Forms.RadioButton rbSend;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ContextMenuStrip cmsAttacks;
		private System.Windows.Forms.ToolStripMenuItem tsmiUrlToClipboard;
		private System.Windows.Forms.ToolStripMenuItem tsmiCreateAlarm;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpenInBrowser;
		private System.Windows.Forms.ToolStripMenuItem tsmiTimeToTimer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ToolStripMenuItem tsmiExportSelected;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton tsbDisplayInMiniTimer;
		private System.Windows.Forms.ToolStripButton tsbImport;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.ComboBox cbVillageList;
		private System.Windows.Forms.ListBox lbVillages;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnImportVillages;
		private System.Windows.Forms.Button btnNewVillageList;
		private System.Windows.Forms.BindingSource attackPlanHandlerBindingSource;
		private System.Windows.Forms.BindingSource villageListsBindingSource;
		private System.Windows.Forms.BindingSource villagesBindingSource;
		private UcVillageSelector ucVillageSelector;
		private System.Windows.Forms.Button btnAddVillage;
		private UcVillageSelector ucStartVillageSelector;
		private UcVillageSelector ucTargetVillageSelector;
		private System.Windows.Forms.Button btnDeleteList;
		private System.Windows.Forms.ContextMenuStrip cmsVillages;
		private System.Windows.Forms.ToolStripMenuItem tsmiVillageAsStart;
		private System.Windows.Forms.ToolStripMenuItem tsmiVillageAsTarget;
		private System.Windows.Forms.Button btnDelAttackPlan;
		private System.Windows.Forms.Button btnNewAttackPlan;
		private System.Windows.Forms.ComboBox cbAttackPlans;
		private System.Windows.Forms.BindingSource attackPlansBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
		private System.Windows.Forms.ToolStripMenuItem tsmiOrderAsNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn RemainingTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartLocation;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartPlayer;
		private System.Windows.Forms.DataGridViewTextBoxColumn TargetLocation;
		private System.Windows.Forms.DataGridViewTextBoxColumn TargetPlayer;
		private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ArrivleTime;
		private System.Windows.Forms.DataGridViewComboBoxColumn UnitSpeed;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}
