namespace DS_Timer.Gui
{
	partial class FormAlarm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlarm));
			this.ucAlarm = new DS_Timer.Gui.UcAlarm();
			this.SuspendLayout();
			// 
			// ucAlarm
			// 
			this.ucAlarm.AlarmHandler = null;
			resources.ApplyResources(this.ucAlarm, "ucAlarm");
			this.ucAlarm.Name = "ucAlarm";
			// 
			// FormAlarm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucAlarm);
			this.Name = "FormAlarm";
			this.ResumeLayout(false);

		}

		#endregion

		private UcAlarm ucAlarm;
	}
}