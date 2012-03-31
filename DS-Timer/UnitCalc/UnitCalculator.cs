using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DS_Timer.UnitCalc.Units;
using DS_Timer.World;

namespace DS_Timer.UnitCalc
{
	public class UnitCalculator : INotifyPropertyChanged
	{
		private List<BaseUnit> m_Units = new List<BaseUnit>();
		private Spear m_Spear = new Spear();
		private Sword m_Sword = new Sword();
		private Axe m_Axe = new Axe();
		private Archer m_Archer = new Archer();
		private Spy m_Spy = new Spy();
		private Light m_Light = new Light();
		private MArcher m_MArcher = new MArcher();
		private Heavy m_Heavy = new Heavy();
		private Ram m_Ram = new Ram();
		private Catapult m_Catapult = new Catapult();
		private Snob m_Snob = new Snob();
		private Knight m_Knight = new Knight();

		public int SpearAmount
		{
			get { return m_Spear.Amount; }
			set
			{
				m_Spear.Amount = value;
				Calculate();
			}
		}

		public int SwordAmount
		{
			get { return m_Sword.Amount; }
			set
			{
				m_Sword.Amount = value;
				Calculate();
			}
		}

		public int AxeAmount
		{
			get { return m_Axe.Amount; }
			set
			{
				m_Axe.Amount = value;
				Calculate();
			}
		}

		public int ArcherAmount
		{
			get { return m_Archer.Amount; }
			set
			{
				m_Archer.Amount = value;
				Calculate();
			}
		}

		public int SpyAmount
		{
			get { return m_Spy.Amount; }
			set
			{
				m_Spy.Amount = value;
				Calculate();
			}
		}

		public int LightAmount
		{
			get { return m_Light.Amount; }
			set
			{
				m_Light.Amount = value;
				Calculate();
			}
		}

		public int MArcherAmount
		{
			get { return m_MArcher.Amount; }
			set
			{
				m_MArcher.Amount = value;
				Calculate();
			}
		}

		public int HeavyAmount
		{
			get { return m_Heavy.Amount; }
			set
			{
				m_Heavy.Amount = value;
				Calculate();
			}
		}

		public int RamAmount
		{
			get { return m_Ram.Amount; }
			set
			{
				m_Ram.Amount = value;
				Calculate();
			}
		}

		public int CatapultAmount
		{
			get { return m_Catapult.Amount; }
			set
			{
				m_Catapult.Amount = value;
				Calculate();
			}
		}

		public int SnobAmount
		{
			get { return m_Snob.Amount; }
			set
			{
				m_Snob.Amount = value;
				Calculate();
			}
		}

		public int KnightAmount
		{
			get { return m_Knight.Amount; }
			set
			{
				m_Knight.Amount = value;
				Calculate();
			}
		}

		// Ressources
		public int VillagersCost
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.VillagersCost;
				}
				return result;
			}
		}
		public int WoodCost
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.WoodCost;
				}
				return result;
			}
		}
		public int ClayCost
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.ClayCost;
				}
				return result;
			}
		}
		public int IronCost
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.IronCost;
				}
				return result;
			}
		}

		// Battle Power

		public int Offensive
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.Offensive;
				}
				return result;
			}
		}
		public int GeneralDef
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.GeneralDef;
				}
				return result;
			}
		}
		public int CavalryDef
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.CavalryDef;
				}
				return result;
			}
		}

		public int ArcherDef
		{
			get
			{
				int result = 0;
				foreach (BaseUnit u in m_Units)
				{
					result += u.Amount * u.ArcherDef;
				}
				return result;
			}
		}

		// Buildtime
		public TimeSpan BarracksTime
		{
			get 
			{
				double baseBuildTime = (m_Spear.GetTotalBuildTime()
					+ m_Sword.GetTotalBuildTime()
					+ m_Axe.GetTotalBuildTime()
					+ m_Archer.GetTotalBuildTime()).TotalSeconds;

				double buildFactor = 0.665 * Math.Pow(0.94355, m_BarracksLevel);
				double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				//double buildFactor = 1 / (1.59 * Math.Pow(1.06, m_BarracksLevel - 1));
				//double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				return TimeSpan.FromSeconds(resultSec); 

			}
		}

		public TimeSpan StableTime
		{
			get
			{
				double baseBuildTime = (m_Spy.GetTotalBuildTime()
				  + m_Light.GetTotalBuildTime()
				  + m_MArcher.GetTotalBuildTime()
				  + m_Heavy.GetTotalBuildTime()).TotalSeconds;

				

				//double buildFactor = 1 / (1.59 * Math.Pow(1.06, m_StableLevel - 1));
				//double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				 //0.665 * 0.94355^20 * 2250 - Dumbo
				double buildFactor = 0.665 * Math.Pow(0.94355, m_StableLevel);
				double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				return TimeSpan.FromSeconds(resultSec); 
			}
		}

		public TimeSpan WorkshopTime
		{
			get
			{
				double baseBuildTime = (m_Ram.GetTotalBuildTime()
				+ m_Catapult.GetTotalBuildTime()).TotalSeconds;

				double buildFactor = 0.665 * Math.Pow(0.94355, m_WorkshopLevel);
				double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				//double buildFactor = 1 / (1.59 * Math.Pow(1.06289, m_WorkshopLevel - 1)); // Ab Welt 4
				//double resultSec = baseBuildTime * (1.0 / (double)WorldHandler.WorldSpeed) * buildFactor;

				return TimeSpan.FromSeconds(resultSec); 
			}
		}

		private int m_BarracksLevel = 25;

		public int BarracksLevel
		{
			get { return m_BarracksLevel; }
			set /* not variable yet */
			{
				m_BarracksLevel = value;
				Calculate();
			}
		}
		private int m_StableLevel = 20;

		public int StableLevel
		{
			get { return m_StableLevel; }
			set /* not variable yet */
			{
				m_StableLevel = value;
				Calculate();
			}
		}
		private int m_WorkshopLevel = 15;

		public int WorkshopLevel
		{
			get { return m_WorkshopLevel; }
			set /* not variable yet */
			{
				m_WorkshopLevel = value;
				Calculate();
			}
		}

		public UnitCalculator()
		{
			m_Units.Add(m_Spear);
			m_Units.Add(m_Sword);
			m_Units.Add(m_Axe);
			m_Units.Add(m_Archer);
			m_Units.Add(m_Spy);
			m_Units.Add(m_Light);
			m_Units.Add(m_MArcher);
			m_Units.Add(m_Heavy);
			m_Units.Add(m_Ram);
			m_Units.Add(m_Catapult);
			m_Units.Add(m_Snob);
			m_Units.Add(m_Knight);
		}

		private void Calculate()
		{
			NotifyPropertyChanged("VillagersCost");
			NotifyPropertyChanged("WoodCost");
			NotifyPropertyChanged("ClayCost");
			NotifyPropertyChanged("IronCost");

			NotifyPropertyChanged("Offensive");
			NotifyPropertyChanged("GeneralDef");
			NotifyPropertyChanged("CavalryDef");
			NotifyPropertyChanged("ArcherDef");

			NotifyPropertyChanged("BarracksTime");
			NotifyPropertyChanged("StableTime");
			NotifyPropertyChanged("WorkshopTime");
		}

		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
			}
		}

		#endregion
	}
}
