using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.World;

namespace DS_Timer.Gui
{
	public partial class DialogAddServer : Form
	{
		public DialogAddServer(BindingSource serverBindingSource)
		{
			InitializeComponent();
			this.serverBindingSource = serverBindingSource;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			serverBindingSource.Add(new Server(this.txtName.Text, this.txtUrl.Text));
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
