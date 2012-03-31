using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using DS_Timer.TimeSync;

namespace DS_Timer.Alarm
{
	[XmlRoot]
	public class AlarmTime : INotifyPropertyChanged
	{
		private Timer m_Timer = new Timer();

		private DateTime m_Time;
		private string m_Message;
		private bool m_Active;
		private bool m_BalloonTip;
		private bool m_Sound;
		private bool m_Popup;

        public delegate void MyDelegate(int a, int b);

		public event EventHandler OnAlarm;

		public DateTime Time
		{
			get { return m_Time; }
			set
			{
				TimeSpan duration = value - TimeSyncHandler.Now;
#if xDEBUG
				if (duration.TotalMilliseconds < 0)
				{
					duration = TimeSpan.FromSeconds(1);
				}
#endif

				if (duration.TotalMilliseconds > 0)
				{
					m_Timer.Interval = duration.TotalMilliseconds;
					m_Timer.Start();
					//System.Windows.Forms.MessageBox.Show("Alarm klingelt in " + duration.Seconds + " Sekunden.");
				}
				else
				{
					m_Timer.Stop();
				}
				m_Time = value;
				NotifyPropertyChanged("Time");
			}
		}

        

		public String Message
		{
			get { return m_Message ?? String.Empty; }
			set
			{
				m_Message = value;
				NotifyPropertyChanged("Message");
			}
		}

		public bool Active
		{
			get { return m_Active; }
			set
			{
				m_Active = value;
				NotifyPropertyChanged("Active");
			}
		}

		public bool BalloonTip
		{
			get { return m_BalloonTip; }
			set
			{
				m_BalloonTip = value;
				NotifyPropertyChanged("BalloonTip");
			}
		}

		public bool Sound
		{
			get { return m_Sound; }
			set
			{
				m_Sound = value;
				NotifyPropertyChanged("Sound");
			}
		}

		public bool Popup
		{
			get { return m_Popup; }
			set
			{
				m_Popup = value;
				NotifyPropertyChanged("Popup");
			}
		}



		public AlarmTime()
			: this(TimeSyncHandler.Now)
		{
		}

        public AlarmTime(DateTime alarmTime)
            : this(alarmTime, String.Empty)
        {
        }

        public AlarmTime(DateTime alarmTime, string message)
        {
            m_Timer.AutoReset = false;
            m_Timer.Elapsed += new ElapsedEventHandler(m_Timer_Elapsed); 

            Time = alarmTime;
            Message = message;

            Active = true;
            BalloonTip = true;
            Popup = true;
            Sound = true;
        }

		void m_Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Active && OnAlarm != null)
			{
				OnAlarm.Invoke(this, EventArgs.Empty);
			}
		}


		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
			}
		}

		#endregion

		#region serialization
		public static void SerializeToXml(List<AlarmTime> alarmTimes)
		{
			XmlSerializer writer = new XmlSerializer(typeof(List<AlarmTime>));
            string dir = Program.GetUserDataPath();

			TextWriter textWriter = new StreamWriter(Path.Combine(dir, "AlarmTimes.xml"));
			writer.Serialize(textWriter, alarmTimes);
			textWriter.Close();
		}

		public static List<AlarmTime> DeserializeFromXml()
		{
			try
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(List<AlarmTime>));
				// Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
				string dir = Program.GetUserDataPath();
				TextReader textReader = new StreamReader(Path.Combine(dir, "AlarmTimes.xml"));
				List<AlarmTime> alarmTimes;
				alarmTimes = (List<AlarmTime>)deserializer.Deserialize(textReader);
				textReader.Close();

				return alarmTimes;
			}
			catch (Exception)
			{
				return new List<AlarmTime>();
			}
		}
		#endregion
	}
}
