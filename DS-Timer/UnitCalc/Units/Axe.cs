using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Axe : BaseUnit
	{
		public Axe()
			: base("Axtkämpfer", "Axt")
		{
			Speed = 18;
			VillagersCost = 1;
			WoodCost = 60;
			ClayCost = 30;
			IronCost = 40;
			Offensive = 40;
			GeneralDef = 10;
			CavalryDef = 5;
			ArcherDef = 10;
			CarryCapacity = 10;
			BuildTime = TimeSpan.FromSeconds(1320);
		}
	}
}
