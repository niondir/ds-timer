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
			Process.Start("https://bitbucket.org/Niondir/ds-timer/issues?status=new&status=open");
		}

		private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.niondir.de");
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
