using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Catapult : BaseUnit
	{
		public Catapult()
			: base("Katapult", "Kata")
		{
			Speed = 30; 	 	 	 	 
			VillagersCost = 8;
			WoodCost = 320;
			ClayCost = 400;
			IronCost = 100;
			Offensive = 100;
			GeneralDef = 100;
			CavalryDef = 50;
			ArcherDef = 100;
			CarryCapacity = 0;
			BuildTime = TimeSpan.FromSeconds(7200);
		}
	}
}
