using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.ComponentModel;
using System.Drawing;
using DS_Timer.Properties;

namespace DS_Timer.TimeSync
{
	public class DSClock
	{
		private Timer m_Timer;
		//private int m_clockOffset;
		

		//private int m_HighlightOffset = 0;
		private int m_blinkDelay = 200;
        private int m_humanFactor = -200;

        

		public static readonly Color HighlightColor = Color.Red;
		public static readonly Color HighlightAttackColor = Color.Green;
		

		public int ClockOffset
		{
			get { return (int)Settings.Default.ClockAdjustment; }
		}

		public int HighlightOffset
		{
			get { return (int)Settings.Default.HighlightOffset; }
		}

        public int HumanFactor
        {
            get { return m_humanFactor; }
            private set { m_humanFactor = value; }
        }

		public DSClock()
		{
			m_Timer = new Timer(1);
			m_Timer.Elapsed += new ElapsedEventHandler(m_timer_Elapsed);
			m_Timer.AutoReset = true;
			m_Timer.Enabled = true;
		}

		void m_timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			
		}

		public DateTime GetTime()
		{
			return TimeSyncHandler.Now + TimeSpan.FromMilliseconds(ClockOffset);
		}

		private int PositiveModulo(int i, int m)
		{
			return ((i % m) + m) % m;
		}

		public bool IsHighlighted(DateTime time)
		{
			int start, stop;

            start = m_humanFactor + HighlightOffset;
			start = ((start % 1000) + 1000) % 1000; //PositiveModulo(start, 1000); 
			stop = start + m_blinkDelay;
			stop = stop > 1000 ? stop - 1000 : stop;

			if (start < stop && time.Millisecond >= start && time.Millisecond <= stop)
			{
				return true;
			}
			else if (start > stop && (time.Millisecond <= stop || time.Millisecond >= start))
			{
				return true;
			}

			return false;
		}


		

	}
}
