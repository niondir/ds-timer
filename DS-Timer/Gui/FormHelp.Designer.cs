namespace DS_Timer.Gui
{
	partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkBugtracker = new System.Windows.Forms.LinkLabel();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblEditorName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.donateButton1 = new DS_Timer.Gui.DonateButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgrammerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkBugtracker
            // 
            resources.ApplyResources(this.linkBugtracker, "linkBugtracker");
            this.linkBugtracker.Name = "linkBugtracker";
            this.linkBugtracker.TabStop = true;
            this.linkBugtracker.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBugtracker_LinkClicked);
            // 
            // linkWebsite
            // 
            resources.ApplyResources(this.linkWebsite, "linkWebsite");
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.TabStop = true;
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // lblEditorName
            // 
            resources.ApplyResources(this.lblEditorName, "lblEditorName");
            this.lblEditorName.Name = "lblEditorName";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkWebsite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkBugtracker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEditorName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProgrammerName, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.gbAbout, "gbAbout");
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.TabStop = false;
            // 
            // donateButton1
            // 
            resources.ApplyResources(this.donateButton1, "donateButton1");
            this.donateButton1.Name = "donateButton1";
            this.donateButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblProgrammerName
            // 
            resources.ApplyResources(this.lblProgrammerName, "lblProgrammerName");
            this.lblProgrammerName.Name = "lblProgrammerName";
            // 
            // FormHelp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.donateButton1);
            this.Controls.Add(this.gbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkBugtracker;
		private System.Windows.Forms.LinkLabel linkWebsite;
		private System.Windows.Forms.Label lblEditorName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox gbAbout;
		private DonateButton donateButton1;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProgrammerName;
    }
}