using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Sword : BaseUnit
	{
		public Sword()
			: base("Schwertkämpfer", "Schwert")
		{
			Speed = 22;
			VillagersCost = 1;
			WoodCost = 30;
			ClayCost = 30;
			IronCost = 70;
			Offensive = 25;
			GeneralDef = 50;
			CavalryDef = 15;
			ArcherDef = 40;
			CarryCapacity = 15;
			BuildTime = TimeSpan.FromSeconds(1500);
		}
	}
}
