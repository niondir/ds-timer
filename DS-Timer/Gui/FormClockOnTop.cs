using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.TimeSync;
using DS_Timer.AttackPlaner;
using DS_Timer.Properties;
using DS_Timer.Localization;

namespace DS_Timer.Gui
{
	public partial class FormClockOnTop : Form
	{
		private Timer m_Timer = new Timer();
		private DSClock m_Clock;
		AttackPlanHandler m_AttackPlanHandler;

		public FormClockOnTop(DSClock clock, AttackPlanHandler attackPlanHandler)
		{
			m_Clock = clock;
			m_AttackPlanHandler = attackPlanHandler; // Not needed ?
			InitializeComponent();
		}

		private void ClockOnTop_Load(object sender, EventArgs e)
		{
			m_Timer.Tick += new EventHandler(m_timer_Tick);
			m_Timer.Interval = 1;
			m_Timer.Start();
		}

		void m_timer_Tick(object sender, EventArgs e)
		{
			DateTime now = TimeSyncHandler.Now;
			DateTime nextAttack = dtpNextAttack.Value;

			textBox1.Text = now.ToString("HH:mm:ss:fff");
			// HighlightOffset
			TimeSpan timeLeft = nextAttack - now + TimeSpan.FromMilliseconds(m_Clock.HumanFactor + m_Clock.HighlightOffset);
			if (timeLeft < TimeSpan.Zero)
			{
				timeLeft = TimeSpan.Zero;
			}

			txtCountdown.Text = string.Format("{4} {0:00}:{1:00}:{2:00}.{3:000}", timeLeft.Hours, timeLeft.Minutes, timeLeft.Seconds, timeLeft.Milliseconds, Translator.Translate("Abschicken in"));
			//txtCountdown.Text = String.Format("{0}", timeLeft);
			if (!cbBlink.Checked && Settings.Default.AutoBlink)
			{
				if (now.AddSeconds(60) > nextAttack && now < nextAttack)
				{
					cbBlink.Checked = true;
				}
			}

			if (cbBlink.Checked)
			{
				if (m_Clock.IsHighlighted(now))
				{
					if (timeLeft < TimeSpan.FromSeconds(0.2))
					{
						this.BackColor = DSClock.HighlightAttackColor;
					}
					else if (timeLeft < TimeSpan.FromSeconds(1.2))
					{
						this.BackColor = Color.DarkOrange;
					}
					else
					{
						this.BackColor = DSClock.HighlightColor;
					}
				}
				else
				{
					this.BackColor = SystemColors.Control;
				}
			}
			else
			{
				this.BackColor = SystemColors.Control;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
		}

		private void timeToNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dtpNextAttack.Value = TimeSyncHandler.Now;
		}

		private void dtpNextAttack_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
			{
				if (Clipboard.ContainsText())
				{
					try
					{
						DateTime date = DateTime.Parse(Clipboard.GetText());
						dtpNextAttack.Value = date;
					}
					catch (Exception) { }
				}
			}
			else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
			{
				Clipboard.SetText(dtpNextAttack.Value.ToString(dtpNextAttack.CustomFormat));
			}
		}


	}
}
