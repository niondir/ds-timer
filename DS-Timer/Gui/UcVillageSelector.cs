using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.AttackPlaner;
using DS_Timer.World;

namespace DS_Timer.Gui
{
	public partial class UcVillageSelector : UserControl
	{
		private LocationSelector m_LocationSelector = new LocationSelector();
		private AutoCompleteStringCollection m_PlayerNames = new AutoCompleteStringCollection();

		public VillageInfo SelectedVillage
		{
			get { return m_LocationSelector.SelectedVillage; }
		}

		public LocationSelector LocationSelector
		{
			get { return m_LocationSelector; }
		}

		public UcVillageSelector()
		{
			InitializeComponent();
			locationSelectorBindingSource.DataSource = m_LocationSelector;

			if (WorldHandler.PlayerFile != null)
			{
				foreach (PlayerInfo p in WorldHandler.PlayerFile.Players)
				{
					m_PlayerNames.Add(p.Name);
				}
			}


			txtPlayerName.AutoCompleteCustomSource = m_PlayerNames;
		}

		private void txtCoords_Validated(object sender, EventArgs e)
		{
			string locStr = AttackImportHelper.NormalizeLocation(txtCoords.Text);
			txtCoords.Text = locStr;

			Location locPos = AttackImportHelper.ParseLocation(locStr);

			m_LocationSelector.SetLocation(locPos);
		}

		private void cbStartVillageName_SelectedValueChanged(object sender, EventArgs e)
		{
			VillageInfo village = (VillageInfo)cbVillageName.SelectedItem;
			if (village != null)
			{
				txtCoords.Text = village.Location.X + "|" + village.Location.Y;
			}
			else
			{
				txtCoords.Text = "0|0";
			}
		}

		private void txtPlayerName_Validated(object sender, EventArgs e)
		{
			m_LocationSelector.SetPlayer(txtPlayerName.Text);
		}

		private void txtCoords_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(string)))
			{
				txtCoords.Text = (string)e.Data.GetData(typeof(string));
			}
		}

		private void txtCoords_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(string)))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}
	}
}
