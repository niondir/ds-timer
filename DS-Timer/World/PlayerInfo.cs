using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.World
{
    public class PlayerInfo
    {
        // $id, $name, $ally, $villages, $points, $rank
        public int Id { get; private set; }
        public String Name { get; private set; }
        public int Ally { get; private set; }
        public int Villages { get; private set; }
        public int Points { get; private set; }
        public int Rank { get; private set; }

        public static PlayerInfo NullPlayer = new PlayerInfo(-1, "", 0, 0, 0, 0);

        public PlayerInfo(int id, string name, int ally, int villages, int points, int rank)
        {
            this.Id = id;
            this.Name = name;
            this.Ally = ally;
            this.Villages = villages;
            this.Points = points;
            this.Rank = rank;
        }
    }
}
