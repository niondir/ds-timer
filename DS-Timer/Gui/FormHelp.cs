using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DS_Timer.Gui
{
	public partial class FormHelp : Form
	{
		public FormHelp()
		{
			InitializeComponent();
		}

		private void linkBugtracker_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/Niondir/ds-timer/issues");
		}

		private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/Niondir/ds-timer");
		}

		private void linkIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://icons8.com/");
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
