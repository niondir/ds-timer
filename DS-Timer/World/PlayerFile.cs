using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace DS_Timer.World
{
    public class PlayerFile : WorldFile
    {
        private List<PlayerInfo> m_Players = new List<PlayerInfo>();

        public List<PlayerInfo> Players
        {
            get { return m_Players; }
            set { m_Players = value; }
        }

        // $id, $name, $ally, $villages, $points, $rank
        public PlayerFile(string fileName)
            : base(fileName)
        {

        }

        public override void ParseFile()
        {
            m_Players.Clear();
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
            if (token.Length != 6)
            {
                throw new Exception("Invalid Line in Player file:\n" + line);
            }

            for (int i = 0; i < token.Length; i++)
            {
                token[i] = HttpUtility.UrlDecode(token[i]);
            }

            int id;
            string name = token[1];
            int ally;
            int villages;
            int points;
            int rank;

            int.TryParse(token[0], out id);
            int.TryParse(token[2], out ally);
            int.TryParse(token[3], out villages);
            int.TryParse(token[4], out points);
            int.TryParse(token[5], out rank);

            m_Players.Add(new PlayerInfo(id, name, ally, villages, points, rank));
        }

        public PlayerInfo FindById(int id)
        {
            foreach (PlayerInfo pi in m_Players)
            {
                if (pi.Id == id)
                    return pi;
            }

            return PlayerInfo.NullPlayer;
        }

        public PlayerInfo FindByName(string name)
        {
            foreach (PlayerInfo pi in m_Players)
            {
                if (pi.Name.ToLower() == name.ToLower())
                    return pi;
            }

            return PlayerInfo.NullPlayer;
        }
    }
}
