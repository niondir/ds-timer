using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.AttackPlaner;
using System.Text.RegularExpressions;
using DS_Timer.Alarm;
using DS_Timer.World;
using DS_Timer.Properties;
using DS_Timer.Util;
using DS_Timer.TimeSync;

namespace DS_Timer.Gui
{
	public partial class UcAttackPlaner : UserControl
	{
        // Image: http://social.msdn.microsoft.com/forums/en-US/winformsdatacontrols/thread/1f41f16d-17a9-4c52-92cf-3de9426a2dd7

        private bool m_initialized = false;
		private AttackPlanHandler m_AttackHandler;
        private AlarmHandler m_AlarmHandler;
        private WorldHandler m_WorldHandler;
        private LocationSelector m_TargetLocationSelector = new LocationSelector();
        private LocationSelector m_StartLocationSelector = new LocationSelector();

        private AutoCompleteStringCollection m_VillageNames = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection m_PlayerNames = new AutoCompleteStringCollection();

        private Timer m_UpdateTimer = new Timer();

		public AttackPlanHandler AttackHandler
		{
			get { return m_AttackHandler; }
			set
			{
				m_AttackHandler = value;
				if (m_AttackHandler == null)
				{
					//attackOrderBindingSource.DataSource = null;
					//unitBindingSource.DataSource = null;
					return;
				}

				attackPlanHandlerBindingSource.DataSource = m_AttackHandler;

				//unitBindingSource.DataSource = m_AttackHandler.Units;
				//attackOrderBindingSource.DataSource = m_AttackHandler.AttackOrders;
                btnSaveAttackPlan.Enabled = false;
			}
		}

		private List<AttackOrder> SelectedOrders
		{
			get
			{
				List<AttackOrder> orders = new List<AttackOrder>();
				foreach (DataGridViewRow row in dgvAttacks.SelectedRows)
				{
					if (row.DataBoundItem is AttackOrder)
					{
						AttackOrder order = (AttackOrder)row.DataBoundItem;
						orders.Add(order);
					}
				}
				return orders;
			}
		}

		private AttackOrder SelectedOrder
		{
			get
			{
				if (dgvAttacks.CurrentRow != null && dgvAttacks.CurrentRow.DataBoundItem is AttackOrder)
				{
					AttackOrder order = (AttackOrder)dgvAttacks.CurrentRow.DataBoundItem;
					return order;
				}
				return null;
			}
		}

		public UcAttackPlaner()
		{
			InitializeComponent();

            this.DoubleBuffered = true;

			
            attackOrderBindingSource.ListChanged += new ListChangedEventHandler(attackOrderBindingSource_ListChanged);
			villageListsBindingSource.ListChanged += new ListChangedEventHandler(villageListsBindingSource_ListChanged);
            m_UpdateTimer.Interval = 1000;
            m_UpdateTimer.Tick += new EventHandler(m_UpdateTimer_Tick);
            m_UpdateTimer.Start();

			if (WorldHandler.PlayerFile != null)
			{
				foreach (PlayerInfo p in WorldHandler.PlayerFile.Players)
				{
					m_PlayerNames.Add(p.Name);
				}
			}
            /* Not needed
            foreach (VillageInfo v in WorldHandler.VillageFile.Villages)
            {
                m_VillageNames.Add(v.Name);
            }*/

        }

		

        void m_UpdateTimer_Tick(object sender, EventArgs e)
        {
			for (int i = 0; i < dgvAttacks.ColumnCount; i++)
			{
				dgvAttacks.InvalidateColumn(i);
			}
        }

        void attackOrderBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnSaveAttackPlan.Enabled = true;
        }

		void villageListsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnSaveAttackPlan.Enabled = true;
		}

        internal void InitializeUserControl(AttackPlanHandler attackPlanHandler, AlarmHandler alarmHandler, WorldHandler worldHandler)
        {
            if (m_initialized) return;
            m_initialized = true;
            AttackHandler = attackPlanHandler;
            m_AlarmHandler = alarmHandler;
            m_WorldHandler = worldHandler;
        }

		void dgvAttacks_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			if (dgvAttacks.Columns[e.ColumnIndex].Name == "StartLocation")
			{
				e.Value = AttackImportHelper.ParseLocation((string)e.Value);
				e.ParsingApplied = true;
			}
			if (dgvAttacks.Columns[e.ColumnIndex].Name == "TargetLocation")
			{
                e.Value = AttackImportHelper.ParseLocation((string)e.Value);
				e.ParsingApplied = true;
			}
		}


		void dgvAttacks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
            AttackOrder order = (AttackOrder)dgvAttacks.Rows[e.RowIndex].DataBoundItem;


			if (dgvAttacks.Columns[e.ColumnIndex].Name == "StartLocation")
			{
				if (e.Value == null) return;
				Location p = (Location)e.Value;

				e.Value = String.Format("({0}|{1}) {2}", p.X, p.Y, order.StartVilliage.Name);
				e.FormattingApplied = true;
			}

			if (dgvAttacks.Columns[e.ColumnIndex].Name == "TargetLocation")
			{
				if (e.Value == null) return;
				Location p = (Location)e.Value;

				e.Value = String.Format("({0}|{1}) {2}", p.X, p.Y, order.TargetVillage.Name);
				e.FormattingApplied = true;
			}

			if (order == null) return;
			if (TimeSyncHandler.Now.AddMinutes(5) < order.SendTime)
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.SelectionBackColor = Color.LightGreen;
            }
			else if (TimeSyncHandler.Now < order.SendTime)
            {
                e.CellStyle.BackColor = Color.Orange;
                e.CellStyle.SelectionBackColor = Color.Orange;
            }
            else
            {
                e.CellStyle.BackColor = Color.LightCoral;
                e.CellStyle.SelectionBackColor = Color.LightCoral;
            }

			/* Geht nicht
			if (dgvAttacks.Columns[e.ColumnIndex].Name.Equals("UnitSpeed"))
			{
				// Ensure that the value is a string.
				String stringValue = e.Value as string;
				if (stringValue == null) return;

				// Set the cell ToolTip to the text value.
				DataGridViewCell cell = dgvAttacks[e.ColumnIndex, e.RowIndex];
				cell.ToolTipText = stringValue;
	
				// Replace the string value with the image value.
				e.Value = System.Drawing.SystemIcons.Asterisk;
			}
			 * */
		}

		

		private void btnAddOrder_Click(object sender, EventArgs e)
		{
			AttackOrder order = new AttackOrder();

			DateTime time = dtpArrivle.Value;
			int ms = (int)numMs.Value;
            time = time.AddMilliseconds(-time.Millisecond + ms);

			order.StartLocation = ucStartVillageSelector.SelectedVillage.Location;
			order.TargetLocation = ucTargetVillageSelector.SelectedVillage.Location;
			order.UnitId = (int)cbSlowestUnit.SelectedValue;
			order.Comment = txtNote.Text;
			m_AttackHandler.CurrentAttackPlan.AttackOrders.Add(order);
			//attackOrderBindingSource.Add(order);

            if (rbSend.Checked)
            {
                order.SendTime = time;
            }
            else if (rbArrivle.Checked)
            {
                order.ArrivleTime = time;
            }
		}

		private void btnSnipe_Click(object sender, EventArgs e)
        {
			VillageList list = (VillageList)villageListsBindingSource.Current;

			if (list == null) return;

			foreach (VillageInfo startVill in list.Villages)
			{

				AttackOrder order = new AttackOrder();

				DateTime time = dtpArrivle.Value;
				int ms = (int)numMs.Value;
				time = time.AddMilliseconds(-time.Millisecond + ms);

				order.StartLocation = startVill.Location;
				order.TargetLocation = ucTargetVillageSelector.SelectedVillage.Location;
				order.UnitId = (int)cbSlowestUnit.SelectedValue;
				order.Comment = txtNote.Text;
				m_AttackHandler.CurrentAttackPlan.AttackOrders.Add(order);
				//attackOrderBindingSource.Add(order);

				order.ArrivleTime = time;

			}
		}



		private void btnSaveAttackPlan_Click(object sender, EventArgs e)
		{
			btnSaveAttackPlan.Enabled = false;
			m_AttackHandler.SaveAttackOrders();
		}

		private void dgvAttacks_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Exception is FormatException)
			{
				e.ThrowException = false;
				e.Cancel = false;
			}
		}	

		private void btnDisplayInMiniTimer_Click(object sender, EventArgs e)
		{
			AttackOrder order = m_AttackHandler.NextOrder;
			OrderToTimer(order);
		}

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttacks.SelectedRows)
            {
                if (row.DataBoundItem is AttackOrder)
                {
                    AttackOrder order = (AttackOrder)row.DataBoundItem;
                    order.ArrivleTime = order.ArrivleTime.Add(
                         TimeSpan.FromDays((double)numDays.Value)
                       + TimeSpan.FromHours((double)numHours.Value)
                       + TimeSpan.FromMinutes((double)numMin.Value)
                       + TimeSpan.FromSeconds((double)numSec.Value)
                       + TimeSpan.FromMilliseconds((double)numMoveMs.Value)
                       );
                }
            }
        }

        private void dgvAttacks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvAttacks.Columns[e.ColumnIndex];

            if (newColumn.SortMode == DataGridViewColumnSortMode.NotSortable) return;
            if (attackOrderBindingSource.SortDirection == ListSortDirection.Ascending)
            {
                newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                newColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending;

            }
        }

		private void tsmiUrlToClipboard_Click(object sender, EventArgs e)
		{
			AttackOrder order = SelectedOrder;

			if (order != null)
			{
				Clipboard.SetText(order.GetAttackUrl(Settings.Default.DSServer));
			}
		}

		private void tsmiCreateAlarm_Click(object sender, EventArgs e)
		{
            CreateAlarms();
		}

		private void tsmiOpenInBrowser_Click(object sender, EventArgs e)
		{
			OpenSelectedInBrowser();
		}

		

		private void tsmiTimeToTimer_Click(object sender, EventArgs e)
		{
			AttackOrder order = SelectedOrder;
			if (order != null)
			{
				OrderToTimer(order);
			}
		}

		private void OrderToTimer(AttackOrder order)
		{
			Settings.Default.NextAttack = order.SendTime;
			Settings.Default.Note = "* " + order.Comment;
			Settings.Default.Save();
		}

		private void OpenSelectedInBrowser()
		{
			foreach (DataGridViewRow row in dgvAttacks.SelectedRows)
			{
				if (row.DataBoundItem is AttackOrder)
				{
					AttackOrder order = (AttackOrder)row.DataBoundItem;
					m_AttackHandler.OpenBrowser(order);
				}
			}
		}

		private void CreateAlarms()
		{
			int minutesBefore = (int)numAlarmTimeOffset.Value;

            foreach (AttackOrder order in SelectedOrders)
			{
				string message = "* " + order.Comment;
				AlarmTime alarm = new AlarmTime(order.SendTime.AddMinutes(-minutesBefore), message);
				m_AlarmHandler.WatchAlarm(alarm);
			}
			m_AlarmHandler.SaveAlarms();
		}

		private void btnAttackImport_Click(object sender, EventArgs e)
		{
			ImportAttacks();
		}

		
   

		private void btnExportAll_Click(object sender, EventArgs e)
		{
			using (DialogAttackExport dialog = new DialogAttackExport(m_AttackHandler.CurrentAttackPlan.AttackOrders))
			{
				dialog.ShowDialog();
			}
		}

		private void tsmiExportSelected_Click(object sender, EventArgs e)
		{
			using (DialogAttackExport dialog = new DialogAttackExport(SelectedOrders))
			{
				dialog.ShowDialog();
			}
		}

		

		

		private void ImportAttacks()
		{
			using (DialogAttackImport dialog = new DialogAttackImport())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					foreach (AttackOrder o in dialog.ImportedOrders)
					{
						m_AttackHandler.CurrentAttackPlan.AttackOrders.Add(o);
					}
				}
			}
		}

		private void tsbImport_Click(object sender, EventArgs e)
		{
			ImportAttacks();
		}

		private void tsbDisplayInMiniTimer_Click(object sender, EventArgs e)
		{
			OrderToTimer(m_AttackHandler.NextOrder);
		}

		private void btnSelectAll_Click(object sender, EventArgs e)
		{
			dgvAttacks.SelectAll();
		}

		private void btnNewVillageList_Click(object sender, EventArgs e)
		{
			VillageList newList = new VillageList();
			m_AttackHandler.VillageLists.Add(newList);

			//cbVillageList.SelectedIndex = cbVillageList.Items.Count - 1;
		}

		private void btnDeleteList_Click(object sender, EventArgs e)
		{
			if (villageListsBindingSource.Current != null)
			{
				VillageList list = (VillageList)villageListsBindingSource.Current;
				m_AttackHandler.VillageLists.Remove(list);
			}
		}

		private void btnImportVillages_Click(object sender, EventArgs e)
		{
			if (!Clipboard.ContainsText())
			{
				if (Program.Language == LanguageType.English)
				{
					MessageBox.Show("To import first load a list of villages by using:\nStrg + c or Right Click -> Copy");
				}
				else
				{
					MessageBox.Show("Zum importieren erst eine Liste mit Dörfern in die Zwischenablage laden:\nStrg + c oder Rechtsklick -> Kopieren");
				}
					return;
			}

			if (villageListsBindingSource.Current == null)
			{
				if (Program.Language == LanguageType.English)
				{
					MessageBox.Show("Select a list first");
				}
				else
				{
					MessageBox.Show("Bitte erst eine Liste auswählen");
				}
				return;
			}
			VillageList list = (VillageList)villageListsBindingSource.Current;
			AttackImportHelper import = new AttackImportHelper();
			List<VillageInfo> villages = import.ImportVillages(Clipboard.GetText());

			foreach (VillageInfo v in villages)
			{
				villagesBindingSource.Add(v);
			}
		}

		private void btnAddVillage_Click(object sender, EventArgs e)
		{
			if (villageListsBindingSource.Current == null)
			{
				if (Program.Language == LanguageType.English)
				{
					MessageBox.Show("Select a list first");
				}
				else
				{
					MessageBox.Show("Bitte erst eine Liste auswählen");
				}
				return;
			}
			villagesBindingSource.Add(ucVillageSelector.SelectedVillage);
		}


		private void cbVillageList_TextUpdate(object sender, EventArgs e)
		{
			if (villageListsBindingSource.Current != null)
			{
				VillageList list = (VillageList)villageListsBindingSource.Current;
				list.Name = cbVillageList.Text;
			}
		}

		private void tsmiVillageAsStart_Click(object sender, EventArgs e)
		{
			VillageInfo village = (VillageInfo)lbVillages.SelectedValue;
			ucStartVillageSelector.LocationSelector.SetLocation(village.Location);
		}

		private void tsmiVillageAsTarget_Click(object sender, EventArgs e)
		{
			VillageInfo village = (VillageInfo)lbVillages.SelectedValue;
			ucTargetVillageSelector.LocationSelector.SetLocation(village.Location);
		}


		private void lbVillages_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (villageListsBindingSource.Current != null)
				{
					if (lbVillages.SelectedItem != null && lbVillages.SelectedItem is VillageInfo)
					{
						VillageList list = (VillageList)villageListsBindingSource.Current;
						list.Villages.Remove((VillageInfo)lbVillages.SelectedItem);
					}
				}

			}
		}

		private void btnNewAttackPlan_Click(object sender, EventArgs e)
		{
			m_AttackHandler.AttackPlans.Add(new AttackPlan());
		}

		private void btnDelAttackPlan_Click(object sender, EventArgs e)
		{
			if (attackPlansBindingSource.Current != null)
			{
				AttackPlan plan = (AttackPlan)attackPlansBindingSource.Current;

				string msg = "Den Angriffsplan '" + plan.Name + "' wirklich löschen?";
				string caption = "Angriffsplan löschen?";
				if (Program.Language == LanguageType.English)
				{
					msg = "Really delete '" + plan.Name + "'?";
					caption = "Delete Attack Plan?";
				}

				// Sicherheitsabfrage!
				if (MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					m_AttackHandler.AttackPlans.Remove(plan);
				}
			}
		}

		private void cbAttackPlans_TextUpdate(object sender, EventArgs e)
		{
			if (attackPlansBindingSource.Current != null)
			{
				AttackPlan plan = (AttackPlan)attackPlansBindingSource.Current;
				plan.Name = cbAttackPlans.Text;
			}
		}

		private void dgvAttacks_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			dgvAttacks.SelectionMode = DataGridViewSelectionMode.CellSelect;
		}

		private void dgvAttacks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//dgvAttacks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void dgvAttacks_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			dgvAttacks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void dtpArrivle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
			{
				if (Clipboard.ContainsText())
				{
					try
					{
						DateTime date = DateTime.Parse(Clipboard.GetText());
						dtpArrivle.Value = date;
					}
					catch (Exception) { }
				}
			}
			else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
			{
				Clipboard.SetText(dtpArrivle.Value.ToString(dtpArrivle.CustomFormat));
			}
		}

		private void tsmiOrderAsNew_Click(object sender, EventArgs e)
		{
			AttackOrder order = this.SelectedOrder;
			ucStartVillageSelector.LocationSelector.SetLocation(order.StartLocation);
			ucTargetVillageSelector.LocationSelector.SetLocation(order.TargetLocation);
			if (rbArrivle.Checked)
			{
				dtpArrivle.Value = order.ArrivleTime;
			}
			else
			{
				dtpArrivle.Value = order.SendTime;
			}
			cbSlowestUnit.SelectedItem = order.Unit;
			txtNote.Text = order.Comment;
		}

		private void cbVillageList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

    }
}
