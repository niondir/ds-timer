using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.AttackPlaner;
using DS_Timer.Alarm;
using DS_Timer.World;

namespace DS_Timer.Gui
{
	public partial class FormAttackPlaner : Form
	{
		public FormAttackPlaner(AttackPlanHandler attackPlanHandler, AlarmHandler alarmHandler, WorldHandler worldHandler)
		{
			InitializeComponent();
            ucAttackPlaner.InitializeUserControl(attackPlanHandler, alarmHandler, worldHandler);
		}
	}
}
