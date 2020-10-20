using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.AttackPlaner;
using DS_Timer.Properties;

namespace DS_Timer.Gui
{
	public partial class DialogAttackExport : Form
	{
		private List<AttackOrder> m_Attacks;

		public DialogAttackExport(List<AttackOrder> attacks)
		{
			InitializeComponent();
			m_Attacks = attacks;
			//m_Attacks.AddRange(attacks);
			ExportToBB();
		}

		public DialogAttackExport(BindingList<AttackOrder> attacks)
		{
			InitializeComponent();
			m_Attacks.AddRange(attacks);
			ExportToBB();
		}

		private void ExportToBB()
		{
			rtbOutput.Clear();
			m_Attacks.Sort((a, b) => a.SendTime.CompareTo(b.SendTime));
			foreach (AttackOrder o in m_Attacks)
			{
				string line = String.Format("[b]{2:dd.MM.yyyy - HH:mm:ss:fff}[/b] [coord]{0}[/coord] -> [coord]{1}[/coord] | [unit]{5}[/unit] | {4} [url={3}]Go To Rally Point[/url]", o.StartLocation, o.TargetLocation, o.SendTime, o.GetAttackUrl(Settings.Default.DSServer), o.Comment, o.Unit.ShortName.ToLower());
				rtbOutput.AppendText(line + Environment.NewLine);
			}
		}

		private void rbFormatBB_CheckedChanged(object sender, EventArgs e)
		{
			if (rbFormatBB.Checked)
			{
				ExportToBB();
			}
		}

		private void tsbCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbOutput.Text);
		}

		private void rtbOutput_MouseClick(object sender, MouseEventArgs e)
		{
			rtbOutput.SelectAll();
		}
	}
}
