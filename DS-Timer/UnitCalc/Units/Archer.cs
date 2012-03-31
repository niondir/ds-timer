using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Archer : BaseUnit
	{
		public Archer()
			: base("Bogenschütze", "Bogen")
		{
			Speed = 18;
			VillagersCost = 1;
			WoodCost = 100;
			ClayCost = 30;
			IronCost = 60;
			Offensive = 15;
			GeneralDef = 50;
			CavalryDef = 40;
			ArcherDef = 5;
			CarryCapacity = 10;
			BuildTime = TimeSpan.FromSeconds(1800);
		}
	}
}
