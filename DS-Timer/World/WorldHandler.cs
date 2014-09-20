using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net;
using DS_Timer.Properties;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Core;
using System.Windows.Forms;

namespace DS_Timer.World
{
	public class WorldHandler
	{
		private BindingList<WorldInfo> m_Wolrds = new BindingList<WorldInfo>();
		private string m_DownloadDir;

		private static WorldConfigFile m_ConfigFile;
		private static VillageFile m_VillageFile;
		private static PlayerFile m_PlayerFile;
		
		public BindingList<Server> Servers { get; set; }

		public BindingList<WorldInfo> Wolrds
		{
			get { return m_Wolrds; }
		}

		public static WorldConfigFile ConfigFile
		{
			get { return m_ConfigFile; }
			private set { m_ConfigFile = value; }
		}

		public static VillageFile VillageFile
		{
			get { return m_VillageFile; }
			private set { m_VillageFile = value; }
		}

		public static PlayerFile PlayerFile
		{
			get { return m_PlayerFile; }
			private set { m_PlayerFile = value; }
		}

		/*
		public static List<ServersFile> ServersFiles
		{
			get { return WorldHandler.m_ServersFileDe; }
			private set { WorldHandler.m_ServersFileDe = value; }
		}*/

		public WorldInfo World { get; private set; }

		public static decimal WorldSpeed
		{
			get
			{
				return ConfigFile.WorldSpeed;
				//return Properties.Settings.Default.WorldSpeedFactor; 
			}
		}

		public static decimal UnitSpeed
		{
			get
			{
				return ConfigFile.WorldUnitSpeed;
				//return Properties.Settings.Default.WorldUnitSpeedFactor; 
			}
		}


		public DateTime LastWorldDownload
		{
			get
			{
				if (!File.Exists(m_ConfigFile.FilePath)) return DateTime.MinValue;
				return File.GetLastWriteTime(m_ConfigFile.FilePath);
			}
		}


		public WorldHandler()
		{
			m_DownloadDir = Program.GetUserDataPath();

			m_ConfigFile = new WorldConfigFile(Path.Combine(m_DownloadDir, "worldConfig.xml"));
			m_PlayerFile = new PlayerFile(Path.Combine(m_DownloadDir, "player.txt"));
			m_VillageFile = new VillageFile(Path.Combine(m_DownloadDir, "village.txt"));

			Servers = new BindingList<Server>(Program.Config.Servers);

			if (!Servers.Any())
			{
				Servers.Add(new Server("de", "http://www.die-staemme.de"));
				Servers.Add(new Server("ch", "http://www.staemme.ch"));
				Servers.Add(new Server("en", "http://www.tribalwars.net"));
				Servers.Add(new Server("nl", "http://www.tribalwars.nl/"));
				Servers.Add(new Server("pl", "http://www.plemiona.pl/"));
				Servers.Add(new Server("se", "http://www.tribalwars.se/"));
				Servers.Add(new Server("br", "http://www.tribalwars.com.br/"));
				Servers.Add(new Server("pt", "http://www.tribalwars.com.pt/"));
				Servers.Add(new Server("cz", "http://www.divokekmeny.cz/"));
				Servers.Add(new Server("jap", "http://www.bujokjeonjaeng.org/"));
				Servers.Add(new Server("ro", "http://www.triburile.ro/"));
				Program.Config.SaveConfig();
			}


			m_Wolrds.Add(new WorldInfo("Welt wählen", "", 1, 1));
			//DownloadServerInfo(); // Fill the WorldInfo

			ParseFiles();
		}

		public WorldDownloader DownloadServerInfo(Server server)
		{
			WorldDownloader serverInfoDownloader = new WorldDownloader();

			ServersFile serverFile = server.getServerFile(m_DownloadDir);

			serverInfoDownloader.DownloadsComplete += (sender, args) =>
				{
					serverFile.ParseFile();

					foreach (WorldInfo i in serverFile.WorldInfo)
					{
						m_Wolrds.Add(i);
					}
				};

			serverInfoDownloader.AddDownload(serverFile.Url, serverFile.FilePath);
			serverInfoDownloader.StartDownloads();
			return serverInfoDownloader;
		}

		public void SetServer(string server)
		{
			Settings.Default.DSServer = server;
			foreach (WorldInfo w in m_Wolrds)
			{
				if (w.Server == server)
				{
					World = w;
					return;
				}
			}
			World = new WorldInfo("Eigene", server, 1, 1);
		}

		public WorldDownloader DownloadWorldData()
		{
			if (World == null)
			{
				throw new NullReferenceException("WorldHandler.World is null");
			}

			WorldDownloader downloader = new WorldDownloader();
			downloader.DownloadsComplete += new EventHandler(downloader_DownloadsComplete);

			downloader.AddDownload(World.Server + "/interface.php?func=get_config", m_ConfigFile.FilePath);
			downloader.AddDownload(World.Server + "/map/village.txt.gz", m_VillageFile.FilePath + ".gz");
			downloader.AddDownload(World.Server + "/map/player.txt.gz", m_PlayerFile.FilePath + ".gz");

			downloader.StartDownloads();
			return downloader;

			// TODO: Download the world data from the DS server:
			// /map/ally.txt.gz - NOT YET
			// /map/conquer.txt.gz - NOT YET
			// /map/profile.txt.gz - NOT YET

			/*
 Die einzelnen Daten sind mit Hilfe der PHP-Funktion urlencode() codiert, dh. dass zB. ein Komma durch %2C ersetzt ist.

/map/ally.txt - /map/ally.txt.gz
In dieser Datei sind Informationen über die Stämme. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$id, $name, $tag, $members, $villages, $points, $all_points, $rank
/map/conquer.txt - /map/conquer.txt.gz
In dieser Datei sind alle Adelungen seit Beginn der Welt enthalten. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$village_id, $unix_timestamp, $new_owner, $old_owner
/interface.php?func=get_conquer&since=unix_timestamp
Über diese Funktion kann man sich alle Adelungen seit dem letzten Unix-Timestamp ausgeben lassen. Der Timestamp darf maximal 24 Stunden zurück liegen. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$village_id, $unix_timestamp, $new_owner, $old_owner
/map/profile.txt - /map/profile.txt.gz
In dieser Datei sind die Profildaten der Spieler. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$player_id, Geburtstag, Geschlecht, Wohnort, Profiltext (als XHTML), Profilbild-Dateiname
/interface.php?func=get_config
Über diese Funktion kann man die Konfiguration der Welt auslesen (Format: XML).
			 * */
		}

		void downloader_DownloadsComplete(object sender, EventArgs e)
		{
			UnpackFiles();
			ParseFiles();
		}

		private void UnpackFiles()
		{
			try
			{
				m_PlayerFile.ExtractGZip(m_PlayerFile.FilePath + ".gz");
				m_VillageFile.ExtractGZip(m_VillageFile.FilePath + ".gz");
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error in downloaded files: " + ex.Message);
			}
		}

		private void ParseFiles()
		{
			try
			{
				m_ConfigFile.ParseFile();
				m_PlayerFile.ParseFile();
				m_VillageFile.ParseFile();
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error in world files: " + ex.Message);
			}

		}
	}
}
