using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using DS_Timer.World;
using DS_Timer.Properties;
using DS_Timer.TimeSync;

namespace DS_Timer.AttackPlaner
{
	[XmlRoot]
	public class AttackOrder : INotifyPropertyChanged
	{
		private DateTime m_arrivleTime;
		private string m_comment;
		private Location m_startLocation;
		private Location m_destination;
		//private Unit m_Unit;
		private int m_UnitId;


		VillageInfo m_StartVilliage;

		PlayerInfo m_StartPlayer;

		VillageInfo m_TargetVillage = VillageInfo.NullVillage;

		PlayerInfo m_TargetPlayer = PlayerInfo.NullPlayer;
		

		public string Comment
		{
			get { return m_comment; }
			set
			{
				m_comment = value;
				NotifyPropertyChanged("Comment");
			}
		}

		public string StartLocationString
		{
			get
			{
				return String.Format("({0}|{1}) {2}", m_StartVilliage.X, m_StartVilliage.Y, m_StartVilliage.Name);
			}
			set { } // For DataBinding
		}

		public string TargetLocationString
		{
			get
			{
				return String.Format("({0}|{1}) {2}", m_TargetVillage.X, m_TargetVillage.Y, m_TargetVillage.Name);
			}
			set { } // For DataBinding
		}

		public Location StartLocation
		{
			get { return m_startLocation; }
			set
			{
				m_startLocation = value;
				UpdateStartInfos();
				NotifyPropertyChanged("StartLocation");
				NotifyPropertyChanged("SendTime");
				NotifyPropertyChanged("StartPlayer");
				NotifyPropertyChanged("StartLocationString");
			}
		}


		[XmlElement("Destination")]
		public Location TargetLocation
		{
			get { return m_destination; }
			set
			{
				m_destination = value;
				UpdateTargetInfos();
				NotifyPropertyChanged("TargetLocation");
				NotifyPropertyChanged("SendTime");
				NotifyPropertyChanged("TargetPlayer");
				NotifyPropertyChanged("TargetLocationString");
				
                
			}
		}

		[XmlIgnore]
		public VillageInfo StartVilliage
		{
			get { return m_StartVilliage; }
		}
		[XmlIgnore]
		public VillageInfo TargetVillage
		{
			get { return m_TargetVillage; }
		}

		/*
		public Location Destination
		{
			get { return TargetLocation; }
			set { TargetLocation = value; }
		}*/

        [XmlIgnore]
        public TimeSpan RemainingTime
        {
            get
            {
				TimeSpan remaining = SendTime - TimeSyncHandler.Now;
                if (remaining < TimeSpan.Zero)
                    remaining = TimeSpan.Zero;
                return remaining;
            }
        }

        [XmlIgnore]
        public String RemainingTimeString
        {
            get
            {
                TimeSpan time = RemainingTime;
                if (time >= TimeSpan.Zero)
                {
                    return String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
                }
                else
                {
                    return String.Format("-{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
                }
                 
            }
        }

		/// <summary>
		/// Depends on ArriivleTime, Distance and UnitSpeed
		/// </summary>
        [XmlIgnore]
		public DateTime SendTime
		{
			get 
			{
				int distInSec = CalcSecondsBetween(StartLocation, TargetLocation);
                try
                {
					if (m_arrivleTime > DateTime.MinValue)
					{
						return m_arrivleTime - TimeSpan.FromSeconds(distInSec);
					}
					else
					{
						return DateTime.MinValue;
					}
                }
                catch (Exception)
                {
                    return DateTime.MinValue;
                }
			}
            set
            {
                int distInSec = CalcSecondsBetween(StartLocation, TargetLocation);
                ArrivleTime = value + TimeSpan.FromSeconds(distInSec);
            }
		}

		public DateTime ArrivleTime
		{
			get { return m_arrivleTime; }
			set
			{
				m_arrivleTime = value;
				NotifyPropertyChanged("ArrivleTime");
				NotifyPropertyChanged("SendTime");
			}
		}

		public int UnitId
		{
			get { return m_UnitId; }
			set
			{
				m_UnitId = value;
				NotifyPropertyChanged("UnitId");
				NotifyPropertyChanged("Unit");
				NotifyPropertyChanged("SendTime");
			}
		}

		[XmlIgnore]
		public Unit Unit
		{
			get { return new Unit(UnitId); }
            set { UnitId = value.Id; }
		}

		[XmlIgnore]
        public string StartPlayer
        {
            get { return m_StartPlayer.Name; }
        }

		[XmlIgnore]
        public string TargetPlayer
        {
            get { return m_TargetPlayer.Name; }
        }

		public AttackOrder()
		{
			
		}

		public void UpdateRemainingTime()
		{
			NotifyPropertyChanged("RemainingTime");
			NotifyPropertyChanged("RemainingTimeString");
			
		}

		public string GetAttackUrl(string dsServer)
		{
			VillageInfo start = WorldHandler.VillageFile.FindByLoc(this.StartLocation);
			VillageInfo target = WorldHandler.VillageFile.FindByLoc(this.TargetLocation);
			return String.Format("{0}/game.php?village={1}&screen=place&mode=command&target={2}", dsServer, start.Id, target.Id);
		}

		private double CalculateDistance(Location from, Location to)
		{
			Location dist = to - from;
            double distFields = Math.Sqrt(dist.X * dist.X + dist.Y * dist.Y);
            return distFields;
		}

		private int CalcSecondsBetween(Location pos1, Location pos2)
        {
            return (int)Math.Round(CalculateDistance(pos1, pos2) * this.Unit.Speed * 60);
        }

        private void UpdateStartInfos()
        {
            m_StartVilliage = WorldHandler.VillageFile.FindByLoc(StartLocation);
			m_StartPlayer = WorldHandler.PlayerFile.FindById(m_StartVilliage.Player);
  			
        }

        private void UpdateTargetInfos()
        {
			m_TargetVillage = WorldHandler.VillageFile.FindByLoc(TargetLocation);
			m_TargetPlayer = WorldHandler.PlayerFile.FindById(m_TargetVillage.Player);
        }

        public void SetUnitFromSendTime(DateTime sendTime)
        {
            double distance = CalculateDistance(StartLocation, TargetLocation);
            TimeSpan time = ArrivleTime - sendTime;

            double speed = Math.Round(time.TotalMinutes / distance, 2);

            foreach (UnitInfo u in UnitInfo.Units)
            {
                if (u.Speed == speed)
                {
                    this.UnitId = u.Id;
                }
            }
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

		#region serialization
		public static void SerializeToXml(List<AttackOrder> attackOrders)
		{
			XmlSerializer writer = new XmlSerializer(typeof(List<AttackOrder>));
            string dir = Program.GetUserDataPath();

			TextWriter textWriter = new StreamWriter(Path.Combine(dir, "AttackPlan.xml"));
			writer.Serialize(textWriter, attackOrders);
			textWriter.Close();
		}

		public static List<AttackOrder> DeserializeFromXml()
		{
			try
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(List<AttackOrder>));
                // Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
				string dir = Program.GetUserDataPath();
				TextReader textReader = new StreamReader(Path.Combine(dir, "AttackPlan.xml"));
				List<AttackOrder> attackOrders;
				attackOrders = (List<AttackOrder>)deserializer.Deserialize(textReader);
				textReader.Close();

				return attackOrders;
			}
			catch (Exception)
			{
				return new List<AttackOrder>();
			}
		}
		#endregion

        
    }
}
