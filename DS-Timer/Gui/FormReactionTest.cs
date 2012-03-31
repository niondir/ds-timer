using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.TimeSync;

namespace DS_Timer.Gui
{
	public partial class FormReactionTest : Form
	{
		private int m_checksLeft = 0;

		private int ChecksLeft
		{
			get { return m_checksLeft; }
			set 
			{ 
				m_checksLeft = value;
				lblClicks.Text = value.ToString();
				if (value <= 0)
				{
					btnOK.Enabled = false;
					m_Timer.Stop();
					this.BackColor = SystemColors.Control;
				}
				else
				{
					btnOK.Enabled = true;
				}
			}
		}
		private List<int> m_times = new List<int>();
		private Timer m_Timer = new Timer();
		private DateTime m_lastBlink;

		private int m_timerCounter = 0;

		public FormReactionTest()
		{
			InitializeComponent();
			Reset();

			m_Timer.Interval = 200;
			m_Timer.Tick += new EventHandler(m_Timer_Tick);
			

			
		}

		void m_Timer_Tick(object sender, EventArgs e)
		{
			m_timerCounter += 1;
			m_timerCounter %= 5;

			

			if (m_timerCounter == 0)
			{
				this.BackColor = Color.Red;
				m_lastBlink = TimeSyncHandler.Now;
			}
			else
			{
				this.BackColor = SystemColors.Control;
			}
		}


		private void FormReactionTest_Load(object sender, EventArgs e)
		{
			btnOK.Focus();
			ChecksLeft = 0;
		}

		private void Reset()
		{
			m_times.Clear();
			ChecksLeft = 10;
			m_Timer.Start();
			btnOK.Focus();
			txtReactionTime.Text = "-";
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			int reaction = GetReactionTime();
			m_times.Add(reaction);
			
			ChecksLeft--;

			if (ChecksLeft <= 0)
			{
				CalculateResult();
			}
		}

		private void CalculateResult()
		{
			double result = 0;
			int min = int.MaxValue;
			int max = int.MinValue;
			foreach (int i in m_times)
			{
				if (i < min) min = i;
				if (i > max) max = i;
				result += i;
			}
			result /= m_times.Count();
			txtReactionTime.Text = result.ToString();
			txtMin.Text = min.ToString();
			txtMax.Text = max.ToString();
		}

		private int GetReactionTime()
		{
			TimeSpan delay = m_lastBlink - TimeSyncHandler.Now;
			int ms = delay.Milliseconds;
			if (ms < -500) ms += 1000;
			return ms;
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			Reset();
		}
	}
}
