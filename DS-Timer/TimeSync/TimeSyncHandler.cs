using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSync;
using DS_Timer.Properties;

namespace DS_Timer.TimeSync
{
	public class TimeSyncHandler
	{


		private static TimeSpan m_Offset = TimeSpan.Zero;


		private static DateTime m_LastSync;
		private static int m_BaseTickCount = 0;

		/// <summary>
		/// Fromt 0 to int.MaxCount every 24.9 Days
		/// </summary>
		public static int SystemTickCount
		{
			get { return Environment.TickCount & int.MaxValue; }
		}

		public static DateTime Now
		{
			get 
			{
				return DateTime.Now - m_Offset;

				// TickCount Method
				//return m_LastSync + TimeSpan.FromMilliseconds(SystemTickCount - m_BaseTickCount);
			}
		}
		

		public static void SyncTime() {
			NTPClient ntpClient = new NTPClient(Settings.Default.TimeServer);

			ntpClient.Connect(true); // When set to false systemtime will remains as it was. DS-Timer still works correct!
			m_Offset = DateTime.Now - ntpClient.TransmitTimestamp;

			// TickCount Method
			//m_LastSync = ntpClient.TransmitTimestamp;
			//m_BaseTickCount = SystemTickCount;
		}

		public static TimeSpan CheckTimeDelay()
		{
			NTPClient ntpClient = new NTPClient(Settings.Default.TimeServer);
			ntpClient.Connect(false);
			TimeSpan delay = TimeSyncHandler.Now - ntpClient.TransmitTimestamp;
			return delay;
		}
	}
}
