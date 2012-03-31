using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class MArcher : BaseUnit
	{
		public MArcher()
			: base("Berittener Bogenschütze", "BBogen")
		{
			Speed = 10;
			VillagersCost = 5;
			WoodCost = 250;
			ClayCost = 100;
			IronCost = 150;
			Offensive = 120;
			GeneralDef = 40;
			CavalryDef = 30;
			ArcherDef = 50;
			CarryCapacity = 50;
			BuildTime = TimeSpan.FromSeconds(2700);
		}
	}
}
