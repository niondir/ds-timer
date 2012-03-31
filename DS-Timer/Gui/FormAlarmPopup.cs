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
	public partial class FormAlarmPopup : Form
	{
		public FormAlarmPopup(String message)
		{
			InitializeComponent();
			lblMessage.Text = message;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
