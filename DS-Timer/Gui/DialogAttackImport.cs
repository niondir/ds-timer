using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.AttackPlaner;

namespace DS_Timer.Gui
{
	public partial class DialogAttackImport : Form
	{
		List<AttackOrder> m_ImportedOrders = new List<AttackOrder>();

		public List<AttackOrder> ImportedOrders
		{
			get { return m_ImportedOrders; }
			set { m_ImportedOrders = value; }
		}

		public DialogAttackImport()
		{
			InitializeComponent();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			AttackImportHelper import = new AttackImportHelper();

            if (rbDsReal.Checked)
            {
                ImportedOrders = import.ImportFromDSReal(rtbInput.Text);
                DialogResult = DialogResult.OK;
            }
            else if (rbWorkbench.Checked)
            {
                ImportedOrders = import.ImportFromWorkbench(rtbInput.Text);
                DialogResult = DialogResult.OK;
            }
            else if (rbDsMap.Checked)
            {
                ImportedOrders = import.ImportFromDsMap(rtbInput.Text);
                DialogResult = DialogResult.OK;
            }
			else if (rbDSTimer.Checked)
			{
				ImportedOrders = import.ImportFromDSTimer(rtbInput.Text);
				DialogResult = DialogResult.OK;
			}
		}

	}
}
