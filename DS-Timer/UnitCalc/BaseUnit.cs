using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc
{
	public abstract class BaseUnit
	{
		public string Name { get; set; }
		public string ShortName { get; set; }
		public double Speed { get; set; }

		public int Amount { get; set; }

		public int VillagersCost { get; set; }
		public int WoodCost { get; set; }
		public int ClayCost { get; set; }
		public int IronCost { get; set; }

		public int Offensive { get; set; }
		public int GeneralDef { get; set; }
		public int CavalryDef { get; set; }
		public int ArcherDef { get; set; }

		public int CarryCapacity { get; set; }
		public TimeSpan BuildTime { get; set; }



		public BaseUnit(string name, string shortName)
		{
			Name = name;
			ShortName = shortName;
		}

		public BaseUnit(string name, string shortName, double speed)
		{
			Name = name;
			ShortName = shortName;
			Speed = speed;
		}
		
		public BaseUnit(string name, string shortName, double speed, int villagers, int wood, int clay, int iron, int off, int gen, int cav, int archer, int carry, int buildTime)
		{
			Name = name;
			ShortName = shortName;
			Speed = speed;
			VillagersCost = villagers;
			WoodCost = wood;
			ClayCost = clay;
			IronCost = iron;
			Offensive = off;
			GeneralDef = gen;
			CavalryDef = cav;
			ArcherDef = archer;
			CarryCapacity = carry;
			BuildTime = TimeSpan.FromSeconds((double)buildTime);
		}

		public TimeSpan GetTotalBuildTime()
		{
			return TimeSpan.FromSeconds(BuildTime.TotalSeconds * Amount);
		}
	}
}
