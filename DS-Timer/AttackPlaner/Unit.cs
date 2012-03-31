using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS_Timer.World;

namespace DS_Timer.AttackPlaner
{
	public struct Unit
	{
		private static int m_lastId = 1;

		private int m_Id;
		private UnitInfo UnitInfo
		{
			get { return UnitInfo.GetById(m_Id); }
		}

		public int Id { get { return m_Id; } }
		public double Speed { get { return UnitInfo.Speed; } }
		public string Name { get { return UnitInfo.Name; } }
		public string ShortName { get { return UnitInfo.ShortName; } }
		public string AdvancedName { get { return UnitInfo.AdvancedName; } }
		public string AdvancedShortName { get { return UnitInfo.AdvancedShortName; } }

		public Unit(int id)
			: this()
		{
			m_Id = id;
		}

		public Unit(UnitType id)
			: this()
		{
			m_Id = (int)id;
		}

		public static bool operator <(Unit left, Unit right)
		{
			return left.Speed < right.Speed;
		}

		public static bool operator >(Unit left, Unit right)
		{
			return left.Speed > right.Speed;
		}

		public static bool operator !=(Unit left, Unit right)
		{
			return !(left == right);
		}

		public static bool operator ==(Unit left, Unit right)
		{
			return left.Id == right.Id;
			//return left.Speed == right.Speed && left.Name == right.Name && left.ShortName == right.ShortName;
		}

		public override int GetHashCode()
		{
			return Id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Unit)) return false;

			return this == (Unit)obj;
		}

		public override string ToString()
		{
			return Name;
		}

		public static Unit Parse(string p)
		{
			switch (p.ToLower())
			{
				case "speer":
				case "speerträger":
					return new Unit(UnitType.Spear);
					break;
				case "schwert":
				case "schwertkämpfer":
					return new Unit(UnitType.Sword);
					break;
				case "axt":
				case "axtkämpfer":
					return new Unit(UnitType.Axe);
					break;
				case "bogen":
				case "bogenschütze":
					return new Unit(UnitType.Archer);
					break;
				case "späh":
				case "späher":
					return new Unit(UnitType.Spy);
					break;
				case "lkav":
				case "leichte kavallerie":
					return new Unit(UnitType.Light);
					break;
				case "bbogen":
				case "berittener bogenschütze":
					return new Unit(UnitType.MArcher);
					break;
				case "skav":
				case "schwere kavallerie":
					return new Unit(UnitType.Heavy);
					break;
				case "ramme":
				case "rammbock":
					return new Unit(UnitType.Ram);
					break;
				case "ag":
				case "adelsgeschlecht":
					return new Unit(UnitType.Snob);
					break;
				case "pala":
				case "paladin":
					return new Unit(UnitType.Knight);
					break;
			}

			return new Unit();
		}
	}
}
