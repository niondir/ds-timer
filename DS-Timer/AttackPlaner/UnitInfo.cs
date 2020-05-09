using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS_Timer.World;
using System.Windows.Forms;

namespace DS_Timer.AttackPlaner
{
    public enum UnitType
    {
        Spear,
        Sword,
        Axe,
        Archer,
        Spy,
        Light,
        MArcher,
        Heavy,
        Ram,
        Catapult,
        Snob,
        Knight

    }

	public class UnitInfo
	{
		private static int m_lastId = 0;
		private static bool m_Initialized = false;

		private static List<UnitInfo> m_Units = new List<UnitInfo>();

		public static List<UnitInfo> Units
		{
			get
			{
				if (m_Units.Count == 0)
				{
					InitializeUnits();
				}
				return UnitInfo.m_Units;
			}
			set { UnitInfo.m_Units = value; }
		}


		private double m_Speed;

		public int Id { get; set; }
		public string AdvancedName { get { return String.Format("{0} [{1:0.##} min / Feld]", Name, Speed); } }
		public string AdvancedShortName { get { return String.Format("{0} [{1:0.##} min / Feld]", ShortName, Speed); } }
		public string Name { get; set; }
		public string ShortName { get; set; }

		/// <summary>
		/// Min / Field
		/// </summary>
		public double Speed
		{
			get { return m_Speed / (double)WorldHandler.UnitSpeed / (double)WorldHandler.WorldSpeed; }
			set { m_Speed = value; }
		}


		private UnitInfo(string name, string shortName, double speed)
		{
			Id = m_lastId++;
			Name = name;
			ShortName = shortName;
			Speed = speed;
			m_Units.Add(this);
		}


		public static void InitializeUnits()
		{
			if (m_Initialized) return;
			m_Initialized = true;

			DSTimerConfig cfg = DSTimerConfig.LoadConfig(DSTimerConfig.DefaultPath);

			if (Program.Language == LanguageType.English)
			{
				new UnitInfo("Spear fighter", "Spear", cfg.SpearSpeed);
				new UnitInfo("Swordsman", "Sword", cfg.SwordSpeed);
				new UnitInfo("Axeman", "Axe", cfg.AxeSpeed);
				new UnitInfo("Archer", "Archer", cfg.ArcherSpeed); // Ab Welt 10
				new UnitInfo("Scout", "Spy", cfg.ScoutSpeed);
				new UnitInfo("Light cavalry", "Light", cfg.LCavSpeed);
				new UnitInfo("Mounted archer", "MArcher", cfg.MArchSpeed); // Ab Welt 10
				new UnitInfo("Heavy cavalry", "Heavy", cfg.HCavSpeed);
				new UnitInfo("Ram", "Ram", cfg.RamSpeed);
				new UnitInfo("Catapult", "Catapult", cfg.CataSpeed);
				new UnitInfo("Nobleman", "Snob", cfg.SnobSpeed);
				new UnitInfo("Paladin", "Knight", cfg.PalaSpeed);
			}
			else
			{
				new UnitInfo("Speerträger", "Speer", cfg.SpearSpeed);
				new UnitInfo("Schwertkämpfer", "Schwert", cfg.SwordSpeed);
				new UnitInfo("Axtkämpfer", "Axt", cfg.AxeSpeed);
				new UnitInfo("Bogenschütze", "Bogen", cfg.ArcherSpeed); // Ab Welt 10
				new UnitInfo("Späher", "Späh", cfg.ScoutSpeed);
				new UnitInfo("Leichte Kavallerie", "LKav", cfg.LCavSpeed);
				new UnitInfo("Berittener Bogenschütze", "BBogen", cfg.MArchSpeed); // Ab Welt 10
				new UnitInfo("Schwere Kavallerie", "SKav", cfg.HCavSpeed);
				new UnitInfo("Ramme", "Ramme", cfg.RamSpeed);
				new UnitInfo("Katapult", "Kata", cfg.CataSpeed);
				new UnitInfo("Adelsgeschlecht", "AG", cfg.SnobSpeed);
				new UnitInfo("Paladin", "Pala", cfg.PalaSpeed);
			}
		}

		public static UnitInfo GetById(int id)
		{
			foreach (UnitInfo u in Units)
			{
				if (u.Id == id) return u;
			}
			throw new ArgumentException("id out of range");
		}

	
	}
}
