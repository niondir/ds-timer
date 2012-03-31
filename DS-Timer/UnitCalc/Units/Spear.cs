using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS_Timer.AttackPlaner;

namespace DS_Timer.UnitCalc.Units
{
	public class Spear : BaseUnit
	{
		public Spear()
			: base("Speerträger", "Speer")
		{
			Speed = 18;
			VillagersCost = 1;
			WoodCost = 50;
			ClayCost = 30;
			IronCost = 10;
			Offensive = 10;
			GeneralDef = 15;
			CavalryDef = 45;
			ArcherDef = 20;
			CarryCapacity = 25;
			BuildTime = TimeSpan.FromSeconds(1020);
		}
	}
}
