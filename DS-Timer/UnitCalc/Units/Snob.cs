using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Snob : BaseUnit
	{
		public Snob()
			: base("Adelsgeschlecht", "AG")
		{
			Speed = 35;	 	 	 	 	 	
			VillagersCost = 100;
			WoodCost = 40000;
			ClayCost = 50000;
			IronCost = 50000;
			Offensive = 30;
			GeneralDef = 100;
			CavalryDef = 50;
			ArcherDef = 100;
			CarryCapacity = 0;
			BuildTime = TimeSpan.FromSeconds(18000);
		}
	}
}
