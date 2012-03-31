using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS_Timer.Util;
using System.ComponentModel;
using System.Diagnostics;
using DS_Timer.Properties;
using DS_Timer.World;
using DS_Timer.TimeSync;

namespace DS_Timer.AttackPlaner
{
	public class AttackPlanHandler : INotifyPropertyChanged
	{
		// old
		//private SortableBindingList<AttackOrder> m_AttackOrders = new SortableBindingList<AttackOrder>();
		
		private BindingList<Unit> m_Units = new BindingList<Unit>();
		private BindingList<VillageList> m_VillageLists = new BindingList<VillageList>();
		private BindingList<AttackPlan> m_AttackPlans = new BindingList<AttackPlan>();
		private AttackPlan m_CurrentAttackPlan;

		public BindingList<Unit> Units
		{
			get { return m_Units; }
			set { m_Units = value; }
		}

		public BindingList<VillageList> VillageLists
		{
			get { return m_VillageLists; }
		}

		public BindingList<AttackPlan> AttackPlans
		{
			get { return m_AttackPlans; }
			set { m_AttackPlans = value; }
		}

		/// <summary>
		/// Never null
		/// </summary>
		public AttackPlan CurrentAttackPlan
		{
			get 
			{
				if (m_CurrentAttackPlan == null || AttackPlans.Count == 0)
				{
					if (AttackPlans.Count > 0)
					{
						m_CurrentAttackPlan = AttackPlans[0];
					}
					else
					{
						m_CurrentAttackPlan = new AttackPlan();
						AttackPlans.Add(m_CurrentAttackPlan);
					}
				}
				return m_CurrentAttackPlan; 
			
			}
			set
			{
				m_CurrentAttackPlan = value;
				NotifyPropertyChanged("CurrentAttackPlan");
			}
		}

		public AttackOrder NextOrder
		{
			get
			{
				AttackOrder next = new NullAttackOrder();
				foreach (AttackOrder o in CurrentAttackPlan.AttackOrders)
				{
					if (next is NullAttackOrder && o.SendTime > TimeSyncHandler.Now)
					{
						next = o;
					}
					else if (!(next is NullAttackOrder) && (o.SendTime < next.SendTime && o.SendTime > TimeSyncHandler.Now))
					{
						next = o;
					}
				}
				return next;
			}
		}


		

		

		public AttackPlanHandler()
		{
			foreach (UnitInfo i in UnitInfo.Units)
			{
				m_Units.Add(new Unit(i.Id));
			}
			//m_Units.Add(new Unit("Miliz", 18));

		}


		public void OpenBrowser(AttackOrder attackOrder)
		{
			string url = attackOrder.GetAttackUrl(Settings.Default.DSServer);
			//like "http://de68.die-staemme.de/game.php?village=63062&screen=place&mode=command&target=57821"
			Process.Start(url);
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



		public void LoadAttackOrders()
		{
			this.m_VillageLists = VillageList.DeserializeFromXml();
			this.m_AttackPlans = AttackPlan.DeserializeFromXml();
		}

		public void SaveAttackOrders()
		{
			VillageList.SerializeToXml(m_VillageLists);
			AttackPlan.SerializeToXml(m_AttackPlans);
		}
	}

}
