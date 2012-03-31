using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using DS_Timer.AttackPlaner;
using System.Xml.Serialization;

namespace DS_Timer.World
{
    //$id, $name, $x, $y, $player, $points, $rank
	[XmlRoot]
    public class VillageInfo : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Player { get; set; }
        public int Points { get; set; }
        public int Rank { get; set; }
		public string LongName { get { return String.Format("({0}|{1}) {2}", X, Y, Name); } }

        public static VillageInfo NullVillage = new VillageInfo(-1, "", 0, 0, 0, 0, 0);
        
        public Location Location
        {
            get
            {
				return new Location(X, Y);
            }
        }

		public VillageInfo()
			: this(-1, "", 0, 0, 0, 0, 0)
		{
		}

        public VillageInfo(int id, string name, int x, int y, int player, int points, int rank)
        {
            this.Id = id;
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Player = player;
            this.Points = points;
            this.Rank = rank;
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
