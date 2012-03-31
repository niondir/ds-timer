using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Spy : BaseUnit
	{
		public Spy()
			: base("Späher", "Späh")
		{
			Speed = 9;
			VillagersCost = 2;
			WoodCost = 50;
			ClayCost = 50;
			IronCost = 20;
			Offensive = 0;
			GeneralDef = 2;
			CavalryDef = 1;
			ArcherDef = 2;
			CarryCapacity = 0;
			BuildTime = TimeSpan.FromSeconds(900);
		}
	}
}
