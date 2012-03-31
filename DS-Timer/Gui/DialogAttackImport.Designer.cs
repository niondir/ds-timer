namespace DS_Timer.Gui
{
	partial class DialogAttackImport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAttackImport));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbDSTimer = new System.Windows.Forms.RadioButton();
			this.rbDsMap = new System.Windows.Forms.RadioButton();
			this.rbWorkbench = new System.Windows.Forms.RadioButton();
			this.rbDsReal = new System.Windows.Forms.RadioButton();
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImport = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.rbDSTimer);
			this.groupBox1.Controls.Add(this.rbDsMap);
			this.groupBox1.Controls.Add(this.rbWorkbench);
			this.groupBox1.Controls.Add(this.rbDsReal);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			this.toolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
			// 
			// rbDSTimer
			// 
			resources.ApplyResources(this.rbDSTimer, "rbDSTimer");
			this.rbDSTimer.Checked = true;
			this.rbDSTimer.Name = "rbDSTimer";
			this.rbDSTimer.TabStop = true;
			this.toolTip.SetToolTip(this.rbDSTimer, resources.GetString("rbDSTimer.ToolTip"));
			this.rbDSTimer.UseVisualStyleBackColor = true;
			// 
			// rbDsMap
			// 
			resources.ApplyResources(this.rbDsMap, "rbDsMap");
			this.rbDsMap.Name = "rbDsMap";
			this.toolTip.SetToolTip(this.rbDsMap, resources.GetString("rbDsMap.ToolTip"));
			this.rbDsMap.UseVisualStyleBackColor = true;
			// 
			// rbWorkbench
			// 
			resources.ApplyResources(this.rbWorkbench, "rbWorkbench");
			this.rbWorkbench.Name = "rbWorkbench";
			this.toolTip.SetToolTip(this.rbWorkbench, resources.GetString("rbWorkbench.ToolTip"));
			this.rbWorkbench.UseVisualStyleBackColor = true;
			// 
			// rbDsReal
			// 
			resources.ApplyResources(this.rbDsReal, "rbDsReal");
			this.rbDsReal.Name = "rbDsReal";
			this.toolTip.SetToolTip(this.rbDsReal, resources.GetString("rbDsReal.ToolTip"));
			this.rbDsReal.UseVisualStyleBackColor = true;
			// 
			// rtbInput
			// 
			resources.ApplyResources(this.rtbInput, "rtbInput");
			this.rtbInput.Name = "rtbInput";
			this.toolTip.SetToolTip(this.rtbInput, resources.GetString("rtbInput.ToolTip"));
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			// 
			// btnImport
			// 
			resources.ApplyResources(this.btnImport, "btnImport");
			this.btnImport.Name = "btnImport";
			this.toolTip.SetToolTip(this.btnImport, resources.GetString("btnImport.ToolTip"));
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.rtbInput, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnImport, 0, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.toolTip.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 0;
			// 
			// DialogAttackImport
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DialogAttackImport";
			this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDsReal;
		private System.Windows.Forms.RichTextBox rtbInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbWorkbench;
        private System.Windows.Forms.RadioButton rbDsMap;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.RadioButton rbDSTimer;
	}
}