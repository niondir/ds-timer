using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.Alarm;
using DS_Timer.Util;
using DS_Timer.TimeSync;
using DS_Timer.Localization;

namespace DS_Timer.Gui
{
	public partial class UcAlarm : UserControl
	{
		private Timer m_Timer = new Timer();
		private AlarmHandler m_AlarmHandler;
		private DataGridViewColumn m_SortedColumn;

		public AlarmHandler AlarmHandler
		{
			get { return m_AlarmHandler; }
			set
			{
				m_AlarmHandler = value;

				if (m_AlarmHandler == null)
				{
					//alarmTimeBindingSource.DataSource = null;
					return;
				}

				alarmTimeBindingSource.DataSource = m_AlarmHandler.Alarms;
				btnSaveAlarms.Enabled = false;
			}
		}


		public UcAlarm()
		{
			InitializeComponent();


			alarmTimeBindingSource.ListChanged += new ListChangedEventHandler(alarmTimeBindingSource_ListChanged);

			m_Timer.Interval = 200;
			m_Timer.Start();
			m_Timer.Tick += new EventHandler(m_Timer_Tick);

			// Setup Datagridview
			this.tableLayoutPanel1.SetColumnSpan(this.dgvAlarms, 2);
			dgvAlarms.Dock = DockStyle.Fill;

		}

		void m_Timer_Tick(object sender, EventArgs e)
		{
			// Update countdown zum nächsten Timer
			DateTime next = DateTime.MaxValue;
			DateTime now = TimeSyncHandler.Now;
			foreach (AlarmTime alarm in alarmTimeBindingSource)
			{
				if (alarm.Time < next && alarm.Time > now && alarm.Active)
				{
					next = alarm.Time;
				}
			}

			if (next != DateTime.MaxValue)
			{
				TimeSpan timeLeft = next - TimeSyncHandler.Now;

				TimeSpan ts = new TimeSpan(12, 6, 7);
				txtTimeLeft.Text = String.Format("{0:00}:{1:00}:{2:00}", (int)timeLeft.TotalHours, timeLeft.Minutes, timeLeft.Seconds);
				txtNextAlarm.Text = next.ToString("dd.MM.yyyy - HH:mm:ss");
			}
			else
			{
				txtTimeLeft.Text = Translator.Translate("Kein Alarm");
				txtNextAlarm.Text = String.Empty;
			}

			for (int i = 0; i < dgvAlarms.ColumnCount; i++)
			{
				dgvAlarms.InvalidateColumn(i);
			}
		}

		void alarmTimeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnSaveAlarms.Enabled = true;
			if (e.NewIndex >= alarmTimeBindingSource.Count || e.NewIndex < 0)
			{
				return;
			}

		}

		private void btnSaveAlarm_Click(object sender, EventArgs e)
		{
			AlarmTime alarm = new AlarmTime();
			alarm.Time = dtpAlarmTime.Value;
			alarm.Message = txtAlarmMessage.Text;

			alarm.Active = cbAlarmEnabled.Checked;
			alarm.Sound = cbAlarmSound.Checked;
			alarm.Popup = cbPopup.Checked;
			alarm.BalloonTip = cbBaloon.Checked;

			m_AlarmHandler.Alarms.Add(alarm);
		}

		private void btnTestSound_Click(object sender, EventArgs e)
		{
			AlarmHandler.PlaySound();
		}

		private void dgvAlarms_Validating(object sender, CancelEventArgs e)
		{

		}

		private void dgvAlarms_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Exception is FormatException)
			{
				e.ThrowException = false;
				e.Cancel = false;
			}

		}


		private void dgvAlarms_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
		}

		private void dgvAlarms_CellValidated(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvAlarms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			AlarmTime alarm = (AlarmTime)dgvAlarms.Rows[e.RowIndex].DataBoundItem;

			if (alarm.Time < TimeSyncHandler.Now)
			{
				e.CellStyle.BackColor = Color.LightCoral;
				e.CellStyle.SelectionBackColor = Color.LightCoral;
			}
			else if (!alarm.Active)
			{
				e.CellStyle.BackColor = Color.Orange;
				e.CellStyle.SelectionBackColor = Color.Orange;
			}
			else
			{
				e.CellStyle.BackColor = Color.LightGreen;
				e.CellStyle.SelectionBackColor = Color.LightGreen;
			}
		}

		private void dgvAlarms_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex < 0 || e.ColumnIndex > this.dgvAlarms.Columns.Count) return;

			if (this.dgvAlarms.Columns[e.ColumnIndex].Name == "time")
			{
				DateTime result;
				if (!DateTime.TryParse((string)e.FormattedValue, out result))
				{
					if (Program.Language == LanguageType.English)
					{
						dgvAlarms.Rows[e.RowIndex].ErrorText = "Invalid Time Format";
						dgvAlarms.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Invalid Time Format: " + e.FormattedValue;
					}
					else
					{
						dgvAlarms.Rows[e.RowIndex].ErrorText = "Ungültiges Zeitformat";
						dgvAlarms.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Ungültiges Zeitformat: " + e.FormattedValue;
					}
				}
				else
				{
					dgvAlarms.Rows[e.RowIndex].ErrorText = String.Empty;
					dgvAlarms.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Empty;
				}

			}
		}

		private void btnSaveAlarms_Click(object sender, EventArgs e)
		{
			btnSaveAlarms.Enabled = false;
			m_AlarmHandler.SaveAlarms();
		}

		private void dgvAlarms_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn newColumn = dgvAlarms.Columns[e.ColumnIndex];
			m_SortedColumn = newColumn;

			if (newColumn.SortMode == DataGridViewColumnSortMode.NotSortable) return;
			if (alarmTimeBindingSource.SortDirection == ListSortDirection.Ascending)
			{
				newColumn.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
			}
			else
			{
				newColumn.HeaderCell.SortGlyphDirection = SortOrder.Descending;

			}

			return;
			/*
			DataGridViewColumn newColumn = dgvAlarms.Columns[e.ColumnIndex];
			DataGridViewColumn oldColumn = m_SortedColumn;
			ListSortDirection direction;

			if (newColumn.SortMode == DataGridViewColumnSortMode.NotSortable) return;

			// If oldColumn is null, then the DataGridView is not sorted.
			if (oldColumn != null)
			{

				// Sort the same column again, reversing the SortOrder.
				if (oldColumn == newColumn && alarmTimeBindingSource.SortDirection == ListSortDirection.Ascending)
				{
					direction = ListSortDirection.Descending;
				}
				else
				{
					// Sort a new column and remove the old SortGlyph.
					direction = ListSortDirection.Ascending;
					oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
				}
			}
			else
			{
				direction = ListSortDirection.Ascending;
			}

			// Sort the selected column.
			dgvAlarms.Sort(newColumn, direction);
			newColumn.HeaderCell.SortGlyphDirection =
				direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
			m_SortedColumn = newColumn;
	*/
		}

		private void dtpAlarmTime_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
			{
				if (Clipboard.ContainsText())
				{
					try
					{
						DateTime date = DateTime.Parse(Clipboard.GetText());
						dtpAlarmTime.Value = date;
					}
					catch (Exception) { }
				}
			}
			else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
			{
				Clipboard.SetText(dtpAlarmTime.Value.ToString(dtpAlarmTime.CustomFormat));
			}
		}

		private void dgvAlarms_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			DataGridViewCell cell = dgvAlarms.Rows[e.RowIndex].Cells[e.ColumnIndex];
			if (cell is DataGridViewCheckBoxCell)
			{
				return;
			}
			dgvAlarms.SelectionMode = DataGridViewSelectionMode.CellSelect;
		}

		private void dgvAlarms_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			dgvAlarms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void btnRemoveOldAlarms_Click(object sender, EventArgs e)
		{
			List<AlarmTime> remove = new List<AlarmTime>();
			foreach (AlarmTime a in m_AlarmHandler.Alarms)
			{
				if (a.Time < TimeSyncHandler.Now)
				{
					remove.Add(a);
				}
			}

			foreach (AlarmTime a in remove)
			{
				m_AlarmHandler.Alarms.Remove(a);
			}
		}








	}
}
