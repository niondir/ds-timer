using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Knight : BaseUnit
	{
		public Knight()
			: base("Paladin", "Pala")
		{
			Speed = 10;	 	 	 	 	 	 	
			VillagersCost = 10;
			WoodCost = 20;
			ClayCost = 20;
			IronCost = 40;
			Offensive = 150;
			GeneralDef = 250;
			CavalryDef = 400;
			ArcherDef = 150;
			CarryCapacity = 100;
			BuildTime = TimeSpan.FromSeconds(21600);
		}
	}
}
