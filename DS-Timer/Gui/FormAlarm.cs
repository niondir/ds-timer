using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.Alarm;

namespace DS_Timer.Gui
{
	public partial class FormAlarm : Form
	{
		public FormAlarm(AlarmHandler alarmHandler)
		{
			InitializeComponent();
			ucAlarm.AlarmHandler = alarmHandler;
		}
	}
}
