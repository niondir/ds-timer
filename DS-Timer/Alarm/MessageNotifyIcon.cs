using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DS_Timer.TimeSync;

namespace DS_Timer.Alarm
{
	public class MessageNotifyIcon
	{
		private NotifyIcon m_Icon = new NotifyIcon();

		public MessageNotifyIcon(Icon icon)
		{
			m_Icon.Icon = icon;
			m_Icon.Text = "DS-Timer Alarm" + Environment.NewLine + "(Click for last Alarm)";
			m_Icon.BalloonTipTitle = "DS-Timer Alarm";
			m_Icon.BalloonTipIcon = ToolTipIcon.Info;

			m_Icon.Click += new EventHandler(m_Icon_Click);
			m_Icon.ContextMenu = new ContextMenu();

			MenuItem menuItem = new MenuItem("Letzter Alarm");
			menuItem.Click += new EventHandler(lastAlarm_Click);
			m_Icon.ContextMenu.MenuItems.Add(menuItem);

			menuItem = new MenuItem("Verstecken");
			menuItem.Click += new EventHandler(hide_Click);
			m_Icon.ContextMenu.MenuItems.Add(menuItem);

			
		}

		void lastAlarm_Click(object sender, EventArgs e)
		{
			m_Icon.ShowBalloonTip(10000);
		}

		void hide_Click(object sender, EventArgs e)
		{
			m_Icon.Visible = false;
		}

		void m_Icon_Click(object sender, EventArgs e)
		{
			m_Icon.ShowBalloonTip(10000);
		}


		public void ShowMessage(string message)
		{
			m_Icon.Visible = true;
			m_Icon.BalloonTipText = TimeSyncHandler.Now.ToString("HH:mm:ss") + Environment.NewLine + message;
			m_Icon.ShowBalloonTip(10000);
		}



	}
}
