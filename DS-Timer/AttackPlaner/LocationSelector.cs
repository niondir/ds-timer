using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DS_Timer.World;
using System.ComponentModel;

namespace DS_Timer.AttackPlaner
{
	public class LocationSelector : INotifyPropertyChanged
	{
		//DataBindings an Village und Player
		private BindingList<VillageInfo> m_Villages = new BindingList<VillageInfo>();
		private VillageInfo m_SelectedVillage = VillageInfo.NullVillage;
		private PlayerInfo m_Player = PlayerInfo.NullPlayer;

		public BindingList<VillageInfo> Villages
		{
			get { return m_Villages; }

		}

		public VillageInfo SelectedVillage
		{
			get { return m_SelectedVillage; }
			set // Public for DataBinding
			{
				m_SelectedVillage = value;
				NotifyPropertyChanged("SelectedVillage");
			}
		}

		public PlayerInfo Player
		{
			get { return m_Player; }
			set
			{
				m_Player = value;
				PlayerName = value.Name;
				NotifyPropertyChanged("Player");
				NotifyPropertyChanged("PlayerName");
			}
		}

		// Just for Binding
		public string PlayerName
		{
			get;
			set;
		}


		public void SetVillage(VillageInfo village)
		{
			PlayerInfo player = WorldHandler.PlayerFile.FindById(village.Player);
			SetPlayer(player);

			// Work?
			SelectedVillage = village;
		}


		public void SetLocation(Location loc)
		{
			VillageInfo village = WorldHandler.VillageFile.FindByLoc(loc);
			PlayerInfo player = WorldHandler.PlayerFile.FindById(village.Player);
			SetPlayer(player);

			// Work?
			SelectedVillage = village;
		}

		public void SetPlayer(string playerName)
		{
			PlayerInfo player = WorldHandler.PlayerFile.FindByName(playerName);
			SetPlayer(player);
		}

		public void SetPlayer(PlayerInfo player)
		{
			if (Player == player) return;

			Player = player;
			List<VillageInfo> villages = WorldHandler.VillageFile.FindByPlayer(player);
			villages.Sort(new Comparison<VillageInfo>(
				(v1, v2) =>
				{
					return v1.Name.CompareTo(v2.Name);
				}
				));
			m_Villages.Clear();

			// Slow Code:
			foreach (VillageInfo v in villages)
			{
				m_Villages.Add(v);
			}


			//NotifyPropertyChanged("SelectedVillage");
			/*
			if (m_Villages.Count > 0)
			{
				SelectedVillage = m_Villages[0];
			}
			else
			{
				SelectedVillage = VillageInfo.NullVillage;
			}
			 * */

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
