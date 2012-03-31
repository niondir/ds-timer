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

		private void linkNiondirProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://de68.die-staemme.de/page.php?page=inbound&screen=info_player&id=8972307");
		}

		private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.niondir.de");
		}
	}
}
