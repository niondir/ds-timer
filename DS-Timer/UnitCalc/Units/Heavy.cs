using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Heavy : BaseUnit
	{
		public Heavy()
			: base("Schwere Kavallerie", "SKav")
		{
			Speed = 11;	 	 	 	 
			VillagersCost = 6;
			WoodCost = 200;
			ClayCost = 150;
			IronCost = 600;
			Offensive = 150;
			GeneralDef = 200;
			CavalryDef = 80;
			ArcherDef = 180;
			CarryCapacity = 50;
			BuildTime = TimeSpan.FromSeconds(3600);
		}
	}
}
