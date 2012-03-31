using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Units
{
	public class Light : BaseUnit
	{
		public Light()
			: base("Leichte Kavallerie", "LKav")
		{
			Speed = 10;
			VillagersCost = 4;
			WoodCost = 125;
			ClayCost = 100;
			IronCost = 250;
			Offensive = 130;
			GeneralDef = 30;
			CavalryDef = 40;
			ArcherDef = 30;
			CarryCapacity = 80;
			BuildTime = TimeSpan.FromSeconds(1800);
		}
	}
}
