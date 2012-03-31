using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.Util;
using DS_Timer.Gui;
using System.ComponentModel;
using System.Media;
using System.IO;
using DS_Timer.Properties;

namespace DS_Timer.Alarm
{
	public class AlarmHandler
	{
        private SortableBindingList<AlarmTime> m_Alarms = new SortableBindingList<AlarmTime>();

		private ISynchronizeInvoke m_Sync;
		private static SoundPlayer m_Sound;
		private Timer m_SoundLoopTimer = new Timer();
		private MessageNotifyIcon m_Notify = new MessageNotifyIcon(DS_Timer.Properties.Resources.clockIcon);

        public SortableBindingList<AlarmTime> Alarms
        {
            get { return m_Alarms; }
            //private set { m_Alarms = value; }
        }

		public static SoundPlayer Sound
		{
			get 
			{
				if (m_Sound == null)
				{
					ReloadSound();
				}
				return m_Sound; 
			
			}
			private set { m_Sound = value; }
		}


		public AlarmHandler(ISynchronizeInvoke sync)
		{
			m_Sync = sync;
			m_SoundLoopTimer.Interval = 5000;
			m_SoundLoopTimer.Tick += new EventHandler(m_SoundLoopTimer_Tick);
            m_Alarms.ListChanged += new ListChangedEventHandler(m_Alarms_ListChanged);
			ReloadSound();
		}

        void m_Alarms_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.NewIndex < 0) return;
            if (e.NewIndex >= m_Alarms.Count) return;

            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                AlarmTime alarm = m_Alarms[e.NewIndex];
                WatchAlarm(alarm);
            }
        }

		

		private static void ReloadSound()
		{
			Settings.Default.SettingsSaving += new System.Configuration.SettingsSavingEventHandler(Default_SettingsSaving);
			try
			{
				if (m_Sound == null || m_Sound.SoundLocation != Settings.Default.AlarmSoundFile)
				{
					Sound = new SoundPlayer(Settings.Default.AlarmSoundFile);
					Sound.Load();
				}
			}
			catch (Exception)
			{
				// TODO: Notice user?
				Sound = new SoundPlayer(DS_Timer.Properties.Resources.AlarmSound);
				Sound.Load();
			}
		}

		static void Default_SettingsSaving(object sender, CancelEventArgs e)
		{
			ReloadSound();
		}

		internal void WatchAlarm(List<AlarmTime> alarms)
		{
			foreach (AlarmTime a in alarms)
			{
				WatchAlarm(a);
			}
		}

		public void WatchAlarm(AlarmTime alarm)
		{
			if (!m_Alarms.Contains(alarm))
			{
				m_Alarms.Add(alarm);
			}
            alarm.OnAlarm -= new EventHandler(alarm_OnAlarm);
            alarm.OnAlarm += new EventHandler(alarm_OnAlarm);

		}

		public void ClearAlarms()
		{
			m_Alarms.Clear();
		}


		/// <summary>
		/// Returns a copy of the List
		/// </summary>
		/// <returns></returns>
		public List<AlarmTime> GetAlarms()
		{
            List<AlarmTime> alarms = new List<AlarmTime>();
            foreach (AlarmTime a in m_Alarms)
            {
                alarms.Add(a);
            }
            return new List<AlarmTime>(alarms);
		}

		void alarm_OnAlarm(object sender, EventArgs e)
		{
			if (m_Sync.InvokeRequired)
			{
				m_Sync.Invoke(new MethodInvoker(delegate {alarm_OnAlarm(sender, e);}), null);
				return;
			}


			AlarmTime alarm = (AlarmTime)sender;

			if (alarm == null) return;
			if (!m_Alarms.Contains(alarm))
			{
				alarm.OnAlarm -= new EventHandler(alarm_OnAlarm);
				return;
			}

			if (alarm.BalloonTip)
			{
				/*
				NotifyIcon icon = new NotifyIcon();
				icon.BalloonTipClosed += (s, ea) => { icon.Visible = false; };
				icon.BalloonTipClicked += (s, ea) => { icon.Visible = false; };
				icon.Icon = DS_Timer.Properties.Resources.clockIcon;
				icon.Visible = true;
				icon.ShowBalloonTip(10000, "DS-Timer Alarm", "Nachricht: " + alarm.Message, ToolTipIcon.Info);
				*/
				m_Notify.ShowMessage(alarm.Message);
			}

			if (alarm.Sound)
			{
				Sound.Play();
			}

			if (alarm.Popup)
			{
				FormAlarmPopup form = new FormAlarmPopup(alarm.Message);
				form.FormClosed += new FormClosedEventHandler(form_FormClosed);
				form.Show();
				StartSoundLoop();
			}
		}

		void form_FormClosed(object sender, FormClosedEventArgs e)
		{
			StopSoundLoop();
		}

		private void StartSoundLoop()
		{
			Sound.PlayLooping();
			//m_SoundLoopTimer.Start();
		}

		private void StopSoundLoop()
		{
			Sound.Stop();
			//m_SoundLoopTimer.Stop();
		}

		void m_SoundLoopTimer_Tick(object sender, EventArgs e)
		{
			PlaySound();
		}


		public static void PlaySound()
		{
			Sound.Play();
		}

		public void SaveAlarms()
		{
			List<AlarmTime> alarms = this.GetAlarms();
			AlarmTime.SerializeToXml(alarms);
		}


		public void LoadAlarms()
		{
			List<AlarmTime> alarms = AlarmTime.DeserializeFromXml();
			this.WatchAlarm(alarms);
		}
	}
}
