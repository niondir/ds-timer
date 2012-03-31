namespace DS_Timer.Gui
{
	partial class FormClockOnTop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClockOnTop));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cbBlink = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numNextTimeMs = new System.Windows.Forms.NumericUpDown();
			this.dtpNextAttack = new System.Windows.Forms.DateTimePicker();
			this.timeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.timeToNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.txtCountdown = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numNextTimeMs)).BeginInit();
			this.timeContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.TabStop = false;
			this.toolTip.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			// 
			// cbBlink
			// 
			resources.ApplyResources(this.cbBlink, "cbBlink");
			this.cbBlink.Checked = global::DS_Timer.Properties.Settings.Default.BlinkEnabled;
			this.cbBlink.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DS_Timer.Properties.Settings.Default, "BlinkEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbBlink.Name = "cbBlink";
			this.toolTip.SetToolTip(this.cbBlink, resources.GetString("cbBlink.ToolTip"));
			this.cbBlink.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			resources.ApplyResources(this.btnSave, "btnSave");
			this.btnSave.BackgroundImage = global::DS_Timer.Properties.Resources.disk;
			this.btnSave.Name = "btnSave";
			this.toolTip.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			// 
			// numNextTimeMs
			// 
			resources.ApplyResources(this.numNextTimeMs, "numNextTimeMs");
			this.numNextTimeMs.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DS_Timer.Properties.Settings.Default, "HighlightOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numNextTimeMs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numNextTimeMs.Name = "numNextTimeMs";
			this.toolTip.SetToolTip(this.numNextTimeMs, resources.GetString("numNextTimeMs.ToolTip"));
			this.numNextTimeMs.Value = global::DS_Timer.Properties.Settings.Default.HighlightOffset;
			// 
			// dtpNextAttack
			// 
			resources.ApplyResources(this.dtpNextAttack, "dtpNextAttack");
			this.dtpNextAttack.ContextMenuStrip = this.timeContextMenu;
			this.dtpNextAttack.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DS_Timer.Properties.Settings.Default, "NextAttack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dtpNextAttack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNextAttack.Name = "dtpNextAttack";
			this.toolTip.SetToolTip(this.dtpNextAttack, resources.GetString("dtpNextAttack.ToolTip"));
			this.dtpNextAttack.Value = global::DS_Timer.Properties.Settings.Default.NextAttack;
			this.dtpNextAttack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNextAttack_KeyDown);
			// 
			// timeContextMenu
			// 
			resources.ApplyResources(this.timeContextMenu, "timeContextMenu");
			this.timeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToNowToolStripMenuItem});
			this.timeContextMenu.Name = "timeContextMenu";
			this.toolTip.SetToolTip(this.timeContextMenu, resources.GetString("timeContextMenu.ToolTip"));
			// 
			// timeToNowToolStripMenuItem
			// 
			resources.ApplyResources(this.timeToNowToolStripMenuItem, "timeToNowToolStripMenuItem");
			this.timeToNowToolStripMenuItem.Name = "timeToNowToolStripMenuItem";
			this.timeToNowToolStripMenuItem.Click += new System.EventHandler(this.timeToNowToolStripMenuItem_Click);
			// 
			// txtNote
			// 
			resources.ApplyResources(this.txtNote, "txtNote");
			this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DS_Timer.Properties.Settings.Default, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtNote.Name = "txtNote";
			this.txtNote.Text = global::DS_Timer.Properties.Settings.Default.Note;
			this.toolTip.SetToolTip(this.txtNote, resources.GetString("txtNote.ToolTip"));
			// 
			// txtCountdown
			// 
			resources.ApplyResources(this.txtCountdown, "txtCountdown");
			this.txtCountdown.Name = "txtCountdown";
			this.txtCountdown.ReadOnly = true;
			this.txtCountdown.TabStop = false;
			this.toolTip.SetToolTip(this.txtCountdown, resources.GetString("txtCountdown.ToolTip"));
			// 
			// FormClockOnTop
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtCountdown);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numNextTimeMs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpNextAttack);
			this.Controls.Add(this.cbBlink);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormClockOnTop";
			this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ClockOnTop_Load);
			((System.ComponentModel.ISupportInitialize)(this.numNextTimeMs)).EndInit();
			this.timeContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbBlink;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.DateTimePicker dtpNextAttack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.NumericUpDown numNextTimeMs;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip timeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem timeToNowToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCountdown;
	}
}