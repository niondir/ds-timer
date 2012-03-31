using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Drawing;
using DS_Timer.AttackPlaner;

namespace DS_Timer.World
{
    public class VillageFile : WorldFile
    {
        private List<VillageInfo> m_Villages = new List<VillageInfo>();

        public List<VillageInfo> Villages
        {
            get { return m_Villages; }
            set { m_Villages = value; }
        }

        //$id, $name, $x, $y, $player, $points, $rank
        public VillageFile(string fileName)
            : base(fileName)
        {

        }

        public override void ParseFile()
        {
            m_Villages.Clear();
            if (!File.Exists(FilePath))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ParseLine(line);
                }
            }
        }

        private void ParseLine(string line)
        {
            
            string[] token = line.Split(',');
            if (token.Length == 0) return;
            if (token.Length != 7)
            {
                throw new Exception("Invalid Line in Village file:\n" + line);
            }

            for (int i = 0; i < token.Length; i++)
            {
                token[i] = HttpUtility.UrlDecode(token[i]);
            }

            int id;
            string name = token[1];
            int x;
            int y;
            int player;
            int points;
            int rank;

            int.TryParse(token[0], out id);
            int.TryParse(token[2], out x);
            int.TryParse(token[3], out y);
            int.TryParse(token[4], out player);
            int.TryParse(token[5], out points);
            int.TryParse(token[5], out rank);

            m_Villages.Add(new VillageInfo(id, name, x, y, player, points, rank));
        }

		public VillageInfo FindByLoc(Location pos)
        {
            foreach (VillageInfo vi in m_Villages)
            {
                if (vi.X == pos.X && vi.Y == pos.Y)
                {
                    return vi;
                }
            }
            return VillageInfo.NullVillage;
        }

        public List<VillageInfo> FindByPlayer(PlayerInfo player)
        {
            List<VillageInfo> result = new List<VillageInfo>();
            foreach (VillageInfo pi in m_Villages)
            {
                if (pi.Player == player.Id)
                {
                    result.Add(pi);
                }
            }
            return result;
        }
    }
}
