using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeSync;
using System.Net.NetworkInformation;
using DS_Timer.Properties;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Permissions;
using DS_Timer.Gui;
using DS_Timer.Util;
using DS_Timer.Alarm;
using DS_Timer.AttackPlaner;
using DS_Timer.World;
using DS_Timer.TimeSync;
using DS_Timer.Localization;
using System.Net;

namespace DS_Timer
{
	public partial class FormMain : Form
	{
		private FormStarter m_FormClockOnTop;
		private FormStarter m_FormHelp = new FormStarter(() => { return new FormHelp(); });
		private FormStarter m_ReactionTest = new FormStarter(() => { return new FormReactionTest(); });
		private FormStarter m_FormAlarm;
		private FormStarter m_FormSettings;
		private FormStarter m_FormAttackPlaner;
		private FormStarter m_FormUnitCalc = new FormStarter(() => { return new FormUnitCalc(); });


		private DSClock m_clock;
		private AlarmHandler m_AlarmHandler;
		private AttackPlanHandler m_AttackPlanHandler;
		private WorldHandler m_WorldHandler;
		private AutoSync m_AutoSync;


		private Timer m_timer = new Timer();

		private bool m_clicked = true;
		private DateTime m_clickTime = DateTime.MinValue;


		public FormMain()
		{
			InitializeComponent();

			m_WorldHandler = new WorldHandler(); // Must be the first
			m_clock = new DSClock();
			m_AutoSync = new AutoSync();


			// Alarm
			m_AlarmHandler = new AlarmHandler(this);
			m_AlarmHandler.LoadAlarms();


			// Attack Planer
			m_AttackPlanHandler = new AttackPlanHandler();
			m_AttackPlanHandler.LoadAttackOrders();

			m_FormClockOnTop = new FormStarter(() => { return new FormClockOnTop(m_clock, m_AttackPlanHandler); });
			m_FormAlarm = new FormStarter(() => { return new FormAlarm(m_AlarmHandler); });
			m_FormAttackPlaner = new FormStarter(() => { return new FormAttackPlaner(m_AttackPlanHandler, m_AlarmHandler, m_WorldHandler); });
			m_FormSettings = new FormStarter(() => { return new FormSettings(m_WorldHandler); });

			m_timer.Interval = 1;
			m_timer.Start();
			m_timer.Tick += new EventHandler(timer_Tick);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12; //enable TLS 1.1 and 1.2
			this.Text = "DS-Timer :: v. " + Application.ProductVersion;
			if (Settings.Default.AutoSync)
			{
				btnSystemTimeSync.PerformClick();
			}

			//TimeSyncHandler.SyncDone += (s, ea) => btnCheckSystemTime_Click(null, EventArgs.Empty);

		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			if (Settings.Default.FirstStart)
			{
				Settings.Default.FirstStart = false;
				Settings.Default.Save();

				DialogFirstStart dialog = new DialogFirstStart();

				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					m_FormSettings.ShowForm();
					m_FormSettings.Form.TopMost = true;
				}
			}
		}


		void timer_Tick(object sender, EventArgs e)
		{
			DateTime now = TimeSyncHandler.Now;

			if (!m_clicked && now > m_clickTime)
			{
				Console.WriteLine("Clicked: " + now.Millisecond + " should: " + m_clickTime.Millisecond);
				DS_Timer.RemoteControl.MouseControl.MouseClick();
				m_clicked = true;

			}

			txtTime.Text = now.ToString("HH:mm:ss:fff");

			/* No Blink
			if (cbBlink.Checked)
			{
				if (m_clock.IsHighlighted(now))
				{
					this.BackColor = Color.Red;
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
			 */
		}

		private void btnCheckSystemTime_Click(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new MethodInvoker(() => btnCheckSystemTime_Click(sender, e)));
				return;
			}

			TimeSpan delay = TimeSyncHandler.CheckTimeDelay();

			txtSystemTimeDelay.Text = String.Format("{0}", delay);

			double absMs = Math.Abs(delay.TotalMilliseconds);
			if (absMs < 10)
			{
				txtSystemTimeDelay.BackColor = Color.LightGreen;
			}
			else if (absMs < 100)
			{
				txtSystemTimeDelay.BackColor = Color.DarkOrange;
			}
			else
			{
				txtSystemTimeDelay.BackColor = Color.Red;
			}


		}

		//[PrincipalPermissionAttribute(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
		private void btnSystemTimeSync_Click(object sender, EventArgs e)
		{
			TimeSyncHandler.SyncTime();
		}

		private void btnPingDS_Click(object sender, EventArgs e)
		{
			Ping ping = new Ping();
			try
			{
				string url = Settings.Default.DSServer;
				url = url.Replace("http://", "");
				url = url.Replace("https://", "");
				PingReply result = ping.Send(url);
				txtRTT.Text = result.RoundtripTime.ToString("#ms");

				long absMs = result.RoundtripTime;
				if (absMs < 50)
				{
					txtRTT.BackColor = Color.LightGreen;
				}
				else if (absMs < 100)
				{
					txtRTT.BackColor = Color.DarkOrange;
				}
				else
				{
					txtRTT.BackColor = Color.Red;
				}
			}
			catch
			{
				txtRTT.Text = "-- ERROR --";
				txtRTT.BackColor = Color.Red;
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			m_clickTime = TimeSyncHandler.Now + TimeSpan.FromSeconds(3);
			m_clickTime = m_clickTime.Subtract(TimeSpan.FromMilliseconds(m_clickTime.Millisecond));
			m_clickTime = m_clickTime.AddMilliseconds(int.Parse(txtAdjust.Text));
			Console.WriteLine("Ziel:" + m_clickTime.Millisecond);
			m_clicked = false;
		}

		private void ShowClockOnTop()
		{
			m_FormClockOnTop.ShowForm();
		}

		private void tsbMiniClock_Click(object sender, EventArgs e)
		{
			ShowClockOnTop();
		}

		private void btnShowMiniClock_Click(object sender, EventArgs e)
		{
			ShowClockOnTop();
		}

		void childForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}

			this.BringToFront();
			this.Focus();
		}

		private void tsbHelp_Click(object sender, EventArgs e)
		{
			m_FormHelp.ShowForm();
		}

		private void btnDetectReactionTime_Click(object sender, EventArgs e)
		{
			m_ReactionTest.ShowForm();
		}

		private void tsbAttackPlaner_Click(object sender, EventArgs e)
		{
			m_FormAttackPlaner.ShowForm();
		}

		private void tsbAlarm_Click(object sender, EventArgs e)
		{
			m_FormAlarm.ShowForm();
		}

		private void tsbSettings_Click(object sender, EventArgs e)
		{
			m_FormSettings.ShowForm();
		}

		private void txtSystemTimeDelay_TextChanged(object sender, EventArgs e)
		{

		}

		private void tsbUnitCalc_Click(object sender, EventArgs e)
		{
			m_FormUnitCalc.ShowForm();
		}






	}
}
