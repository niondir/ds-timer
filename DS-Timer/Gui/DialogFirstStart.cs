using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS_Timer.Gui
{
	public partial class DialogFirstStart : Form
	{
		public DialogFirstStart()
		{
			InitializeComponent();
		}

		private void DialogFirstStart_Load(object sender, EventArgs e)
		{
			
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
