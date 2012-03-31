using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using DS_Timer.Properties;

namespace DS_Timer.TimeSync
{
	public class AutoSync
	{
		// Monostate
		private static Timer m_Timer = new Timer(1000 * 60 * 5); // 5 Minutes

		public AutoSync()
		{
			m_Timer.Elapsed += new ElapsedEventHandler(m_Timer_Elapsed);
			m_Timer.AutoReset = true;
			m_Timer.Start();
		}

		void m_Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Settings.Default.AutoSync)
			{
				TimeSyncHandler.SyncTime();
			}
		}


	}
}
