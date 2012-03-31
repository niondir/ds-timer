using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Ram : BaseUnit
	{
		public Ram()
			: base("Ramme", "Ramme")
		{
			Speed = 30;	 	 	 	 	
			VillagersCost = 5;
			WoodCost = 300;
			ClayCost = 200;
			IronCost = 200;
			Offensive = 2;
			GeneralDef = 20;
			CavalryDef = 50;
			ArcherDef = 20;
			CarryCapacity = 0;
			BuildTime = TimeSpan.FromSeconds(4800);
		}
	}
}
